using System.Threading;
using System.Windows.Forms;

namespace Yahoo
{
    public partial class Form3 : Form
    {
        public Form3()
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

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.ExitThread();
            Application.Exit();
        }
    }
}
