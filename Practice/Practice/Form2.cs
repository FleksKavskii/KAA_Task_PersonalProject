using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int balance = 100;
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int bet = 0;
            int numbers;
            numbers = comboBox1.SelectedIndex + 2;
            int firstDice = rnd.Next(1, 6);
            int secondDice = rnd.Next(1, 6);
            label7.Text = Convert.ToString(firstDice);
            label8.Text = Convert.ToString(secondDice);
            bet = Convert.ToInt32(textBox1.Text);
            if (radioButton2.Checked)
            {
                if (numbers < (firstDice + secondDice))
                    balance -= bet;
                else if (numbers > (firstDice + secondDice))
                    balance += bet;
                else if (numbers == (firstDice + secondDice))
                    balance += (bet * 4);
            }
            else if (radioButton1.Checked)
            {
                if (numbers > (firstDice + secondDice))
                    balance -= bet;
                else if (numbers < (firstDice + secondDice))
                    balance += bet;
                else if (numbers == (firstDice + secondDice))
                    balance += (bet * 4);
            }
            if (firstDice == 6)
            {
                string[,] FirstDice =
                      {
                    {" #","#","#","#","#","#"},
                    {" # ","","o","o","o"," #"},
                    {" # ","","o","o","o"," #"},
                    {" #","#","#","#","#","#"},
                   };
                for (int i = 0; i < FirstDice.GetLength(0); i++)
                {
                    textBox2.AppendText("\r");
                    textBox2.AppendText("\n");
                    for (int j = 0; j < FirstDice.GetLength(1); j++)
                    {
                        textBox2.AppendText("");
                        textBox2.AppendText(FirstDice[i, j]);

                    }
                }
            }
            if (firstDice == 1)
            {
                string[,] FirstDice =
                      {
                    {" #","#","#","#","#","#"},
                    {" # "," "," ","o","  "," #"},
                    {" # "," "," "," ","   "," #"},
                    {" #","#","#","#","#","#"},
                   };
                for (int i = 0; i < FirstDice.GetLength(0); i++)
                {
                    textBox2.AppendText("\r");
                    textBox2.AppendText("\n");
                    for (int j = 0; j < FirstDice.GetLength(1); j++)
                    {
                        textBox2.AppendText("");
                        textBox2.AppendText(FirstDice[i, j]);

                    }
                }
            }
            if (firstDice == 3)
            {
                string[,] FirstDice =
                      {
                    {" #","#","#","#","#","#"},
                    {" # ","o","o","o",""," #"},
                    {" # "," "," "," ","   "," #"},
                    {" #","#","#","#","#","#"},
                   };
                for (int i = 0; i < FirstDice.GetLength(0); i++)
                {
                    textBox2.AppendText("\r");
                    textBox2.AppendText("\n");
                    for (int j = 0; j < FirstDice.GetLength(1); j++)
                    {
                        textBox2.AppendText("");
                        textBox2.AppendText(FirstDice[i, j]);

                    }
                }
            }
            if (firstDice == 2)
            {
                string[,] FirstDice =
                      {
                    {" #","#","#","#","#","#"},
                    {" # "," ","o","o"," "," #"},
                    {" # "," "," "," ","   "," #"},
                    {" #","#","#","#","#","#"},
                   };
                for (int i = 0; i < FirstDice.GetLength(0); i++)
                {
                    textBox2.AppendText("\r");
                    textBox2.AppendText("\n");
                    for (int j = 0; j < FirstDice.GetLength(1); j++)
                    {
                        textBox2.AppendText("");
                        textBox2.AppendText(FirstDice[i, j]);

                    }
                }
            }
            if (firstDice == 4)
            {
                string[,] FirstDice =
                      {
                    {" #","#","#","#","#","#"},
                    {" # ","","","o"," o","  #"},
                    {" # ","","","o"," o","  #"},
                    {" #","#","#","#","#","#"},
                   };
                for (int i = 0; i < FirstDice.GetLength(0); i++)
                {
                    textBox2.AppendText("\r");
                    textBox2.AppendText("\n");
                    for (int j = 0; j < FirstDice.GetLength(1); j++)
                    {
                        textBox2.AppendText("");
                        textBox2.AppendText(FirstDice[i, j]);

                    }
                }
            }
            if (firstDice == 5)
            {
                string[,] FirstDice =
                      {
                    {" #","#","#","#","#","#"},
                    {" # ","","o","o","o"," #"},
                    {" # ","",""," o","o","  #"},
                    {" #","#","#","#","#","#"},
                   };
                for (int i = 0; i < FirstDice.GetLength(0); i++)
                {
                    textBox2.AppendText("\r");
                    textBox2.AppendText("\n");
                    for (int j = 0; j < FirstDice.GetLength(1); j++)
                    {
                        textBox2.AppendText("");
                        textBox2.AppendText(FirstDice[i, j]);

                    }
                }
            }
            if (secondDice == 6)
            {
                string[,] SecondDice =
                      {
                    {" #","#","#","#","#","#"},
                    {" # ","","o","o","o"," #"},
                    {" # ","","o","o","o"," #"},
                    {" #","#","#","#","#","#"},
                   };
                for (int i = 0; i < SecondDice.GetLength(0); i++)
                {
                    textBox3.AppendText("\r");
                    textBox3.AppendText("\n");
                    for (int j = 0; j < SecondDice.GetLength(1); j++)
                    {
                        textBox3.AppendText("");
                        textBox3.AppendText(SecondDice[i, j]);

                    }
                }
            }
            if (secondDice == 1)
            {
                string[,] SecondDice =
                      {
                    {" #","#","#","#","#","#"},
                    {" # "," "," ","o","  "," #"},
                    {" # "," "," "," ","   "," #"},
                    {" #","#","#","#","#","#"},
                   };
                for (int i = 0; i < SecondDice.GetLength(0); i++)
                {
                    textBox3.AppendText("\r");
                    textBox3.AppendText("\n");
                    for (int j = 0; j < SecondDice.GetLength(1); j++)
                    {
                        textBox3.AppendText("");
                        textBox3.AppendText(SecondDice[i, j]);

                    }
                }
            }
            if (secondDice == 3)
            {
                string[,] SecondDice =
                      {
                    {" #","#","#","#","#","#"},
                    {" # ","o","o","o",""," #"},
                    {" # "," "," "," ","   "," #"},
                    {" #","#","#","#","#","#"},
                   };
                for (int i = 0; i < SecondDice.GetLength(0); i++)
                {
                    textBox3.AppendText("\r");
                    textBox3.AppendText("\n");
                    for (int j = 0; j < SecondDice.GetLength(1); j++)
                    {
                        textBox3.AppendText(SecondDice[i, j]);

                    }
                }
            }
            if (secondDice == 2)
            {
                string[,] SecondDice =
                      {
                    {" #","#","#","#","#","#"},
                    {" # "," ","o","o"," "," #"},
                    {" # "," "," "," ","   "," #"},
                    {" #","#","#","#","#","#"},
                   };
                for (int i = 0; i < SecondDice.GetLength(0); i++)
                {
                    textBox3.AppendText("\r");
                    textBox3.AppendText("\n");
                    for (int j = 0; j < SecondDice.GetLength(1); j++)
                    {
                        textBox3.AppendText("");
                        textBox3.AppendText(SecondDice[i, j]);

                    }
                }
            }
            if (secondDice == 4)
            {
                string[,] SecondDice =
                      {
                    {" #","#","#","#","#","#"},
                    {" # ","","","o"," o","  #"},
                    {" # ","","","o"," o","  #"},
                    {" #","#","#","#","#","#"},
                   };
                for (int i = 0; i < SecondDice.GetLength(0); i++)
                {
                    textBox3.AppendText("\r");
                    textBox3.AppendText("\n");
                    for (int j = 0; j < SecondDice.GetLength(1); j++)
                    {
                        textBox3.AppendText("");
                        textBox3.AppendText(SecondDice[i, j]);

                    }
                }
            }
            if (secondDice == 5)
            {
                string[,] SecondDice =
                      {
                    {" #","#","#","#","#","#"},
                    {" # ","","o","o","o"," #"},
                    {" # ","",""," o","o","  #"},
                    {" #","#","#","#","#","#"},
                   };
                for (int i = 0; i < SecondDice.GetLength(0); i++)
                {
                    textBox3.AppendText("\r");
                    textBox3.AppendText("\n");
                    for (int j = 0; j < SecondDice.GetLength(1); j++)
                    {
                        textBox3.AppendText("");
                        textBox3.AppendText(SecondDice[i, j]);

                    }
                }
            }
            label4.Text = Convert.ToString(balance);
        }
    }
}
