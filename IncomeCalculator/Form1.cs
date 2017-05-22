using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeCalculator
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {
           

        }

        private void calculatebtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(wagetxt.Text) && !string.IsNullOrEmpty(hourstxt.Text))
            {
                try
                {

                float wage = Single.Parse(wagetxt.Text);
                float hours = Single.Parse(hourstxt.Text);
                totaltxt.Text = string.Format("£{0:0.00}", wage * hours);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Only numbers please");
                    wagetxt.Clear();
                    hourstxt.Clear();

                }

               
            }

        }

        private void totaltxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
