using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace KolkoKrzyzyk
{
    public partial class Form1 : Form
    {

        Button[,] Przycisk = new Button[3,3];
        string symbol;

        bool koniec = false;

        string current_starting = "O";

        int wynikO = 0;
        int wynikX = 0;
        int wynikTie = 0;

        bool singlePlayer = false;

        public Form1()
        {
            InitializeComponent();

            if(MessageBox.Show("Czy chcesz grać w trybie jednoosobowym?", "Wybór trybu gry", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                singlePlayer = true;
            }

            symbol = current_starting;

            label1.Text = "Grę zaczyna " + symbol;


            const int BUTTON_WIDTH = 45;
            const int BUTTON_HEIGHT = 45;
            int BUTTON_PAD_LEFT = (this.ClientSize.Width - (BUTTON_WIDTH*3)) / 2;
            int BUTTON_PAD_TOP = 60;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    this.Przycisk[i,j] = new Button();
                    this.Przycisk[i,j].Location = new System.Drawing.Point(
                        BUTTON_PAD_LEFT + (BUTTON_WIDTH * i), 
                        BUTTON_PAD_TOP + (BUTTON_HEIGHT * j)
                    );

                    this.Przycisk[i,j].Name = "Przycisk" + (i * 3 + j).ToString();
                    this.Przycisk[i,j].Size = new System.Drawing.Size(BUTTON_WIDTH, BUTTON_HEIGHT);
                    this.Przycisk[i,j].TabIndex = 2 + (i * 3 + j);
                    this.Przycisk[i,j].Text = "";
                    this.Przycisk[i,j].UseVisualStyleBackColor = true;

                    this.Przycisk[i,j].Click += new System.EventHandler(this.Przycisk_Click);
       
                    this.Controls.Add(Przycisk[i,j]);
                }
            }
        }


        private bool wygrana(string symbol)
        {
            
            if (Przycisk[0, 0].Text.Equals(symbol) && 
                Przycisk[0, 1].Text.Equals(symbol) && 
                Przycisk[0, 2].Text.Equals(symbol))
            {
                Przycisk[0, 0].BackColor = Color.LightGreen;
                Przycisk[0, 1].BackColor = Color.LightGreen;
                Przycisk[0, 2].BackColor = Color.LightGreen;
                return true;
            }

            if (Przycisk[1, 0].Text.Equals(symbol) && 
                Przycisk[1, 1].Text.Equals(symbol) && 
                Przycisk[1, 2].Text.Equals(symbol))
            {
                Przycisk[1, 0].BackColor = Color.LightGreen;
                Przycisk[1, 1].BackColor = Color.LightGreen;
                Przycisk[1, 2].BackColor = Color.LightGreen;
                return true;
            }

            if (Przycisk[2, 0].Text.Equals(symbol) && 
                Przycisk[2, 1].Text.Equals(symbol) && 
                Przycisk[2, 2].Text.Equals(symbol))
            {
                Przycisk[2, 0].BackColor = Color.LightGreen;
                Przycisk[2, 1].BackColor = Color.LightGreen;
                Przycisk[2, 2].BackColor = Color.LightGreen;
                return true;
            }


            if (Przycisk[0, 0].Text.Equals(symbol) && 
                Przycisk[1, 0].Text.Equals(symbol) && 
                Przycisk[2, 0].Text.Equals(symbol))
            {
                Przycisk[0, 0].BackColor = Color.LightGreen;
                Przycisk[1, 0].BackColor = Color.LightGreen;
                Przycisk[2, 0].BackColor = Color.LightGreen;
                return true;
            }

            if (Przycisk[0, 1].Text.Equals(symbol) && 
                Przycisk[1, 1].Text.Equals(symbol) && 
                Przycisk[2, 1].Text.Equals(symbol))
            {
                Przycisk[0, 1].BackColor = Color.LightGreen;
                Przycisk[1, 1].BackColor = Color.LightGreen;
                Przycisk[2, 1].BackColor = Color.LightGreen;
                return true;
            }

            if (Przycisk[0, 2].Text.Equals(symbol) && 
                Przycisk[1, 2].Text.Equals(symbol) && 
                Przycisk[2, 2].Text.Equals(symbol))
            {
                Przycisk[0, 2].BackColor = Color.LightGreen;
                Przycisk[1, 2].BackColor = Color.LightGreen;
                Przycisk[2, 2].BackColor = Color.LightGreen;
                return true;
            }

            if (Przycisk[0, 0].Text.Equals(symbol) && 
                Przycisk[1, 1].Text.Equals(symbol) && 
                Przycisk[2, 2].Text.Equals(symbol))
            {
                Przycisk[0, 0].BackColor = Color.LightGreen;
                Przycisk[1, 1].BackColor = Color.LightGreen;
                Przycisk[2, 2].BackColor = Color.LightGreen;
                return true;
            }

            if (Przycisk[0, 2].Text.Equals(symbol) && 
                Przycisk[1, 1].Text.Equals(symbol) && 
                Przycisk[2, 0].Text.Equals(symbol))
            {
                Przycisk[0, 2].BackColor = Color.LightGreen;
                Przycisk[1, 1].BackColor = Color.LightGreen;
                Przycisk[2, 0].BackColor = Color.LightGreen;
                return true;
            }

            return false;
        }

        private bool PelnaPlansza()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (string.IsNullOrEmpty(Przycisk[i, j].Text)) return false;
                }
            }
            return true;
        }
        
        private void ZerujPlansze()
        {
            koniec = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    this.Przycisk[i, j].Text = String.Empty;
                    this.Przycisk[i, j].BackColor = Color.White;

                }
            }
            current_starting = current_starting.Equals("O") ? "X" : "O";
            symbol = current_starting;
            label1.Text = "Ruch gracza "+symbol;
        }
        
        private void buttonKoniec_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Potwierdź wyjście", "Wyjść?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Przycisk_Click(object sender, EventArgs e)
        {
            if (koniec) return;

            if (string.IsNullOrEmpty(((Button)sender).Text))
            {
                ((Button)sender).Text = symbol;
            } else return;

            ((Button)sender).ForeColor = symbol.Equals("O") ? Color.Red : Color.Blue;

            if (wygrana(symbol))
            {
                label1.Text = "Wygral " + symbol;
                koniec = true;
                if (symbol.Equals("O"))
                {
                    wynikO++;
                    score_O.Text = wynikO.ToString();
                }
                else
                {
                    wynikX++;
                    score_X.Text = wynikX.ToString();
                }
            }
            else
            {
                if (PelnaPlansza())
                {
                    MessageBox.Show("Remis!");
                    label1.Text = "Remis";
                    wynikTie++;
                    score_Tie.Text = wynikTie.ToString();
                }
                else
                {
                    if (symbol.Equals("O")) symbol = "X";
                    else symbol = "O";
                    label1.Text = "Ruch gracza " + symbol;
                }
            }
            if (singlePlayer && !koniec && !symbol.Equals(current_starting))
            {
                Przycisk_Click(getRandomEmptyTile(), EventArgs.Empty);
            }
        }

        private Button getRandomEmptyTile()
        {
            Random rand = new Random();
            Button tile;
            do
            {
                int i = rand.Next(0, 3);
                int j = rand.Next(0, 3);
                tile = Przycisk[i, j];
            } while (!string.IsNullOrEmpty(tile.Text));
            return tile;
        }
        
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ZerujPlansze();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void zeruj_Click(object sender, EventArgs e)
        {
            wynikO = 0;
            wynikX = 0;
            wynikTie = 0;

            score_O.Text = wynikO.ToString();
            score_X.Text = wynikX.ToString();
            score_Tie.Text = wynikTie.ToString();
        }
    }
}
