using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //WHISPY WOODS

            float price = 1300f;
            int qty = 0;

            try
            {
                qty = int.Parse(textBox1.Text);
            }

            catch
            {
                MessageBox.Show("You can only input a numerical value.");
            }

            float totalPrice = price * qty;
            listBox1.Items.Add(qty + " Whispy Woods - 1300.00 - Php " + totalPrice.ToString("N"));
            int x = listBox1.Items.Count;
            string[] totalItems = new string[x];
            for (int i = 0; i < x; i++)
            {
                totalItems[i] = listBox1.Items[i].ToString();
            }


            float l = 0;
            foreach (string item in totalItems)
            {
                int P = item.IndexOf("Php ");
                string k = item.Substring(P + 3);
                float f = float.Parse(k);
                l += f;
                button9.Text = l.ToString("n");
                button13.Text = listBox1.Items.Count.ToString();
                float tender = 0;
                float change = 0;
                float saleAmount = 0;

                try
                {
                    tender = float.Parse(textBox2.Text);
                    saleAmount = float.Parse(button9.Text);
                }

                catch
                {
                    if (textBox2.Text != "")
                    {
                        textBox2.Text = "";
                        DialogResult y = MessageBox.Show("You can only input a numerical value.", "Error", MessageBoxButtons.OK);
                    }
                }

                change = tender - saleAmount;
                button12.Text = change.ToString();

                if (listBox1.Items.Count == 0)
                {
                    button9.Text = "0.00";
                    button13.Text = "";
                    button10.Enabled = false;
                    button12.Text = "0.00";
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            float price = 800f;
            int qty = 0;

            try
            {
                qty = int.Parse(textBox1.Text);
            }

            catch
            {
                MessageBox.Show("You can only input a numerical value.");
            }

            float totalPrice = price * qty;
            listBox1.Items.Add(qty + " Waddle Dee - 800.00 - Php " + totalPrice.ToString("N"));
            int x = listBox1.Items.Count;
            string[] totalItems = new string[x];
            for (int i = 0; i < x; i++)
            {
                totalItems[i] = listBox1.Items[i].ToString();
            }


            float l = 0;
            foreach (string item in totalItems)
            {
                int P = item.IndexOf("Php ");
                string k = item.Substring(P + 3);
                float f = float.Parse(k);
                l += f;
                button9.Text = l.ToString("n");
                button13.Text = listBox1.Items.Count.ToString();
                float tender = 0;
                float change = 0;
                float saleAmount = 0;

                try
                {
                    tender = float.Parse(textBox2.Text);
                    saleAmount = float.Parse(button9.Text);
                }

                catch
                {
                    if (textBox2.Text != "")
                    {
                        textBox2.Text = "";
                        DialogResult y = MessageBox.Show("You can only input a numerical value.", "Error", MessageBoxButtons.OK);
                    }
                }

                change = tender - saleAmount;
                button12.Text = change.ToString();

                if (listBox1.Items.Count == 0)
                {
                    button9.Text = "0.00";
                    button13.Text = "";
                    button10.Enabled = false;
                    button12.Text = "0.00";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float price = 650f;
            int qty = 0;

            try
            {
                qty = int.Parse(textBox1.Text);
            }

            catch
            {
                MessageBox.Show("You can only input a numerical value.");
            }

            float totalPrice = price * qty;
            listBox1.Items.Add(qty + " Kirby Suction - 650.00 - Php " + totalPrice.ToString("N"));
            int x = listBox1.Items.Count;
            string[] totalItems = new string[x];
            for (int i = 0; i < x; i++)
            {
                totalItems[i] = listBox1.Items[i].ToString();
            }


            float l = 0;
            foreach (string item in totalItems)
            {
                int P = item.IndexOf("Php ");
                string k = item.Substring(P + 3);
                float f = float.Parse(k);
                l += f;
                button9.Text = l.ToString("n");
                button13.Text = listBox1.Items.Count.ToString();
                float tender = 0;
                float change = 0;
                float saleAmount = 0;

                try
                {
                    tender = float.Parse(textBox2.Text);
                    saleAmount = float.Parse(button9.Text);
                }

                catch
                {
                    if (textBox2.Text != "")
                    {
                        textBox2.Text = "";
                        DialogResult y = MessageBox.Show("You can only input a numerical value.", "Error", MessageBoxButtons.OK);
                    }
                }

                change = tender - saleAmount;
                button12.Text = change.ToString();

                if (listBox1.Items.Count == 0)
                {
                    button9.Text = "0.00";
                    button13.Text = "";
                    button10.Enabled = false;
                    button12.Text = "0.00";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float price = 450f;
            int qty = 0;

            try
            {
                qty = int.Parse(textBox1.Text);
            }

            catch
            {
                MessageBox.Show("You can only input a numerical value.");
            }

            float totalPrice = price * qty;
            listBox1.Items.Add(qty + " Kirby Burger - 450.00 - Php " + totalPrice.ToString("N"));
            int x = listBox1.Items.Count;
            string[] totalItems = new string[x];
            for (int i = 0; i < x; i++)
            {
                totalItems[i] = listBox1.Items[i].ToString();
            }


            float l = 0;
            foreach (string item in totalItems)
            {
                int P = item.IndexOf("Php ");
                string k = item.Substring(P + 3);
                float f = float.Parse(k);
                l += f;
                button9.Text = l.ToString("n");
                button13.Text = listBox1.Items.Count.ToString();
                float tender = 0;
                float change = 0;
                float saleAmount = 0;

                try
                {
                    tender = float.Parse(textBox2.Text);
                    saleAmount = float.Parse(button9.Text);
                }

                catch
                {
                    if (textBox2.Text != "")
                    {
                        textBox2.Text = "";
                        DialogResult y = MessageBox.Show("You can only input a numerical value.", "Error", MessageBoxButtons.OK);
                    }
                }

                change = tender - saleAmount;
                button12.Text = change.ToString();

                if (listBox1.Items.Count == 0)
                {
                    button9.Text = "0.00";
                    button13.Text = "";
                    button10.Enabled = false;
                    button12.Text = "0.00";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float price = 700f;
            int qty = 0;

            try
            {
                qty = int.Parse(textBox1.Text);
            }

            catch
            {
                MessageBox.Show("You can only input a numerical value.");
            }

            float totalPrice = price * qty;
            listBox1.Items.Add(qty + " Kawasaki Stew - 700.00 - Php " + totalPrice.ToString("N"));
            int x = listBox1.Items.Count;
            string[] totalItems = new string[x];
            for (int i = 0; i < x; i++)
            {
                totalItems[i] = listBox1.Items[i].ToString();
            }


            float l = 0;
            foreach (string item in totalItems)
            {
                int P = item.IndexOf("Php ");
                string k = item.Substring(P + 3);
                float f = float.Parse(k);
                l += f;
                button9.Text = l.ToString("n");
                button13.Text = listBox1.Items.Count.ToString();
                float tender = 0;
                float change = 0;
                float saleAmount = 0;

                try
                {
                    tender = float.Parse(textBox2.Text);
                    saleAmount = float.Parse(button9.Text);
                }

                catch
                {
                    if (textBox2.Text != "")
                    {
                        textBox2.Text = "";
                        DialogResult y = MessageBox.Show("You can only input a numerical value.", "Error", MessageBoxButtons.OK);
                    }
                }

                change = tender - saleAmount;
                button12.Text = change.ToString();

                if (listBox1.Items.Count == 0)
                {
                    button9.Text = "0.00";
                    button13.Text = "";
                    button10.Enabled = false;
                    button12.Text = "0.00";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            float price = 700f;
            int qty = 0;

            try
            {
                qty = int.Parse(textBox1.Text);
            }

            catch
            {
                MessageBox.Show("You can only input a numerical value.");
            }

            float totalPrice = price * qty;
            listBox1.Items.Add(qty + " Kawasaki Pasta - 700.00 - Php " + totalPrice.ToString("N"));
            int x = listBox1.Items.Count;
            string[] totalItems = new string[x];
            for (int i = 0; i < x; i++)
            {
                totalItems[i] = listBox1.Items[i].ToString();
            }


            float l = 0;
            foreach (string item in totalItems)
            {
                int P = item.IndexOf("Php ");
                string k = item.Substring(P + 3);
                float f = float.Parse(k);
                l += f;
                button9.Text = l.ToString("n");
                button13.Text = listBox1.Items.Count.ToString();
                float tender = 0;
                float change = 0;
                float saleAmount = 0;

                try
                {
                    tender = float.Parse(textBox2.Text);
                    saleAmount = float.Parse(button9.Text);
                }

                catch
                {
                    if (textBox2.Text != "")
                    {
                        textBox2.Text = "";
                        DialogResult y = MessageBox.Show("You can only input a numerical value.", "Error", MessageBoxButtons.OK);
                    }
                }

                change = tender - saleAmount;
                button12.Text = change.ToString();

                if (listBox1.Items.Count == 0)
                {
                    button9.Text = "0.00";
                    button13.Text = "";
                    button10.Enabled = false;
                    button12.Text = "0.00";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            float price = 500f;
            int qty = 0;

            try
            {
                qty = int.Parse(textBox1.Text);
            }

            catch
            {
                MessageBox.Show("You can only input a numerical value.");
            }

            float totalPrice = price * qty;
            listBox1.Items.Add(qty + " Kirby Coffee - 500.00 - Php " + totalPrice.ToString("N"));
            int x = listBox1.Items.Count;
            string[] totalItems = new string[x];
            for (int i = 0; i < x; i++)
            {
                totalItems[i] = listBox1.Items[i].ToString();
            }


            float l = 0;
            foreach (string item in totalItems)
            {
                int P = item.IndexOf("Php ");
                string k = item.Substring(P + 3);
                float f = float.Parse(k);
                l += f;
                button9.Text = l.ToString("n");
                button13.Text = listBox1.Items.Count.ToString();
                float tender = 0;
                float change = 0;
                float saleAmount = 0;

                try
                {
                    tender = float.Parse(textBox2.Text);
                    saleAmount = float.Parse(button9.Text);
                }

                catch
                {
                    if (textBox2.Text != "")
                    {
                        textBox2.Text = "";
                        DialogResult y = MessageBox.Show("You can only input a numerical value.", "Error", MessageBoxButtons.OK);
                    }
                }

                change = tender - saleAmount;
                button12.Text = change.ToString();

                if (listBox1.Items.Count == 0)
                {
                    button9.Text = "0.00";
                    button13.Text = "";
                    button10.Enabled = false;
                    button12.Text = "0.00";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            float price = 350f;
            int qty = 0;

            try
            {
                qty = int.Parse(textBox1.Text);
            }

            catch
            {
                MessageBox.Show("You can only input a numerical value.");
            }

            float totalPrice = price * qty;
            listBox1.Items.Add(qty + " Orange Ocean - 350.00 - Php " + totalPrice.ToString("N"));
            int x = listBox1.Items.Count;
            string[] totalItems = new string[x];
            for (int i = 0; i < x; i++)
            {
                totalItems[i] = listBox1.Items[i].ToString();
            }


            float l = 0;
            foreach (string item in totalItems)
            {
                int P = item.IndexOf("Php ");
                string k = item.Substring(P + 3);
                float f = float.Parse(k);
                l += f;
                button9.Text = l.ToString("n");
                button13.Text = listBox1.Items.Count.ToString();
                float tender = 0;
                float change = 0;
                float saleAmount = 0;

                try
                {
                    tender = float.Parse(textBox2.Text);
                    saleAmount = float.Parse(button9.Text);
                }

                catch
                {
                    if (textBox2.Text != "")
                    {
                        textBox2.Text = "";
                        DialogResult y = MessageBox.Show("You can only input a numerical value.", "Error", MessageBoxButtons.OK);
                    }
                }

                change = tender - saleAmount;
                button12.Text = change.ToString();

                if (listBox1.Items.Count == 0)
                {
                    button9.Text = "0.00";
                    button13.Text = "";
                    button10.Enabled = false;
                    button12.Text = "0.00";
                }
            }
        }
    






        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            button9.Text = "";
            button12.Text = "";
            button13.Text = "";

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }





        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            float tender = 0;
            float change = 0;
            float saleAmount = 0;

            try
            {
                tender = float.Parse(textBox2.Text);
                saleAmount = float.Parse(button9.Text);
            }

            catch
            {
                if (textBox2.Text != "")
                {
                    textBox2.Text = "";
                    DialogResult y = MessageBox.Show("You can only input a numerical value.", "Error", MessageBoxButtons.OK);
                }
            }

            change = tender - saleAmount;
            button12.Text = change.ToString("n");

        }




        private void button9_MouseHover(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int qty = 0;

            try
            {
                qty = int.Parse(textBox1.Text);
            }

            catch
            {
                if (textBox1.Text != "")
                {
                    textBox1.Text = "1";
                    DialogResult x = MessageBox.Show("Numbers Only", "Error", MessageBoxButtons.OK);
                }

            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            int qty = 0;

            try
            {
                qty = int.Parse(textBox1.Text);
            }

            catch
            {
                if (textBox1.Text != "")
                {
                    textBox1.Text = "1";
                    DialogResult x = MessageBox.Show("Numbers Only", "Error", MessageBoxButtons.OK);
                }

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int rem = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(rem);

                int x = listBox1.Items.Count;
                string[] totalItems = new string[x];
                for (int i = 0; i < x; i++)
                {
                    totalItems[i] = listBox1.Items[i].ToString();
                }


                float l = 0;
                foreach (string item in totalItems)
                {
                    int P = item.IndexOf("Php ");
                    string k = item.Substring(P + 3);
                    float f = float.Parse(k);
                    l += f;
                    button9.Text = l.ToString("n");
                    button13.Text = listBox1.Items.Count.ToString();






                    float tender = 0;
                    float change = 0;
                    float saleAmount = 0;

                    try
                    {
                        tender = float.Parse(textBox2.Text);
                        saleAmount = float.Parse(button9.Text);
                    }

                    catch
                    {
                        if (textBox2.Text != "")
                        {
                            textBox2.Text = "";
                            DialogResult y = MessageBox.Show("You can only input a numerical value.", "Error", MessageBoxButtons.OK);
                        }
                    }

                    change = tender - saleAmount;
                    button12.Text = change.ToString();


                }
                if (listBox1.Items.Count == 0)
                {
                    button9.Text = "0.00";
                    button13.Text = "";
                    button10.Enabled = false;
                    button12.Text = "0.00";
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
