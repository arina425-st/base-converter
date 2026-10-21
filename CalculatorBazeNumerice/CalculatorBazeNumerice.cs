using System.Data.Common;

namespace CalculatorBazeNumerice
{
    public partial class CalculatorBazeNumerice : Form
    {
        Button[] btn = new Button[100];

        public CalculatorBazeNumerice()
        {
            InitializeComponent();
            BaseTenBtn.Checked = true;

            // Add dynamic buttons from 2 to 9

            int column = 1;
            int line = 1;

            for (int i = 2; i <= 9; i++)
            {
                if (line == 1)
                {
                    btn[i] = new Button();
                    btn[i].Location = new Point(110 + 84 * (column - 1), 100 + 81 * (line - 1));
                    btn[i].Size = new Size(78, 75);
                    btn[i].Text = i.ToString();
                    Controls.Add(btn[i]);
                    if (column == 2)
                    {
                        line++;
                        column = 0;
                    }
                    column++;
                }
                else
                {
                    btn[i] = new Button();
                    btn[i].Location = new Point(26 + 84 * (column - 1), 100 + 81 * (line - 1));
                    btn[i].Size = new Size(78, 75);
                    btn[i].Text = i.ToString();
                    Controls.Add(btn[i]);
                    if (column % 3 == 0)
                    {
                        line++;
                        column = 0;
                    }
                    column++;
                }
            }

            btn[2].Click += new EventHandler(TwoBtn_Click);
            btn[3].Click += new EventHandler(ThreeBtn_Click);
            btn[4].Click += new EventHandler(FourBtn_Click);
            btn[5].Click += new EventHandler(FiveBtn_Click);
            btn[6].Click += new EventHandler(SixBtn_Click);
            btn[7].Click += new EventHandler(SevenBtn_Click);
            btn[8].Click += new EventHandler(EightBtn_Click);
            btn[9].Click += new EventHandler(NineBtn_Click);
        }

