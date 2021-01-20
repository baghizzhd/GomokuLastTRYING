using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GomokuLastTRYING
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public Button[,] tombol = new Button[15, 15];
        public string nama;
        bool x = true; 


        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;
            for (int i = 0; i < 15; i++)
            {
                for (int j=0; j<15;j++)
                {
                   
                    tombol[i, j] = new Button();
                    tombol[i, j].BringToFront();
                    nama = i.ToString() + j.ToString();
                    tombol[i, j].Name = nama;
                    tombol[i, j].Size = new Size(20, 20);
                    tombol[i, j].Location = new Point(26+(i*20),105+(j*20));
                    tombol[i, j].BackColor = Color.Transparent;
                    this.Controls.Add(tombol[i, j]);
                    tombol[i, j].Click += new EventHandler(pencet_click);
                   



                }
            }
        }
        public int sumbux;
        public int sumbuy;
        public int player = 0;
        public int count = 0;
        PictureBox px;
        private void pencet_click(object sender, EventArgs e)
        {
            var x = sender as Button;;
            sumbux = Convert.ToInt32(Convert.ToString(x.Name.Substring(0, 1)));
            sumbuy = Convert.ToInt32(Convert.ToString(x.Name.Substring(1, 1)));

            if (player == 0)
            {
                px.Image = Image.FromFile(@"C:\Users\Asus\source\repos\GomokuLastTRYING\GomokuLastTRYING\Resources\pngegg.png");
                player = 1;
            }
            else if (player == 1)
            {
               tombol[sumbux, sumbuy].BackColor = Color.Blue;
                player = 0;
            }
            px.Enabled = false;

        }

    
    }
}

