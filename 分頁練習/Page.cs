using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 分頁練習
{
    internal class Page
    {
        public IEnumerable<Label> CreateLabels()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<Label> pages = numbers.Select((x, index) =>
            {
                Debug.WriteLine(index);
                Label label = new Label() { Text = x.ToString() };
                //label.BackColor = Color.Black;
                //label.Click += PageNumber_Click;
                return label;
            });

            //foreach (Label label in pages)
            //{
            //    label.BackColor = Color.Black;
            //    label.Click += PageNumber_Click;
            //}

            return pages;
        }

        private void PageNumber_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            MessageBox.Show(label.Text);
        }
    }
}
