using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grid3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Value, minValue = 100, maxValue = 0;

            Random rnd = new Random();

            if (int.TryParse(SizeTB.Text, out int n) && n >= 1)
            {
                dataGridView1.Visible = true;

                dataGridView1.ColumnCount = dataGridView1.RowCount = n;
                for (int i = 0; i < n; i++)
                    for (int k = 0; k < n; k++)
                    {
                        Value = rnd.Next(0, 99);
                        dataGridView1[i, k].Value = Value;

                        if (maxValue < Value) maxValue = Value;
                        if (minValue > Value) minValue = Value;
                    }
                label2.Text = "Разница - " + (maxValue - minValue);
            }
            else MessageBox.Show("Ошибка входных данных");
        }
    }
}
