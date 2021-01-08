using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGymvod2
{
    public partial class RazeniCisel : Form
    {
        public static int[] cisla;
        public RazeniCisel()
        {
            InitializeComponent();
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            cisla = Vstup.Text.Split(',').Select(s => int.Parse(s)).ToArray();


            for (int i = 0; i < cisla.Length; i++)
            {
                int temp;

                for (int deleni = 0; deleni < cisla.Length - 1; deleni++)
                {
                    if (cisla[deleni] > cisla[deleni + 1])
                    {
                        temp = cisla[deleni + 1];
                        cisla[deleni + 1] = cisla[deleni];
                        cisla[deleni] = temp;
                    }
                }
            }

            string[] cisla2 = cisla.Select(x => x.ToString()).ToArray();
            Vysledek.Text = string.Join(",", cisla2);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Vstup.Text = String.Empty;
            Vysledek.Text = String.Empty;
        }
    }
}
