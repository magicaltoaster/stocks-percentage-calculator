using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace percent
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0 && textBox1.Text.Length != 0)
            {
                double text1 = (Convert.ToDouble(textBox1.Text) / 100);
                double text2 = Convert.ToDouble(textBox2.Text);
                double ans = text1 * text2;
                label3.Text = String.Format("{0}% of {1} is:  {2}", textBox1.Text, textBox2.Text, ans.ToString("C"));

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0 && textBox1.Text.Length != 0)
            {
                double text1 = (Convert.ToDouble(textBox1.Text) / 100);
                double text2 = Convert.ToDouble(textBox2.Text);
                double ans = text1 * text2;
                label3.Text = String.Format("{0}% of {1} is:  {2}", textBox1.Text, textBox2.Text, ans.ToString("C"));
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length != 0 && textBox3.Text.Length != 0)
            {
                //[(New Value – Old Value)/Old Value] x 100 = Answer
                double text3 = Convert.ToDouble(textBox3.Text);
                double text4 = Convert.ToDouble(textBox4.Text);
                double ans = ((text4 - text3) / text3) * 100;
                label6.Text = String.Format("From {0} to {1} is:  {2}%", textBox3.Text, textBox4.Text, Math.Round(ans, 2));
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length != 0 && textBox3.Text.Length != 0)
            {
                //[(New Value – Old Value)/Old Value] x 100 = Answer
                double text3 = Convert.ToDouble(textBox3.Text);
                double text4 = Convert.ToDouble(textBox4.Text);
                double ans = ((text4 - text3) / text3) * 100;
                label6.Text = String.Format("From {0} to {1} is:  {2}%", textBox3.Text, textBox4.Text, Math.Round(ans, 2));
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Length != 0 && textBox6.Text.Length != 0)
            {
                double text6 = Convert.ToDouble(textBox6.Text);
                double text5 = Convert.ToDouble(textBox5.Text);
                double ans = (text6 / text5) * 100;
                label8.Text = String.Format("{0} of {1} is:  {2}%", text6, text5, Math.Round(ans, 2));

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Length != 0 && textBox6.Text.Length != 0)
            {
                double text6 = Convert.ToDouble(textBox6.Text);
                double text5 = Convert.ToDouble(textBox5.Text);
                double ans = (text6 / text5) * 100;
                label8.Text = String.Format("{0} of {1} is:  {2}%", text6, text5, Math.Round(ans, 2));

            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text.Length != 0 && textBox8.Text.Length != 0)
            {
                double text8 = Convert.ToDouble(textBox8.Text);
                double text7 = Convert.ToDouble(textBox7.Text);
                double ans = (text8 * 100) / text7;
                label10.Text = String.Format("{0} is {1}% of {2}", text8, text7, Math.Round(ans, 2));
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text.Length != 0 && textBox8.Text.Length != 0)
            {
                double text8 = Convert.ToDouble(textBox8.Text);
                double text7 = Convert.ToDouble(textBox7.Text);
                double ans = (text8 * 100) / text7;
                label10.Text = String.Format("{0} is {1}% of {2}", text8, text7, Math.Round(ans, 2));
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }


        public bool IsNumeric(string input)
        {
            double test;
            return double.TryParse(input, out test);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

            if (textBox9.Text.Length != 0 && textBox10.Text.Length != 0 && IsNumeric(textBox9.Text))
            {

                double text9 = 0;
                double text10 = Convert.ToDouble(textBox10.Text);
                if (textBox9.Text.Contains("-"))
                {
                    String temp = textBox9.Text;
                    temp = temp.Replace("-", "");
                    Double.TryParse(temp, out text9);
                    text9 = text9 * -1.0;
                }
                else
                {
                    text9 = Convert.ToDouble(textBox9.Text);
                }

                double val = (text10 * (text9 / 100));
                double ans = text10 + val;
                label16.Text = String.Format("{0} changed by {1}% is {2}", text10, text9, Math.Round(ans, 2));
            }

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

            if (textBox9.Text.Length != 0 && textBox10.Text.Length != 0 && IsNumeric(textBox9.Text))
            {

                double text10 = Convert.ToDouble(textBox10.Text);
                double text9 = 0;
                if (textBox9.Text.Contains("-"))
                {
                    String fuck = textBox9.Text;
                    fuck = fuck.Replace("-", "");
                    Double.TryParse(fuck, out text9);
                    text9 = text9 * -1.0;
                }
                else
                {
                    text9 = Convert.ToDouble(textBox9.Text);
                }

                double val = (text10 * (text9 / 100));
                double ans = text10 + val;

                label16.Text = String.Format("{0} changed by {1}% is {2}", text10, text9, Math.Round(ans, 2));
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void stockprice_TextChanged(object sender, EventArgs e)
        {
            if (percent.Text.Length != 0 && netliq.Text.Length != 0 && IsNumeric(stockprice.Text))
            {
                double percentD = Convert.ToDouble(percent.Text);
                double netliqD  = Convert.ToDouble(netliq.Text);
                double stockpriceD = Convert.ToDouble(stockprice.Text);
                double ans = ((percentD / 100) * netliqD)/stockpriceD;
                shares.Text = String.Format("shares: {0}",Math.Floor(ans));
            }
        }

        private void netliq_TextChanged(object sender, EventArgs e)
        {
            if (percent.Text.Length != 0 && netliq.Text.Length != 0 && IsNumeric(stockprice.Text))
            {
                double percentD = Convert.ToDouble(percent.Text);
                double netliqD = Convert.ToDouble(netliq.Text);
                double stockpriceD = Convert.ToDouble(stockprice.Text);
                double ans = ((percentD / 100) * netliqD) / stockpriceD;
                shares.Text = String.Format("shares: {0}", Math.Floor(ans));
            }
        }

        private void percent_TextChanged(object sender, EventArgs e)
        {
            if (percent.Text.Length != 0 && netliq.Text.Length != 0 && IsNumeric(stockprice.Text))
            {
                double percentD = Convert.ToDouble(percent.Text);
                double netliqD = Convert.ToDouble(netliq.Text);
                double stockpriceD = Convert.ToDouble(stockprice.Text);
                double ans = ((percentD / 100) * netliqD) / stockpriceD;
                shares.Text = String.Format("shares: {0}", Math.Floor(ans));
            }
        }
    }
}
