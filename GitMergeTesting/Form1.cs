﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace GitMergeTesting
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			textBox1.BackColor = Color.Yellow;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = "hotfix";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = "test string";
		}
	}
}
