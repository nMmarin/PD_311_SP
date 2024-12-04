using System;
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
		//Process[] processes;
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
			//listViewProcesses.Items
			//	.Add(processes[i]).SubItems
			//	.Add(processes[i].ProcessName);
			//KeyValuePair<int, Process> pair = processes.ElementAt(i);
			//}

			foreach (KeyValuePair<int, Process> p in processes)
			{
				//listViewProcesses.Items.Add(p.ToString()).SubItems.Add(p.Value.ProcessName);
				//ListViewItem item = new ListViewItem();
				//item.Name =item.Text = p.Key.ToString();
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
				//if (processes[Convert.ToInt32(i.SubItems[0]])])
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

		private void timer_Tick(object sender, EventArgs e)
		{
			RefreshProcesses();
			toolStripStatusLabelProcessCount.Text = $"Processec Count: {listViewProcesses.Items.Count.ToString()}";
		}
		private void mainMenuFileRun_Click_1(object sender, EventArgs e)
		{
			RunFileDlg(this.Handle, IntPtr.Zero, "C:\\Windows\\System32\\", "Run PD_311", "Task manager! Привет от PD_311", 0);
		}
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
	}
}
//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Windows.Forms;

//namespace TaskManager
//{
//    public partial class MainForm : Form
//    {
//        Dictionary<int, Process> processes;

//        public MainForm()
//        {
//            InitializeComponent();
//            LoadProcesses();

//            timer.Interval = 1000; // Начальный интервал (Normal - 1 секунда)
//            timer.Start();

//            // Подписываемся на события выбора пунктов в меню
//            mainMenuViewRateHigh.Click += RefreshRateMenuItem_Click;
//            mainMenuViewRateNormal.Click += RefreshRateMenuItem_Click;
//            mainMenuViewRateLow.Click += RefreshRateMenuItem_Click;

//            //  начальная выборка в меню Normal
//            mainMenuViewRateNormal.Checked = true;
//        }

//        private void LoadProcesses()
//        {
//            processes = Process.GetProcesses().ToDictionary(i => i.Id);

//            foreach (KeyValuePair<int, Process> p in processes)
//            {
//                AddProcessToListView(p.Value);
//            }
//        }

//        private void AddNewProcesses()
//        {
//            foreach (KeyValuePair<int, Process> p in processes)
//            {
//                if (!listViewProcesses.Items.ContainsKey(p.Key.ToString()))
//                {
//                    AddProcessToListView(p.Value);
//                }
//            }
//        }

//        private void AddProcessToListView(Process p)
//        {
//            ListViewItem item = new ListViewItem();
//            item.Name = item.Text = p.Id.ToString();
//            item.SubItems.Add(p.ProcessName);
//            listViewProcesses.Items.Add(item);
//        }

//        private void RemoveOldProcesses()
//        {
//            foreach (ListViewItem i in listViewProcesses.Items)
//            {
//                if (!processes.ContainsKey(Convert.ToInt32(i.SubItems[0].Text)))
//                {
//                    listViewProcesses.Items.Remove(i);
//                }
//            }
//        }

//        private void RefreshProcesses()
//        {
//            processes = Process.GetProcesses().ToDictionary(i => i.Id);
//            RemoveOldProcesses();
//            AddNewProcesses();
//        }

//        private void timer_Tick(object sender, EventArgs e)
//        {
//            RefreshProcesses();
//            toolStripStatusLabelProcessCount.Text = $"Processes Count: {listViewProcesses.Items.Count.ToString()}";
//        }

//        // Обработчик изменения интервала из меню
//        private void RefreshRateMenuItem_Click(object sender, EventArgs e)
//        {
//            // Снимаем выделение со всех пунктов меню
//            mainMenuViewRateHigh.Checked = false;
//            mainMenuViewRateNormal.Checked = false;
//            mainMenuViewRateLow.Checked = false;

//            // Меняем интервал таймера в зависимости от выбранной опции
//            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;

//            if (clickedItem != null)
//            {
//                // галкка на выбранный элемент
//                clickedItem.Checked = true;

//                // Обновление  интервала
//                switch (clickedItem.Name)
//                {
//                    case "highToolStripMenuItem":
//                        timer.Interval = 500;  //  частота обновления 0.5с
//                        break;
//                    case "normalToolStripMenuItem":
//                        timer.Interval = 1000; //  частота обновления 1с
//                        break;
//                    case "lowToolStripMenuItem":
//                        timer.Interval = 5000; //  частота обновления 5с
//                        break;
//                    default:
//                        timer.Interval = 1000; // по умолчанию 1с
//                        break;
//                }
//            }
//        }
//    }
//}

