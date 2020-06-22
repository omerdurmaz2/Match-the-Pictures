using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resim_Eslestirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string[] dizi = { "A", "A", "B", "B", "C", "C", "D", "D", "E", "E", "F", "F", "G", "G", "H", "H" };
        static bool dgr1 = false;
        static string deger1 = "", deger2 = "";
        static string buton1 = "", buton2 = "";

        List<Bitmap> listimage = new List<Bitmap>();

        int ciftsayac = 0;
        int oys = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            dizi = karistir(dizi);
            dizi = karistir(dizi);
            dizi = karistir(dizi);
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            DialogResult cvp = MessageBox.Show("Başla", "Yeni Oyun", MessageBoxButtons.OK);
            if (cvp == DialogResult.OK)
            {
                oyunsuresi.Start();
            }
            else
            {
                Close();
            }
        }
        public static string[] karistir(string[] dizi)
        {
            int n = dizi.Length;
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                string gecici = dizi[i];
                int s = r.Next(n - 1);
                dizi[i] = dizi[s];
                dizi[s] = gecici;
            }
            return dizi;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            Ac("1");
            btn1.Enabled = false;
            Bak(0);
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            Ac("2");
            btn2.Enabled = false;
            Bak(1);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Ac("3");
            btn3.Enabled = false;
            Bak(2);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Ac("4");
            btn4.Enabled = false;
            Bak(3);

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Ac("5");
            btn5.Enabled = false;
            Bak(4);

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Ac("6");
            btn6.Enabled = false;
            Bak(5);

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Ac("7");
            btn7.Enabled = false;
            Bak(6);

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Ac("8");
            btn8.Enabled = false;
            Bak(7);

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Ac("9");
            btn9.Enabled = false;
            Bak(8);

        }

        private void btn10_Click(object sender, EventArgs e)
        {
            Ac("10");
            btn10.Enabled = false;
            Bak(9);

        }

        private void btn11_Click(object sender, EventArgs e)
        {
            Ac("11");
            btn11.Enabled = false;
            Bak(10);

        }

        private void btn12_Click(object sender, EventArgs e)
        {
            Ac("12");
            btn12.Enabled = false;
            Bak(11);

        }

        private void btn13_Click(object sender, EventArgs e)
        {
            Ac("13");
            btn13.Enabled = false;
            Bak(12);

        }

        private void btn14_Click(object sender, EventArgs e)
        {
            Ac("14");
            btn14.Enabled = false;
            Bak(13);

        }

        private void btn15_Click(object sender, EventArgs e)
        {
            Ac("15");
            btn15.Enabled = false;
            Bak(14);

        }

        private void btn16_Click(object sender, EventArgs e)
        {
            Ac("16");
            btn16.Enabled = false;
            Bak(15);

        }
        public void Ac(string buton)
        {
            switch (buton)
            {
                case "1":
                    btn1.Text = dizi[0];
                    break;
                case "2":
                    btn2.Text = dizi[1];
                    break;
                case "3":
                    btn3.Text = dizi[2];
                    break;
                case "4":
                    btn4.Text = dizi[3];
                    break;
                case "5":
                    btn5.Text = dizi[4];
                    break;
                case "6":
                    btn6.Text = dizi[5];
                    break;
                case "7":
                    btn7.Text = dizi[6];
                    break;
                case "8":
                    btn8.Text = dizi[7];
                    break;
                case "9":
                    btn9.Text = dizi[8];
                    break;
                case "10":
                    btn10.Text = dizi[9];
                    break;
                case "11":
                    btn11.Text = dizi[10];
                    break;
                case "12":
                    btn12.Text = dizi[11];
                    break;
                case "13":
                    btn13.Text = dizi[12];
                    break;
                case "14":
                    btn14.Text = dizi[13];
                    break;
                case "15":
                    btn15.Text = dizi[14];
                    break;
                case "16":
                    btn16.Text = dizi[15];
                    break;
            }
        }

        public void Bak(int yer)
        {
            if (dgr1 == false)
            {
                dgr1 = true;
                deger1 = dizi[yer];
                buton1 = (yer + 1).ToString();

            }
            else
            {
                deger2 = dizi[yer];
                buton2 = (yer + 1).ToString();
                if (deger1 == deger2)
                {
                    ciftsayac++;
                    if (ciftsayac == 8)
                    {
                        oyunsuresi.Stop();
                        DialogResult cvp = MessageBox.Show("Oyunu " + oys + " saniyede tamamladınız! \nYeni Oyun Oynamak İster misiniz?", "Tebrikler!!", MessageBoxButtons.YesNo);
                        if (cvp==DialogResult.Yes)
                        {
                            Application.Restart();
                            Environment.Exit(0);
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    Temizle();
                }
                else
                {
                    gsure.Start();
                }
            }
        }




        public static void Temizle()
        {
            dgr1 = false;
            buton1 = "";
            buton2 = "";
            deger1 = "";
            deger2 = "";
        }

        private void oyunsuresi_Tick(object sender, EventArgs e)
        {
            oys++;
        }

        private void gsure_Tick(object sender, EventArgs e)
        {
            Kapa_ve_Enabled(buton1);
            Kapa_ve_Enabled(buton2);
            Temizle();

            gsure.Stop();

        }
        public void Kapa_ve_Enabled(string buton)
        {
            switch (buton)
            {
                case "1":
                    btn1.Text = "";
                    btn1.Enabled = true;
                    break;
                case "2":
                    btn2.Text = "";
                    btn2.Enabled = true;
                    break;
                case "3":
                    btn3.Text = "";
                    btn3.Enabled = true;
                    break;
                case "4":
                    btn4.Text = "";
                    btn4.Enabled = true;
                    break;
                case "5":
                    btn5.Text = "";
                    btn5.Enabled = true;
                    break;
                case "6":
                    btn6.Text = "";
                    btn6.Enabled = true;
                    break;
                case "7":
                    btn7.Text = "";
                    btn7.Enabled = true;
                    break;
                case "8":
                    btn8.Text = "";
                    btn8.Enabled = true;
                    break;
                case "9":
                    btn9.Text = "";
                    btn9.Enabled = true;
                    break;
                case "10":
                    btn10.Text = "";
                    btn10.Enabled = true;
                    break;
                case "11":
                    btn11.Text = "";
                    btn11.Enabled = true;
                    break;
                case "12":
                    btn12.Text = "";
                    btn12.Enabled = true;
                    break;
                case "13":
                    btn13.Text = "";
                    btn13.Enabled = true;
                    break;
                case "14":
                    btn14.Text = "";
                    btn14.Enabled = true;
                    break;
                case "15":
                    btn15.Text = "";
                    btn15.Enabled = true;
                    break;
                case "16":
                    btn16.Text = "";
                    btn16.Enabled = true;
                    break;

            }
        }
    }
}
