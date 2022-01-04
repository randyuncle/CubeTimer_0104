using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            scramble.Text = sc.Generate();
            scramble.Location = new Point((Width - scramble.Width) / 2, 50);
            L_time.Location = new Point((Width - L_time.Width) / 2, (Height - L_time.Height) / 2 - 75);
            //有關location的東西純粹是為了調整成績的位置

            //RY 1228
            History.Text = "History\n";
            AverageLabel.Text = "0:0.00";
            BestLabel.Text = "0:0.00";
            WorstLabel.Text = "0:0.00";
            //RY 1228
        }

        bool timing = false;
        private DateTime startTime;
        Scramble sc = new Scramble();
        public Button[,] B_orange = new Button[3, 3];
        public Button[,] B_green = new Button[3, 3];
        public Button[,] B_red = new Button[3, 3];
        public Button[,] B_blue = new Button[3, 3];
        public Button[,] B_white = new Button[3, 3];
        public Button[,] B_yellow = new Button[3, 3];

        //RY 1228
        public double [] grade = new double[500];
        public int index = 0;
        public double sum = 0.0;
        public double average = 0.0;
        public double best = 0.0;
        public double worst = 0.0;
        //RY 1228

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    B_orange[i, j] = new Button();
                    B_orange[i, j].SetBounds(370 + j * 30, 530 + i * 30, 30, 30);
                    B_orange[i, j].BackColor = Color.Orange;
                    B_orange[i, j].Enabled = false;
                    Controls.Add(B_orange[i, j]);

                    B_green[i, j] = new Button();
                    B_green[i, j].SetBounds(480 + j * 30, 530 + i * 30, 30, 30);
                    B_green[i, j].BackColor = Color.Green;
                    B_green[i, j].Enabled = false;
                    Controls.Add(B_green[i, j]);

                    B_red[i, j] = new Button();
                    B_red[i, j].SetBounds(590 + j * 30, 530 + i * 30, 30, 30);
                    B_red[i, j].BackColor = Color.Red;
                    B_red[i, j].Enabled = false;
                    Controls.Add(B_red[i, j]);

                    B_blue[i, j] = new Button();
                    B_blue[i, j].SetBounds(700 + j * 30, 530 + i * 30, 30, 30);
                    B_blue[i, j].BackColor = Color.Blue;
                    B_blue[i, j].Enabled = false;
                    Controls.Add(B_blue[i, j]);

                    B_white[i, j] = new Button();
                    B_white[i, j].SetBounds(480 + j * 30, 420 + i * 30, 30, 30);
                    B_white[i, j].BackColor = Color.White;
                    B_white[i, j].Enabled = false;
                    Controls.Add(B_white[i, j]);

                    B_yellow[i, j] = new Button();
                    B_yellow[i, j].SetBounds(480 + j * 30, 640 + i * 30, 30, 30);
                    B_yellow[i, j].BackColor = Color.Yellow;
                    B_yellow[i, j].Enabled = false;
                    Controls.Add(B_yellow[i, j]);
                }
            }
            ShowScramble();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeElapsed = DateTime.Now - startTime;
            L_time.Text = timeElapsed.TotalSeconds.ToString("0.00");
            if(timeElapsed.Seconds >= 10)
            {
                L_time.Location = new Point((Width - L_time.Width) / 2, (Height - L_time.Height) / 2 - 75);
            }
            if(timeElapsed.Minutes >= 1)
            {
                L_time.Text = timeElapsed.Minutes.ToString() + ":" + timeElapsed.Seconds.ToString("00") + "." + (timeElapsed.Milliseconds / 10).ToString("00");
                L_time.Location = new Point((Width - L_time.Width) / 2, (Height - L_time.Height) / 2 - 75);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (timing)
                return;
            L_time.Text = "0.00";
            L_time.ForeColor = Color.Green;
            L_time.Location = new Point((Width - L_time.Width) / 2, (Height - L_time.Height) / 2 - 75);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            L_time.ForeColor = Color.Black;
            if (!timing)
            {
                startTime = DateTime.Now;
                timer1.Start();
                timing = true;
            }
            else
            {
                timer1.Stop();
                timing = false;

                //RY 1228
                RecordHistory();
                Statistics();
                index++;
                //RY1228

                SaveScores();//儲存成績所用(看你要不要做一個確認儲存成績的選項)
                scramble.Text = sc.Generate();
                scramble.Location = new Point((Width - scramble.Width) / 2, 50);
                Rebuild();
                ShowScramble();
            }        
        }

        /**
         * 儲存本次練習結果並傳到資料庫(CurrentGradeHolder可視為一次性短時資料暫存器)
         */
        public void SaveScores()
        {
            CurrentGradeHolder cgh = new CurrentGradeHolder();
            DatabaseConnect dc = new DatabaseConnect();

            cgh.inCurrScore(Convert.ToDouble(L_time.Text));
            cgh.inCurrScramble(scramble.Text);

            dc.UpdateGradesToDatabase();
        }

        private void B_guide_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            scramble.Focus();
        }

        private void B_change_Click(object sender, EventArgs e)
        {
            scramble.Text = sc.Generate();
            scramble.Location = new Point((Width - scramble.Width) / 2, 50);
            Rebuild();
            ShowScramble();
            scramble.Focus();
        }

        public void ShowScramble()
        {
            String[] str = scramble.Text.Split(' ');
            foreach(string c in str)
            {
                if (c == "U")
                    sc.Turn_U(B_white, B_orange, B_green, B_red, B_blue);
                else if (c == "U'")
                    for (int i = 0; i < 3; i++)
                        sc.Turn_U(B_white, B_orange, B_green, B_red, B_blue);
                else if (c == "U2")
                    for (int i = 0; i < 2; i++)
                        sc.Turn_U(B_white, B_orange, B_green, B_red, B_blue);
                else if(c == "D")
                    sc.Turn_D(B_yellow, B_orange, B_green, B_red, B_blue);
                else if(c == "D'")
                    for (int i = 0; i < 3; i++)
                        sc.Turn_D(B_yellow, B_orange, B_green, B_red, B_blue);
                else if (c == "D2")
                    for (int i = 0; i < 2; i++)
                        sc.Turn_D(B_yellow, B_orange, B_green, B_red, B_blue);
                else if(c == "R")
                    sc.Turn_R(B_red, B_green, B_white, B_blue, B_yellow);
                else if (c == "R'")
                    for (int i = 0; i < 3; i++)
                        sc.Turn_R(B_red, B_green, B_white, B_blue, B_yellow);
                else if (c == "R2")
                    for (int i = 0; i < 2; i++)
                        sc.Turn_R(B_red, B_green, B_white, B_blue, B_yellow);
                else if (c == "L")
                    sc.Turn_L(B_orange, B_green, B_white, B_blue, B_yellow);
                else if (c == "L'")
                    for (int i = 0; i < 3; i++)
                        sc.Turn_L(B_orange, B_green, B_white, B_blue, B_yellow);
                else if (c == "L2")
                    for (int i = 0; i < 2; i++)
                        sc.Turn_L(B_orange, B_green, B_white, B_blue, B_yellow);
                else if (c == "F")
                    sc.Turn_F(B_green, B_white, B_red, B_yellow, B_orange);
                else if (c == "F'")
                    for (int i = 0; i < 3; i++)
                        sc.Turn_F(B_green, B_white, B_red, B_yellow, B_orange);
                else if (c == "F2")
                    for (int i = 0; i < 2; i++)
                        sc.Turn_F(B_green, B_white, B_red, B_yellow, B_orange);
                else if (c == "B")
                    sc.Turn_B(B_blue, B_white, B_red, B_yellow, B_orange);
                else if (c == "B'")
                    for (int i = 0; i < 3; i++)
                        sc.Turn_B(B_blue, B_white, B_red, B_yellow, B_orange);
                else if (c == "B2")
                    for (int i = 0; i < 2; i++)
                        sc.Turn_B(B_blue, B_white, B_red, B_yellow, B_orange);
            }
        }

        public void Rebuild()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    B_orange[i, j].BackColor = Color.Orange;
                    B_green[i, j].BackColor = Color.Green;
                    B_red[i, j].BackColor = Color.Red;
                    B_blue[i, j].BackColor = Color.Blue;
                    B_white[i, j].BackColor = Color.White;
                    B_yellow[i, j].BackColor = Color.Yellow;
                }
            }
        }

        private void B_logo_Click(object sender, EventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
            scramble.Focus();
        }

        private void VisitLink()
        {
            System.Diagnostics.Process.Start("https://cstimer.net/");
        }

        private void B_show_Click(object sender, EventArgs e)
        {
            if(B_show.Text == "Show")
            {
                B_show.Text = "Hide";
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        B_orange[i, j].Visible = true;
                        B_green[i, j].Visible = true;
                        B_red[i, j].Visible = true;
                        B_blue[i, j].Visible = true;
                        B_white[i, j].Visible = true;
                        B_yellow[i, j].Visible = true;
                    }
                }
            }
            else
            {
                B_show.Text = "Show";
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        B_orange[i, j].Visible = false;
                        B_green[i, j].Visible = false;
                        B_red[i, j].Visible = false;
                        B_blue[i, j].Visible = false;
                        B_white[i, j].Visible = false;
                        B_yellow[i, j].Visible = false;
                    }
                }
            }
            scramble.Focus();
        }
        //RY1228
        private void RecordHistory()
        {
            grade[index] = Convert.ToDouble(L_time.Text);
            History.Text += grade[index];
            History.Text += "\n";
        }

        private void Statistics()
        { 
            if (index == 0)
            {
                average = grade[0];
            }
            if (index > 0)
            {
                for (int i = 0; i < index; i++)
                {
                    sum += grade[i];
                }

                average = sum / index;
            }

            AverageLabel.Text = average.ToString();

            if (index == 0)
            {
                best = grade[0];
                BestLabel.Text = best.ToString();
                worst = grade[0];
                WorstLabel.Text = worst.ToString();
            }
            if (index > 0)
            {
                if (grade[index] <= best)
                {
                    best = grade[index];
                    BestLabel.Text = best.ToString();
                }
                if (grade[index] >= worst)
                {
                    worst = grade[index];
                    WorstLabel.Text = worst.ToString();
                }
            }
        }
        //RY1228
        private void B_logout_Click(object sender, EventArgs e)
        {
            DatabaseConnect dc = new DatabaseConnect();
            dc.UpdateScoringTimes();

            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            scramble.Text = sc.Generate();
            scramble.Location = new Point((Width - scramble.Width) / 2, 50);
            Rebuild();
            ShowScramble();
            scramble.Focus();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void instructionDropDown_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            scramble.Focus();
        }

        private void 檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void instructionToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void mingZesYouTubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC9zcXnhk3BDrqNf6NjIym9A");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
            scramble.Focus();
        }

        private void cstimernetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
            scramble.Focus();
        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.worldcubeassociation.org/regulations/translations/chinese-traditional/");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
            scramble.Focus();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showHideToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (B_show.Text == "Show")
            {
                B_show.Text = "Hide";
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        B_orange[i, j].Visible = true;
                        B_green[i, j].Visible = true;
                        B_red[i, j].Visible = true;
                        B_blue[i, j].Visible = true;
                        B_white[i, j].Visible = true;
                        B_yellow[i, j].Visible = true;
                    }
                }
            }
            else
            {
                B_show.Text = "Show";
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        B_orange[i, j].Visible = false;
                        B_green[i, j].Visible = false;
                        B_red[i, j].Visible = false;
                        B_blue[i, j].Visible = false;
                        B_white[i, j].Visible = false;
                        B_yellow[i, j].Visible = false;
                    }
                }
            }
            scramble.Focus();
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
            {
                L_time.Font = fnt.Font;
                History.Font = fnt.Font;
                groupBox1.Font = fnt.Font;
            }
        }

        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            cld.ShowDialog();
            L_time.ForeColor = cld.Color;
            History.ForeColor = cld.Color;
            groupBox1.ForeColor = cld.Color;
            scramble.ForeColor = cld.Color;
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            cld.ShowDialog();
            L_time.BackColor = cld.Color;
            History.BackColor = cld.Color;
            groupBox1.BackColor = cld.Color;
            scramble.BackColor = cld.Color;
        }

        private void environmentColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            cld.ShowDialog();
            this.BackColor = cld.Color;
        }

        private void foreColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            cld.ShowDialog();
            B_change.ForeColor = cld.Color;
            B_show.ForeColor = cld.Color;
        }

        private void backColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            cld.ShowDialog();
            B_change.BackColor = cld.Color;
            B_show.BackColor = cld.Color;
        }

        private void buttonFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
            {
                B_change.Font = fnt.Font;
                B_show.Font = fnt.Font;
            }
        }

        private void creditsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void videoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                // RY,0104 Change Link to introducing video link
                System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC9zcXnhk3BDrqNf6NjIym9A");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
            scramble.Focus();
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            scramble.Focus();
        }
    }
}
