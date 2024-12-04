﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace TaskManager
{
	public partial class MainForm : Form
	{
		Dictionary<int, Process> processes;
		public MainForm()
		{
			InitializeComponent();
			LoadProcesses();
		}

		void LoadProcesses()
		{
			processes = Process.GetProcesses().ToDictionary(i => i.Id);
			//for (int i = 0; i < processes.Count; i++)
			//{
			//	//listViewProcesses.Items
			//	//	.Add(processes[i]).SubItems
			//	//	.Add(processes[i].ProcessName);
			//}
			foreach (KeyValuePair<int, Process> p in processes)
			{
				//listViewProcesses.Items.Add(p.Key.ToString()).SubItems.Add(p.Value.ProcessName);
				//----------------------
				//ListViewItem item = new ListViewItem();
				//item.Name = item.Text = p.Key.ToString();
				//item.SubItems.Add(p.Value.ProcessName);
				//listViewProcesses.Items.Add(item);
				AddProcessToListView(p.Value);
			}
		}
		void AddNewProcesses()
		{
			foreach (KeyValuePair<int, Process> p in processes)
			{
				if (!listViewProcesses.Items.ContainsKey(p.Key.ToString()))
				{
					//listViewProcesses.Items.Add(p.Key.ToString()).SubItems.Add(p.Value.ProcessName);
					//------------------------------
					AddProcessToListView(p.Value);
				}
			}
		}
		void AddProcessToListView(Process p)
		{
			ListViewItem item = new ListViewItem();
			item.Name = item.Text = p.Id.ToString();
			item.SubItems.Add(p.ProcessName);
			listViewProcesses.Items.Add(item);
		}
		void RemoveOldProcesses()
		{
			foreach (ListViewItem i in listViewProcesses.Items)
			{
				//if (processes[Convert.ToInt32(i.SubItems[0].Text)])
				if (!processes.ContainsKey(Convert.ToInt32(i.SubItems[0].Text)))
				{
					listViewProcesses.Items.Remove(i);
				}
			}
		}
		void RefreshProcesses()
		{
			processes = Process.GetProcesses().ToDictionary(i => i.Id);
			RemoveOldProcesses();
			AddNewProcesses();
		}
		void DestroyProcess(int pid)
		{
			processes[pid].Kill();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			RefreshProcesses();
			toolStripStatusLabelProcessCount.Text = $"Processes count: {listViewProcesses.Items.Count.ToString()}";
		}

		private void mainMenuFileRun_Click(object sender, EventArgs e)
		{
			RunFileDlg(this.Handle, IntPtr.Zero, "C:\\Windows\\System32\\", "Run PD_311", "Task manager! Привет от PD_311 ;-)", 1);
		}
		//https://stackoverflow.com/questions/9331088/how-to-start-windows-run-dialog-from-c-sharp
		[DllImport("shell32.dll", EntryPoint = "#61", CharSet = CharSet.Unicode)]
		public static extern int RunFileDlg
			(
				[In] IntPtr hwnd,
				[In] IntPtr icon,
				[In] string path,
				[In] string title,
				[In] string prompt,
				[In] uint flags
			);

		private void destroyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (listViewProcesses.SelectedItems.Count > 0)
				DestroyProcess(Convert.ToInt32(listViewProcesses.SelectedItems[0].Name));
		}
	}
}
