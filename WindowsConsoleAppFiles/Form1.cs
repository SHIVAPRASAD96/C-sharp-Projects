using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Hello World ,", "You are awesome!", MessageBoxButtons.OK, MessageBoxIcon.Hand);

           MessageBox.Show("Hey a Basic Message!!");

           // label1.Text("Hello You just Clicked a Button");
        }
    }
}
