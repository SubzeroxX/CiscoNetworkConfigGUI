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

namespace NetworkMaker
{
    public partial class Form1 : Form
    {
        // default mindig ha router n \n \n
        // default mindig ha switch \n
        public static List<string> Parancsok = new List<string>() { };
        public static string Eszkoznev;
        public static Point KonzolHely;
        public static List<Point> VégrehajtásiHelyek = new List<Point>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUj_Click(object sender, EventArgs e)
        {
            Uj ujForm = new Uj();
            ujForm.ShowDialog();
            try
            {
                lsbTeendok.Items.Add(Eszkoznev);
            }
            catch (Exception)
            {
            }
        }

        private void btnEltavolitas_Click(object sender, EventArgs e)
        {
            Parancsok.RemoveAt(lsbTeendok.SelectedIndex);
            lsbTeendok.Items.Remove(lsbTeendok.SelectedItem);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int Index = 0;
            foreach (var parancs in Parancsok)
            {
                Thread.Sleep(1500);
                SendKeys.SendWait(parancs);
                Thread.Sleep(100);
                lsbTeendok.Items[Index] += " - kész";

                System.Media.SystemSounds.Question.Play();
                DialogResult result = MessageBox.Show("Kész az adott eszköz\nKérlek nyomj \"OK\"-ot a folytatáshoz", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {

                }

                Thread.Sleep(6000);
                Index++;
            }
            MessageBox.Show("Összes feladat elkészült");
            System.Media.SystemSounds.Asterisk.Play();
        }

        private void btnKalibralas_Click(object sender, EventArgs e)
        {

        }
    }
}
