using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _210601011_sena_ödev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            notifyIcon1.ShowBalloonTip(2000, "Programa Hoş Geldiniz", "Nesne Yönelimli Programlama Ödev 1", ToolTipIcon.Info);
        }
        private Boolean Dogrula(int başlangıç, int bitiş)
        {
            return (bitiş > başlangıç) ? true : false;

        }
        private bool AsalSayiKontrol(int sayi)
        {
            int sayaç = 0;
            for (int j = 2; j < sayi; j++)
            {
                if (sayi % j == 0)
                {
                    sayaç++;
                    break;
                }
            }
            if (sayaç == 0)
                return true;
            else
                return false;
        }
        private bool MukemmelSayiKontrol(int sayi)
        {
            int toplam = 0;
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    toplam = toplam + i;
                }
            }
            if (toplam == sayi)

                return true;
            else
                return false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int başlangıç = Convert.ToInt32(txtBaşlangıç.Text);
            int bitiş = Convert.ToInt32(txtBitiş.Text);
            if (Dogrula(başlangıç, bitiş))
            {


                int tekToplam = 0, çiftToplam = 0;
                int tekÇarpım = 1, çiftÇarpım = 1;

                for (int i = başlangıç; i <= bitiş; i++)
                {
                    if ((i % 2) == 0)
                    {

                        listView2.Items.Add(i.ToString());
                    }



                    else

                    {

                        listView1.Items.Add(i.ToString());
                    }



                }
                for (int i = başlangıç; i <= bitiş; i++)
                {
                    if ((i % 2) == 0)

                        çiftToplam += i;

                    else

                        tekToplam += i;
                }

                listBox1.Items.Add(tekToplam);
                listBox2.Items.Add(çiftToplam);

                for (int i = başlangıç; i <= bitiş; i++)
                {
                    if ((i % 2) == 0)

                        çiftÇarpım *= i;

                    else


                        tekÇarpım *= i;

                }

                listBox3.Items.Add(tekÇarpım);
                listBox4.Items.Add(çiftÇarpım);

                int asalToplam = 0;
                int asalÇarpım = 1;
                for (int i = 2; i <= bitiş; i++)
                {
                    if (AsalSayiKontrol(i))
                    {
                        listView3.Items.Add(i.ToString());
                    }
                }

                for (int i = başlangıç; i <= bitiş; i++)
                {
                    if (AsalSayiKontrol(i))
                    {
                        asalToplam += i;
                    }
                }

                for (int i = başlangıç; i <= bitiş; i++)
                {
                    if (AsalSayiKontrol(i))
                    {
                        asalÇarpım *= i;
                    }
                }

                listBox5.Items.Add(asalToplam);
                listBox6.Items.Add(asalÇarpım);


                int mükemmelToplam = 0;
                int mükemmelÇarpım = 1;
                for (int i = başlangıç; i <= bitiş; i++)
                {
                    if (MukemmelSayiKontrol(i))
                    {
                        listView4.Items.Add(i.ToString());
                    }
                }
                for (int i = başlangıç; i <= bitiş; i++)
                {
                    if (MukemmelSayiKontrol(i))
                    {
                        mükemmelToplam += i;
                    }
                }
                for (int i = başlangıç; i <= bitiş; i++)
                {
                    if (MukemmelSayiKontrol(i))
                    {
                        mükemmelÇarpım *= i;
                    }
                }
                listBox7.Items.Add(mükemmelToplam);
                listBox8.Items.Add(mükemmelÇarpım);
                txtBaşlangıç.Clear();
                txtBitiş.Clear();
                txtBaşlangıç.Clear();
                txtBitiş.Clear();
            }


            else
            {
                MessageBox.Show("Hata!");
            }
        }
    }
}
