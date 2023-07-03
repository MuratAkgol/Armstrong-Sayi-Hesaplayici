using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int birler, onlar, yuzler, sayi;
            double kup;

            sayi = Convert.ToInt32(textBox1.Text);
            if (sayi < 0)
            {
                MessageBox.Show("Lütfen 3 basamaklı pozitif bir sayı giriniz.");
            }
            
            else if (sayi > 99)
            {

                yuzler = sayi / 100 % 10;
                onlar = sayi / 10 % 10;
                birler = sayi / 1 % 10;

                kup = Math.Pow(yuzler, 3) + Math.Pow(onlar, 3) + Math.Pow(birler, 3);

                if (sayi == kup)
                {
                    textBox2.Text = sayi + " Armstrong sayıdır.";

                }
                else
                {
                    textBox2.Text = sayi + " Armstrong sayı değildir.";
                }
            }
            else
            {
                MessageBox.Show("Lütfen 3 basamaklı bir sayı giriniz");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        bool move;
        int mouse_x;
        int mouse_y;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move=false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
           
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            
            Sayı_genel_hesaplama sgh = new Sayı_genel_hesaplama();
            sgh.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
