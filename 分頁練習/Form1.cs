using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 分頁練習
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Page page = new Page();
            IEnumerable<Label> pages = page.CreateLabels();
            foreach (Label page2 in pages)
            {
                flowLayoutPanel1.Controls.Add(page2);
            }
        }
    }
}
