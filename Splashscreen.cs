using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Yahoo
{
    public partial class Splashscreen : Form
    {
        public Splashscreen()
        {
            InitializeComponent();
            void loaddata()
            {
                for (int i = 0; i < 500; i++)
                {
                    Thread.Sleep(10);
                }
            }
            using (Splash frm = new Splash(loaddata))
            {
                frm.ShowDialog(this);
            }

            // MessageBox.Show("Welcome To Smart Health System!", "Smart Health", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void linkLabel1_MouseClick(object sender, MouseEventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void Skip_Btn_Click(object sender, System.EventArgs e)
        {
            // MessageBox.Show("Coming Soon!", "Smart Health", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Dashboard D1 = new Dashboard();
            D1.Show();
            this.Hide();

        }

        private void Skip_Btn_MouseClick(object sender, MouseEventArgs e)
        {
            Random randomGen = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomGen.Next(names.Length)];
            Color randomColor = Color.FromKnownColor(randomColorName);
            Skip_Btn.BackColor = randomColor;
        }
    }
}
