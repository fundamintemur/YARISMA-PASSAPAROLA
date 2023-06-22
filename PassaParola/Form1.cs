using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaParola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int sorunno = 0, dogru = 0, yanlıs = 0;
        string cevap;
        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //string cevap = textBox1.Text;
            //switch (cevap)
            //{
            //    case "AKDENİZ": button1.BackColor = Color.Green;break;
            //    case "BURSA": button2.BackColor = Color.Green; break;
            //    default:break;

            //}

            if (e.KeyCode == Keys.Enter)
            {
                switch (sorunno)
                {
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlıs++;
                            label4.Text = yanlıs.ToString();
                        }
                        break;

                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlıs++;
                            label4.Text = yanlıs.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();


                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlıs++;
                            label4.Text = yanlıs.ToString();
                        }
                        break;

                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlıs++;
                            label4.Text = yanlıs.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlıs++;
                            label4.Text = yanlıs.ToString();
                        }
                        break;

                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlıs++;
                            label4.Text = yanlıs.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlıs++;
                            label4.Text = yanlıs.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "halı")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlıs++;
                            label4.Text = yanlıs.ToString();
                        }
                        break;
                }
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "SONRAKİ";
           
            sorunno++;
            this.Text = sorunno.ToString();
          
            if (sorunno == 1)
            {
                
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi ?";
                button1.BackColor = Color.Yellow;
                
               


            }
            if (sorunno == 2)
            {
                richTextBox1.Text = "Yeşilliğiyle ünlü marmara ilimiz";
                button2.BackColor = Color.Yellow;
            }
            if (sorunno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü";
                button3.BackColor = Color.Yellow; 
            }

            if (sorunno == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü  ilimiz ?";
                button4.BackColor = Color.Yellow;

            }
            if (sorunno ==5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı?";
                button5.BackColor = Color.Yellow;
            }
            if (sorunno ==6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
                button6.BackColor = Color.Yellow;
            }
            if (sorunno ==7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı?";
                button7.BackColor = Color.Yellow;
            }
            if (sorunno ==8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne getirdiğinde bakıştığı nesne?";
                button8.BackColor = Color.Yellow;
            }
            if (sorunno ==9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz?";
                button9.BackColor = Color.Yellow;
            }
            if (sorunno ==10)
            {
                richTextBox1.Text = "Mersinin diğer ismi?";
                button10.BackColor = Color.Yellow;
            }

            if (sorunno == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk?";
                button11.BackColor = Color.Yellow;
            }
            if (sorunno == 12)
            {
                richTextBox1.Text = "Malatyanın meşhur  meyvesi?";
                button12.BackColor = Color.Yellow;
            }
            if (sorunno == 13)
            {
                richTextBox1.Text = "Heryıl bahar aylarında düzenlenen çiçek festivali?";
                button13.BackColor = Color.Yellow;
            }
            if (sorunno == 14)
            {
                richTextBox1.Text = "Yılın 3.ayı?";
                button14.BackColor = Color.Yellow;
            }
            if (sorunno == 15)
            {
                richTextBox1.Text = "Üflemeli bir müzik aleti?";
                button15.BackColor = Color.Yellow;
            }
            if (sorunno == 16)
            {
                richTextBox1.Text = "Halk şairi?";
                button16.BackColor = Color.Yellow;
            }
            if (sorunno == 17)
            {
                richTextBox1.Text = "Çocukların çok sevmediği pirinç,havuç gibi sebzelerle yapılan yemek?";
                button17.BackColor = Color.Yellow;
            }

            if (sorunno == 18)
            {
                richTextBox1.Text = "11. ayın sultanı?";
                button18.BackColor = Color.Yellow;
            }
            if (sorunno ==19)
            {
                richTextBox1.Text = "İngilizcede yılan?";
                button19.BackColor = Color.Yellow;
            }
            if (sorunno ==20)
            {
                richTextBox1.Text = "Türkiyenin mega starı?";
                button20.BackColor = Color.Yellow;
            }
            if (sorunno ==21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı?";
                button21.BackColor = Color.Yellow;
            }

            if (sorunno ==22)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz?";
                button22.BackColor = Color.Yellow;
            }
            if (sorunno == 23)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı?";
                button23.BackColor = Color.Yellow;
            }
            if (sorunno == 24)
            {
                richTextBox1.Text = "Ege bölgesinin en çok ağacı bulunan yağı da yapılan bir kahvaltı besini?";
                button24.BackColor = Color.Yellow;
            }
        }
    }
}
