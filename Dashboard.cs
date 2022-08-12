using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahoo
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            void loaddata()
            {
                for (int i = 0; i < 500; i++)
                {
                    Thread.Sleep(10);
                }
            }
            using (progressbar frm = new progressbar(loaddata))
            {
                frm.ShowDialog(this);
            }
        }

       

        private void Clickhere_Btn1_Click(object sender, EventArgs e)
        {
            SmartSymptomAnalyser Smart = new SmartSymptomAnalyser();
            Smart.Show();
            this.Hide();

          
        }

        private void Clickhere_btn2_Click(object sender, EventArgs e)
        {
            reportanalyzer r = new reportanalyzer();
            r.Show();
            this.Hide();
           
        }

        private void Clickhere_btn4_Click(object sender, EventArgs e)
        {
            dietplan d = new dietplan();
            d.Show();
            this.Hide();
          
        }

        private void Clickhere_btn3_Click(object sender, EventArgs e)
        {
            viewrecords vi = new viewrecords();
            vi.Show();
            this.Hide();
           
        }


    }
}
