using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();

        }

        private void GenerateButtons()
        {
            // [8,8] büyüklüğünde 2 Boyutlu bir dizi oluşturuldu.
            Button[,] buttons = new Button[8, 8];
            int top = 0;
            int left = 0;

            for (int i = 0; i <= buttons.GetUpperBound(0); i++)//iç içe iki döngüyle her bir elemana erişim sağlandı.
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();//nesne oluşturuldu ve özellikleri tanımlandı.
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50;

                    if ((i + j) % 2 == 0)// Hangi butonun siyah olması gerektiğine karar verildi.
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);//forma buton eklendi.
                }
                left = 0;
                top += 50;

            }
        }
    }
}
