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
    public partial class reportanalyzer : Form
    {
        public reportanalyzer()
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

        private void upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                reportpicture.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
