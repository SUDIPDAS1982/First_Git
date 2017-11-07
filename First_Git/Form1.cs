using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Git
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			label1.Visible = true;
			label1.Text = "Welcome to Git era.";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			label1.Visible = false;
		}
	}
}
