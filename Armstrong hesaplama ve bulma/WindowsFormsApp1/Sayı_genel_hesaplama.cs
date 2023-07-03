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
    public partial class Sayı_genel_hesaplama : Form
    {
        public Sayı_genel_hesaplama()
        {
            InitializeComponent();
        }

        private void lb_genel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Sayı_genel_hesaplama_Load(object sender, EventArgs e)
        {
            int birler, onlar, yuzler, sayi;
            double kup;
                for (int i = 100; i < 1000; i++)
                {

                    sayi = i;
                    if (sayi > 99 && sayi < 1000)
                    {
                        yuzler = sayi / 100 % 10;
                        onlar = sayi / 10 % 10;
                        birler = sayi / 1 % 10;

                        kup = Math.Pow(yuzler,3) + Math.Pow(onlar,3) + Math.Pow(birler,3);


                        lb_genel.Items.Add("- " + i + " -");
                        lb_genel.Items.Add("Yüzler basamağı " + yuzler);
                        lb_genel.Items.Add("Onlar basamağı " + onlar);
                        lb_genel.Items.Add("Birler basamağı " + birler);
                        lb_genel.Items.Add(Math.Pow(yuzler,3)+ " + " +Math.Pow(onlar,3)+ " + " + Math.Pow(birler,3) + " =" + kup);

                        if (sayi == kup)
                        {
                            lb_genel.Items.Add(i);
                            lb_genel.Items.Add("Armstrong Sayıdır.");
                            lb_genel.Items.Add("-------------------");
                        }
                        else
                        {

                            lb_genel.Items.Add("Armstrong Sayı Değildir.");
                            lb_genel.Items.Add("-------------------------");
                        }

                        if (kup == sayi)
                        {

                            lb_bulunan.Items.Add(sayi);
                            lb_bulunan.Items.Add("----");
                        }

                        {

                        }

                    }
                }

            }

        private void button3_Click(object sender, EventArgs e)
        {
         this.Close();   
        }

        bool move;
        int move_x;
        int move_y;

        private void Sayı_genel_hesaplama_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - move_x, MousePosition.Y - move_y);
            }
        }

        private void Sayı_genel_hesaplama_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            move_x = e.X; 
            move_y = e.Y;
        }

        private void Sayı_genel_hesaplama_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }
    