        int rez;

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "0";
            }
            else
            {
                ResultBox.Text += "0";
            }
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "1";
            }
            else
            {
                ResultBox.Text += "1";
            }
        }
        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "2";
            }
            else
            {
                ResultBox.Text += "2";
            }
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "3";
            }
            else
            {
                ResultBox.Text += "3";
            }
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "4";
            }
            else
            {
                ResultBox.Text += "4";
            }
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "5";
            }
            else
            {
                ResultBox.Text += "5";
            }
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "6";
            }
            else
            {
                ResultBox.Text += "6";
            }
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "7";
            }
            else
            {
                ResultBox.Text += "7";
            }
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "8";
            }
            else
            {
                ResultBox.Text += "8";
            }
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "9";
            }
            else
            {
                ResultBox.Text += "9";
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            ResultBox.Text = ResultBox.Text.Remove(ResultBox.Text.Length - 1);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "0";
        }
        private void BaseTenBtn_CheckedChanged(object sender, EventArgs e)
        {

            if (ResultBox.Text == "0")
            {
                return;
            }
            if (unit.baza_curenta == 10)
            {
                return;
            }
            if (unit.baza_curenta == 2)
            {
                // Conversion from base 2 to base 10

                // Add dynamic buttons from 2 to 9

                int column = 1;
                int line = 1;

                for (int i = 2; i <= 9; i++)
                {
                    if(line  == 1)
                    {
                        btn[i] = new Button();
                        btn[i].Location = new Point(110 + 84 * (column - 1), 100 + 81 * (line - 1));
                        btn[i].Size = new Size(78, 75);
                        btn[i].Text = i.ToString();
                        Controls.Add(btn[i]);
                        if (column == 2)
                        {
                            line++;
                            column = 0;
                        }
                        column++;
                    }
                    else
                    {
                        btn[i] = new Button();
                        btn[i].Location = new Point(26 + 84 * (column - 1), 100 + 81 * (line - 1));
                        btn[i].Size = new Size(78, 75);
                        btn[i].Text = i.ToString();
                        Controls.Add(btn[i]);
                        if (column % 3 == 0)
                        {
                            line++;
                            column = 0;
                        }
                        column++;
                    }
                }

                btn[2].Click += new EventHandler(TwoBtn_Click);
                btn[3].Click += new EventHandler(ThreeBtn_Click);
                btn[4].Click += new EventHandler(FourBtn_Click);
                btn[5].Click += new EventHandler(FiveBtn_Click);
                btn[6].Click += new EventHandler(SixBtn_Click);
                btn[7].Click += new EventHandler(SevenBtn_Click);
                btn[8].Click += new EventHandler(EightBtn_Click);
                btn[9].Click += new EventHandler(NineBtn_Click);

                rez = 0;
                for (int i = 0; i < ResultBox.Text.Length; i++)
                {
                    rez = rez * 2 + ResultBox.Text[i] - '0';
                }
                ResultBox.Text = Convert.ToString(rez);
            }
            else
            {
                // Conversion from base 16 to base 10

                // Remove buttons from A to F

                for (char c = 'A'; c <= 'F'; c++)
                {
                    Controls.Remove(btn[(int)(c)]);
                }

                string hexValue = Convert.ToString(ResultBox.Text);
                rez = Convert.ToInt32(hexValue, 16);
                ResultBox.Text = Convert.ToString(rez);
            }
            
            unit.baza_curenta = 10;
        }
        private void BaseTwoBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "0";
            }
            if (unit.baza_curenta == 2)
            {
                return;
            }
            if (unit.baza_curenta == 10)
            {
                // Conversion from base 10 to base 2

                // Remove buttons from 2 to 9

                for (int i = 2; i <= 9; i++)
                {
                    Controls.Remove(btn[i]);
                }

                rez = Convert.ToInt32(ResultBox.Text);
                ResultBox.Text = "";
                while (rez > 0)
                {
                    ResultBox.Text = (char)(rez % 2 + 48) + ResultBox.Text;
                    rez = rez / 2;
                }
            }
            else
            {
                // Conversion from base 16 to base 2

                // Remove buttons from 2 to 9

                for (int i = 2; i <= 9; i++)
                {
                    Controls.Remove(btn[i]);
                }

                // Remove buttons from A to F

                for (char c = 'A'; c <= 'F'; c++)
                {
                    Controls.Remove(btn[(int)(c)]);
                }

                // Fisrtly, conversion from base 16 to base 10

                string hexValue = Convert.ToString(ResultBox.Text);
                rez = Convert.ToInt32(hexValue, 16);

                //Secondly, conversion from base 10 to base 2

                ResultBox.Text = "";
                while (rez > 0)
                {
                    ResultBox.Text = (char)(rez % 2 + 48) + ResultBox.Text;
                    rez = rez / 2;
                }
            }

            unit.baza_curenta = 2;

        }

        private void BaseSixteenBtn_CheckedChanged(object sender, EventArgs e)
        {

            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "0";
            }
            if (unit.baza_curenta == 16)
            {
                return;
            }
            if (unit.baza_curenta == 10)
            {
                // Conversion from base 10 to base 16

                // Add dynamic buttons from A to F

                for (char c = 'A'; c <= 'F'; c++)
                {
                    btn[(int)(c)] = new Button();
                    btn[(int)(c)].Location = new Point(194 + 84 * ((int)(c) - 1), 100 + 81 * ((int)(c) - 1));
                    btn[(int)(c)].Size = new Size(78, 75);
                    btn[(int)(c)].Text = c.ToString();
                    Controls.Add(btn[(int)(c)]);

                }

                rez = Convert.ToInt32(ResultBox.Text);
                ResultBox.Text = rez.ToString("X");
            }
            else
            {
                // Conversion from base 2 to base 16

                // Add dynamic buttons from 2 to 9

                int column = 1;
                int line = 1;

                for (int i = 2; i <= 9; i++)
                {
                    if (line == 1)
                    {
                        btn[i] = new Button();
                        btn[i].Location = new Point(110 + 84 * (column - 1), 100 + 81 * (line - 1));
                        btn[i].Size = new Size(78, 75);
                        btn[i].Text = i.ToString();
                        Controls.Add(btn[i]);
                        if (column == 2)
                        {
                            line++;
                            column = 0;
                        }
                        column++;
                    }
                    else
                    {
                        btn[i] = new Button();
                        btn[i].Location = new Point(26 + 84 * (column - 1), 100 + 81 * (line - 1));
                        btn[i].Size = new Size(78, 75);
                        btn[i].Text = i.ToString();
                        Controls.Add(btn[i]);
                        if (column % 3 == 0)
                        {
                            line++;
                            column = 0;
                        }
                        column++;
                    }
                }

                btn[2].Click += new EventHandler(TwoBtn_Click);
                btn[3].Click += new EventHandler(ThreeBtn_Click);
                btn[4].Click += new EventHandler(FourBtn_Click);
                btn[5].Click += new EventHandler(FiveBtn_Click);
                btn[6].Click += new EventHandler(SixBtn_Click);
                btn[7].Click += new EventHandler(SevenBtn_Click);
                btn[8].Click += new EventHandler(EightBtn_Click);
                btn[9].Click += new EventHandler(NineBtn_Click);

                // Add dynamic buttons from A to F

                column = 1;
                line = 1;

                for (char c = 'A'; c <= 'F'; c++)
                {
                    btn[(int)(c)] = new Button();
                    btn[(int)(c)].Location = new Point(279 + 84 * (column - 1), 100 + 81 * (line - 1));
                    btn[(int)(c)].Size = new Size(78, 75);
                    btn[(int)(c)].Text = c.ToString();
                    Controls.Add(btn[(int)(c)]);
                    if (column % 3 == 0)
                    {
                        line++;
                        column = 0;
                    }
                    column++;
                }

                btn[(int)('A')].Click += new EventHandler(A_Btn_Click);
                btn[(int)('B')].Click += new EventHandler(B_Btn_Click);
                btn[(int)('C')].Click += new EventHandler(C_Btn_Click);
                btn[(int)('D')].Click += new EventHandler(D_Btn_Click);
                btn[(int)('E')].Click += new EventHandler(E_Btn_Click);
                btn[(int)('F')].Click += new EventHandler(F_Btn_Click);

                // Firstly, conversion from base 2 to base 10

                rez = 0;
                for (int i = 0; i < ResultBox.Text.Length; i++)
                {
                    rez = rez * 2 + ResultBox.Text[i] - '0';
                }

                // Secondly, conversion from base 10 to base 16

                ResultBox.Text = rez.ToString("X");
            }

            unit.baza_curenta = 16;
        }

        private void A_Btn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "A";
            }
            else
            {
                ResultBox.Text += "A";
            }
        }

        private void B_Btn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "B";
            }
            else
            {
                ResultBox.Text += "B";
            }
        }

        private void C_Btn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "C";
            }
            else
            {
                ResultBox.Text += "C";
            }
        }

        private void D_Btn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "D";
            }
            else
            {
                ResultBox.Text += "D";
            }
        }

        private void E_Btn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "E";
            }
            else
            {
                ResultBox.Text += "E";
            }
        }

        private void F_Btn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "F";
            }
            else
            {
                ResultBox.Text += "F";
            }
        }
    }
    class unit
    {
        public static int baza_curenta;
    }
}
