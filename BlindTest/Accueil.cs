using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlindTest
{
	public partial class Accueil : Form
	{
		public Accueil()
		{
			InitializeComponent();
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

       private void button2_Click_1(object sender, EventArgs e)
        {
            Reglements PageRegle = new Reglements();
            PageRegle.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
