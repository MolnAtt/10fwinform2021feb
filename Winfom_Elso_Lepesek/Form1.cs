using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winfom_Elso_Lepesek
{
	public partial class Form1 : Form
	{

		private Label cimke = new Label();
		private Button gomb = new Button();

		private Timer metronóm = new Timer();

		public Form1()
		{
			InitializeComponent();

			// MessageBox.Show("asdéfklj");

			cimke.Text = "hello world";
			Controls.Add(cimke);

			cimke.Location = new Point(50,50);

			gomb.Text = "ez egy gomb";
			Controls.Add(gomb);

			gomb.Location = new Point(200, 50);

			gomb.Click += Köszönés;

			metronóm.Interval = 100;

			metronóm.Tick += Ketyeg;


		}
		int i = 0;

		private void Ketyeg(object sender, EventArgs e)
		{
			cimke.Text = i++.ToString();
		}
		private void Köszönés (object sender, EventArgs e)
		{	
			metronóm.Start();
		}

	}
}
