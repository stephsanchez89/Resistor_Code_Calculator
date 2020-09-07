using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resistor_Code_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblSelector.Text = "Select first Color\nFor 4 band use black as first";
            lblFirst.Text = "";
            lblSecond.Text = "";
            lblThird.Text = "";
            lblMulti.Text = "";
            lblTolerance.Text = "";
        }


        private void checkBlack_CheckedChanged(object sender, EventArgs e)
        {
            if(lblFirst.Text =="")
            {
                lblFirst.Text = "0";
                lblLine1.BackColor = Color.Black;
                lblSelector.Text = "Select Second Color";
            }
            else if(lblSecond.Text =="")
            {
                lblSecond.Text = "0";
                lblLine2.BackColor = Color.Black;
                lblSelector.Text = "Select Third Color";
            }
            else if(lblThird.Text == "")
            {
                lblThird.Text = "0";
                lblLine3.BackColor = Color.Black;
                lblSelector.Text = "Select Fourth Color";
            }
            else if (lblMulti.Text == "")
            {
                lblMulti.Text = "1";
                lblLine4.BackColor = Color.Black;
                lblSelector.Text = "Select Last Color";
            }
            else if (lblTolerance.Text == "")
            {
                lblTolerance.Text = "";
                //lblLine4.BackColor = Color.Black;
                lblSelector.Text = "Invalid Choice\nSelect Last Color";
            }
        }

        private void checkBrown_CheckedChanged(object sender, EventArgs e)
        {
            if (lblFirst.Text == "")
            {
                lblFirst.Text = "1";
                lblLine1.BackColor = Color.Brown;
                lblSelector.Text = "Select Second Color";
            }
            else if (lblSecond.Text == "")
            {
                lblSecond.Text = "1";
                lblLine2.BackColor = Color.Brown;
                lblSelector.Text = "Select Third Color";
            }
            else if (lblThird.Text == "")
            {
                lblThird.Text = "1";
                lblLine3.BackColor = Color.Brown;
                lblSelector.Text = "Select Fourth Color";
            }
            else if (lblMulti.Text == "")
            {
                lblMulti.Text = "10";
                lblLine4.BackColor = Color.Brown;
                lblSelector.Text = "Select Last Color";
            }
            else if (lblTolerance.Text == "")
            {
                lblTolerance.Text = "1%";
                lblLine5.BackColor = Color.Brown;
                btn_CalculateResistor.Enabled = true;
                lblSelector.Text = "Click on Calculate Resistor";
            }
        }

        private void checkRed_CheckedChanged(object sender, EventArgs e)
        {
            if (lblFirst.Text == "")
            {
                lblFirst.Text = "2";
                lblLine1.BackColor = Color.Red;
                lblSelector.Text = "Select Second Color";
            }
            else if (lblSecond.Text == "")
            {
                lblSecond.Text = "2";
                lblLine2.BackColor = Color.Red;
                lblSelector.Text = "Select Third Color";
            }
            else if (lblThird.Text == "")
            {
                lblThird.Text = "2";
                lblLine3.BackColor = Color.Red;
                lblSelector.Text = "Select Fourth Color";
            }
            else if (lblMulti.Text == "")
            {
                lblMulti.Text = "100";
                lblLine4.BackColor = Color.Red;
                lblSelector.Text = "Select Last Color";
            }
            else if (lblTolerance.Text == "")
            {
                lblTolerance.Text = "2%";
                lblLine5.BackColor = Color.Red;
                btn_CalculateResistor.Enabled = true;
                lblSelector.Text = "Click on Calculate Resistor";
            }
        }

        private void checkOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (lblFirst.Text == "")
            {
                lblFirst.Text = "3";
                lblLine1.BackColor = Color.Orange;
                lblSelector.Text = "Select Second Color";
            }
            else if (lblSecond.Text == "")
            {
                lblSecond.Text = "3";
                lblLine2.BackColor = Color.Orange;
                lblSelector.Text = "Select Third Color";
            }
            else if (lblThird.Text == "")
            {
                lblThird.Text = "3";
                lblLine3.BackColor = Color.Orange;
                lblSelector.Text = "Select Fourth Color";
            }
            else if (lblMulti.Text == "")
            {
                lblMulti.Text = "1,000";
                lblLine4.BackColor = Color.Orange;
                lblSelector.Text = "Select Last Color";

            }
            else if (lblTolerance.Text == "")
            {
                lblTolerance.Text = "3%";
                lblLine5.BackColor = Color.Orange;
                btn_CalculateResistor.Enabled = true;
                lblSelector.Text = "Click on Calculate Resistor";
            }
        }
            private void checkYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (lblFirst.Text == "")
            {
                lblFirst.Text = "4";
                lblLine1.BackColor = Color.Yellow;
                lblSelector.Text = "Select Second Color";
            }
            else if (lblSecond.Text == "")
            {
                lblSecond.Text = "4";
                lblLine2.BackColor = Color.Yellow;
                lblSelector.Text = "Select Third Color";
            }
            else if (lblThird.Text == "")
            {
                lblThird.Text = "4";
                lblLine3.BackColor = Color.Yellow;
                lblSelector.Text = "Select Fourth Color";
            }
            else if (lblMulti.Text == "")
            {
                lblMulti.Text = "10,000";
                lblLine4.BackColor = Color.Yellow;
                lblSelector.Text = "Select Last Color";
            }
            else if (lblTolerance.Text == "")
            {
                lblTolerance.Text = "4%";
                lblLine5.BackColor = Color.Yellow;
                btn_CalculateResistor.Enabled = true;
                lblSelector.Text = "Click on Calculate Resistor";
            }
        }

        private void checkGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (lblFirst.Text == "")
            {
                lblFirst.Text = "5";
                lblLine1.BackColor = Color.Green;
                lblSelector.Text = "Select Second Color";
            }
            else if (lblSecond.Text == "")
            {
                lblSecond.Text = "5";
                lblLine2.BackColor = Color.Green;
                lblSelector.Text = "Select Third Color";
            }
            else if (lblThird.Text == "")
            {
                lblThird.Text = "5";
                lblLine3.BackColor = Color.Green;
                lblSelector.Text = "Select Fourth Color";
            }
            else if (lblMulti.Text == "")
            {
                lblMulti.Text = "100,000";
                lblLine4.BackColor = Color.Green;
                lblSelector.Text = "Select Last Color";
            }
            else if (lblTolerance.Text == "")
            {
                lblTolerance.Text = "0.5%";
                lblLine5.BackColor = Color.Green;
                btn_CalculateResistor.Enabled = true;
                lblSelector.Text = "Click on Calculate Resistor";
            }
        }

        private void checkBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (lblFirst.Text == "")
            {
                lblFirst.Text = "6";
                lblLine1.BackColor = Color.Blue;
                lblSelector.Text = "Select Second Color";
            }
            else if (lblSecond.Text == "")
            {
                lblSecond.Text = "6";
                lblLine2.BackColor = Color.Blue;
                lblSelector.Text = "Select Third Color";
            }
            else if (lblThird.Text == "")
            {
                lblThird.Text = "6";
                lblLine3.BackColor = Color.Blue;
                lblSelector.Text = "Select Fourth Color";
            }
            else if (lblMulti.Text == "")
            {
                lblMulti.Text = "1,000,000";
                lblLine4.BackColor = Color.Blue;
                lblSelector.Text = "Select Last Color";
            }
            else if (lblTolerance.Text == "")
            {
                lblTolerance.Text = "0.25%";
                lblLine5.BackColor = Color.Blue;
                btn_CalculateResistor.Enabled = true;
                lblSelector.Text = "Click on Calculate Resistor";
            }
        }

        private void checkViolet_CheckedChanged(object sender, EventArgs e)
        {
            if (lblFirst.Text == "")
            {
                lblFirst.Text = "7";
                lblLine1.BackColor = Color.Violet;
                lblSelector.Text = "Select Second Color";
            }
            else if (lblSecond.Text == "")
            {
                lblSecond.Text = "7";
                lblLine2.BackColor = Color.Violet;
                lblSelector.Text = "Select Third Color";
            }
            else if (lblThird.Text == "")
            {
                lblThird.Text = "7";
                lblLine3.BackColor = Color.Violet;
                lblSelector.Text = "Select Fourth Color";
            }
            else if (lblMulti.Text == "")
            {
                lblMulti.Text = "10,000,000";
                lblLine4.BackColor = Color.Violet;
                lblSelector.Text = "Select Last Color";

            }
            else if (lblTolerance.Text == "")
            {
                lblTolerance.Text = "0.1%";
                lblLine5.BackColor = Color.Violet;
                btn_CalculateResistor.Enabled = true;
                lblSelector.Text = "Click on Calculate Resistor";
            }
        }

        private void checkGray_CheckedChanged(object sender, EventArgs e)
        {
            if (lblFirst.Text == "")
            {
                lblFirst.Text = "8";
                lblLine1.BackColor = Color.Gray;
                lblSelector.Text = "Select Second Color";
            }
            else if (lblSecond.Text == "")
            {
                lblSecond.Text = "8";
                lblLine2.BackColor = Color.Gray;
                lblSelector.Text = "Select Third Color";
            }
            else if (lblThird.Text == "")
            {
                lblThird.Text = "8";
                lblLine3.BackColor = Color.Gray;
                lblSelector.Text = "Select Fourth Color";
            }
            else if (lblMulti.Text == "")
            {
                lblMulti.Text = "100,000,000";
                lblLine4.BackColor = Color.Gray;
                lblSelector.Text = "Select Last Color";

            }
            else if (lblTolerance.Text == "")
            {
                lblTolerance.Text = "0.05%";
                lblLine5.BackColor = Color.Gray;
                btn_CalculateResistor.Enabled = true;
                lblSelector.Text = "Click on Calculate Resistor";
            }
        }

        private void checkWhite_CheckedChanged(object sender, EventArgs e)
        {
            if (lblFirst.Text == "")
            {
                lblFirst.Text = "9";
                lblLine1.BackColor = Color.White;
                lblSelector.Text = "Select Second Color";
            }
            else if (lblSecond.Text == "")
            {
                lblSecond.Text = "9";
                lblLine2.BackColor = Color.White;
                lblSelector.Text = "Select Third Color";
            }
            else if (lblThird.Text == "")
            {
                lblThird.Text = "9";
                lblLine3.BackColor = Color.White;
                lblSelector.Text = "Select Fourth Color";
            }
            else if (lblMulti.Text == "")
            {
                lblMulti.Text = "1,000,000,000";
                lblLine5.BackColor = Color.White;
                lblSelector.Text = "Select Last Color";
            }
            else if (lblTolerance.Text == "")
            {
                lblTolerance.Text = "";
                //lblLine4.BackColor = Color.Black;
                lblSelector.Text = "Invalid Choice\nSelect Last Color";
            }
        }

        private void checkGold_CheckedChanged(object sender, EventArgs e)
        {


            if (((lblFirst.Text != "")&&(lblSecond.Text != "")&&(lblThird.Text!=""))&& (lblMulti.Text == ""))
            {
                lblMulti.Text = "0.1";
                lblLine4.BackColor = Color.Gold;
                lblSelector.Text = "Select Last Color";

            }
            else if (((lblFirst.Text != "") && (lblSecond.Text != "") && (lblThird.Text != "") && (lblMulti.Text != ""))&&(lblTolerance.Text ==""))
            {
                lblTolerance.Text = "5%";
                lblLine5.BackColor = Color.Gold;
                btn_CalculateResistor.Enabled = true;
                lblSelector.Text = "Click on Calculate Resistor";
            }
            //else if (lbl)
                /*checkSilver.Checked = false;
                checkNoColor.Checked = false;
                btn_CalculateResistor.Enabled = true;
                lblLine5.BackColor = Color.Gold;
                lblSelector.Text = "Click on Calculate Resistor";*/
        }

        private void checkSilver_CheckedChanged(object sender, EventArgs e)
        {
            if (((lblFirst.Text != "") && (lblSecond.Text != "") && (lblThird.Text != "")) && (lblMulti.Text == ""))
            {
                lblMulti.Text = "0.01";
                lblLine4.BackColor = Color.Silver;
                lblSelector.Text = "Select Last Color";

            }
            else if (((lblFirst.Text != "") && (lblSecond.Text != "") && (lblThird.Text != "") && (lblMulti.Text != "")) && (lblTolerance.Text == ""))
            {
                lblTolerance.Text = "10%";
                lblLine5.BackColor = Color.Silver;
                btn_CalculateResistor.Enabled = true;
                lblSelector.Text = "Click on Calculate Resistor";
            }
        }

        private void checkNoColor_CheckedChanged(object sender, EventArgs e)
        {
            if (((lblFirst.Text != "") && (lblSecond.Text != "") && (lblThird.Text != "") && (lblMulti.Text != "")) && (lblTolerance.Text == ""))
            {
                lblTolerance.Text = "20%";
                lblLine5.BackColor = Color.White;
                btn_CalculateResistor.Enabled = true;
                lblSelector.Text = "Click on Calculate Resistor";
            }
        }

        private void btn_CalculateResistor_Click(object sender, EventArgs e)
        {
            double[] q = new double[7];
            String first = Convert.ToString(lblFirst.Text);
            String second = Convert.ToString(lblSecond.Text);
            String third = Convert.ToString(lblThird.Text);
            Double multi = Convert.ToDouble(lblMulti.Text);
            

            String num = first + second + third;
            q[1] = Convert.ToDouble(num);
            q[2] = q[1];
            q[3] = ((q[2] * multi) / 1000);
            ResistValue.Text = Convert.ToString((q[3]) + ("k ohm ") + lblTolerance.Text);
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            DialogResult iReset;

            iReset = MessageBox.Show("Confirm if you want to Reset Resistor Color Calculator", "Resistor Color Calculator", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (iReset == DialogResult.OK)
            {
                foreach (CheckBox control in this.Controls.OfType<CheckBox>() )
                {
                    control.Checked = false;
                }
                lblFirst.Text = "";
                lblSecond.Text = "";
                lblThird.Text = "";
                lblMulti.Text = "";
                lblTolerance.Text = "";
                ResistValue.Text = "";
                lblSelector.Text = "Select first Color\nFor 4 band use black as first";
                lblLine1.BackColor = Color.Black;
                lblLine2.BackColor = Color.Black;
                lblLine3.BackColor = Color.Black;
                lblLine4.BackColor = Color.Black;
                lblLine5.BackColor = Color.Black;
                btn_CalculateResistor.Enabled = false;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm if you want to Exit", "Resistor Color Code Calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit== DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
