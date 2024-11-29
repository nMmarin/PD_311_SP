﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Processes
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			string cmd = textBoxProgram.Text;
			if (comboBoxPrograms.Text.Length > 0) cmd = comboBoxPrograms.Text;
			string[] splitted = cmd.Split(' ');
			string file = splitted[0];
			string arguments = "";
			if (splitted.Length > 1) arguments = cmd.Remove(0, cmd.IndexOf(' '));
			process.StartInfo.FileName = file;
			process.StartInfo.Arguments = arguments;
			//Наш процесс пытается найти запускаемый процесс сначала в своем рабочем каталоге,
			//а потом в системных каталогах, включая все каталоги, хранимые в переменной окружения %PATH%.
			//Все переменные окружения Windows можно отобразить командой 'set'.
			//Если указанный процесс не найден, то возникает исключительная ситуация: 
			//	System.ComponentModel.Win32Exception Не удается найти указанный файл
			try
			{
				process.Start();
				if(!comboBoxPrograms.Items.Contains(cmd))comboBoxPrograms.Items.Add(cmd);
			}
			catch (System.ComponentModel.Win32Exception ex)
			{
				MessageBox.Show(this, ex.GetType().ToString() + '\n' + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.GetType().ToString() + '\n' + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
