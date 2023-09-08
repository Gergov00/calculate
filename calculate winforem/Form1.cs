using System;

using System.Text;

using System.Windows.Forms;

namespace calculate_winforem
{
    public partial class Калькулятор : Form
    {
        public Калькулятор()
        {
            InitializeComponent();
        }
        private void TextWrite_Click(object sender, EventArgs e) // чтоб был
        {

        }


        private bool share_butt = false;
        private bool multiply_butt = false;
        private bool minus_butt = false;
        private bool pluss_butt = false;


        private decimal number_1 = 0;
        private decimal number_2 = 0;



        private void button13_Click(object sender, EventArgs e)
        {
            TextWrite.Text += "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TextWrite.Text += "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TextWrite.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TextWrite.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TextWrite.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TextWrite.Text += "5";
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            TextWrite.Text += "6";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            TextWrite.Text += "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextWrite.Text += "8";
        }


        private void NineButton_Click(object sender, EventArgs e)
        {
            TextWrite.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e) //clear
        {
            TextWrite.Text = "";
        }

        private void button14_Click(object sender, EventArgs e) //запитая
        {
            if (TextWrite.Text[TextWrite.Text.Length - 1] != ',') 
            {
                TextWrite.Text += ",";
            }

        }

        private void button1_Click(object sender, EventArgs e) //операция сложения
        {
            try
            {
                number_1 = Decimal.Parse(TextWrite.Text);
            }
            catch { }

            TextWrite.Text = "";

            pluss_butt = true;
        }

        private void share_Click(object sender, EventArgs e) //операция деления
        {
            try
            {
                number_1 = Decimal.Parse(TextWrite.Text);
            }
            catch { }

            TextWrite.Text = "";

            share_butt = true;
        }
      
        private void multiplyButton_Click(object sender, EventArgs e) //операция умножения
        {
            try
            {
                number_1 = Decimal.Parse(TextWrite.Text);
            }
            catch { }

            TextWrite.Text = "";

            multiply_butt = true;
        }    

        private void button3_Click(object sender, EventArgs e) //операция разности
        {
            try
            {
                number_1 = Decimal.Parse(TextWrite.Text);
            }
            catch { }

            TextWrite.Text = "";

            minus_butt = true;
        }

        private void procent_Click(object sender, EventArgs e) //процент
        {
            try
            {

                number_1 = decimal.Parse(TextWrite.Text) / 100.0m;
                TextWrite.Text += "%";
            }
            catch { }

        }

        private void button19_Click(object sender, EventArgs e) //backspace
        {
            StringBuilder temp = new StringBuilder(TextWrite.Text);

            try{
             
                temp.Remove(TextWrite.Text.Length-1,1);
            }
            catch (Exception) 
            {
                TextWrite.Text = "";
            }
            

            TextWrite.Text = temp.ToString();
        }
          
        private void button2_Click(object sender, EventArgs e) //выполнения операций
        {

            try
            {
                if (TextWrite.Text[TextWrite.Text.Length - 1] != '%') { number_2 = Decimal.Parse(TextWrite.Text); }
                else 
                {
                    StringBuilder temp = new StringBuilder(TextWrite.Text);
                    temp.Remove(TextWrite.Text.Length - 1, 1);
                    string temp2 = temp.ToString();
                    decimal temp_number = Decimal.Parse(temp2.ToString());
                    number_2 = temp_number / 100.0m;
                }
            
            }
            catch { }


            if (multiply_butt == true)
            {
                TextWrite.Text = $"{number_1 * number_2}";
                multiply_butt = false;
            }
            if (share_butt == true)
            {
                try
                {
                    decimal temp = number_1 / number_2;
                    TextWrite.Text = $"{temp}";
                }
                catch(Exception) 
                {
                    TextWrite.Text = "Ошибка!";
                }
                share_butt = false;
            }
            if (pluss_butt == true)
            {
                TextWrite.Text = $"{number_1 + number_2}";
                pluss_butt = false;
            }
            if (minus_butt == true)
            {
                TextWrite.Text = $"{number_1 - number_2}";
                minus_butt = false;
            }
        }
    }
}
