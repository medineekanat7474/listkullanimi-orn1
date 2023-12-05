using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listkullanimi_orn1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> ogrenciliste = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenciliste.RemoveAt(0);
            
            listBox1.DataSource= ogrenciliste.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int elemansayisi = ogrenciliste.Count;

            ogrenciliste.RemoveAt(elemansayisi-1);

            listBox1.DataSource= ogrenciliste.ToList();
        }
    }
}
