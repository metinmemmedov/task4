    namespace task4
    {
        public partial class Form1 : Form
        {
            List<double> prices = new();
            double finalTotal;
            public Form1()
            {
                InitializeComponent();
            }

            private void panel2_Paint(object sender, PaintEventArgs e)
            {

            }

            private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }

            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void richTextBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void label4_Click(object sender, EventArgs e)
            {

            }

            private void label4_Click_1(object sender, EventArgs e)
            {

            }

            private void pictureBox4_Click(object sender, EventArgs e)
            {
                listBox2.Items.Add("Cold Brew");
                prices.Add(4.95);
            }

            private void label10_Click(object sender, EventArgs e)
            {

            }

            private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void pictureBox2_Click(object sender, EventArgs e)
            {
                listBox2.Items.Add("Shaken Espresso");
                prices.Add(5.95);
            }

            private void pictureBox3_Click(object sender, EventArgs e)
            {
                listBox2.Items.Add("Caramel Macchiato");
                prices.Add(5.45);
            }

            private void pictureBox5_Click(object sender, EventArgs e)
            {
                listBox2.Items.Add("Pumpkin Spice Latte");
                prices.Add(5.95);
            }

            private void pictureBox6_Click(object sender, EventArgs e)
            {
                listBox2.Items.Add("Chocolate Mocha");
                prices.Add(5.45);
            }

            private void pictureBox7_Click(object sender, EventArgs e)
            {
                listBox2.Items.Add("Caffè Americano");
                prices.Add(4.25);
            }

            private void button2_Click(object sender, EventArgs e)
            {
            DialogResult result = MessageBox.Show("Xanalar sıfırlansınmı?", "Sual", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                prices.Clear();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox2.SelectedIndex;
            if (index != -1)
            {
                MessageBox.Show($"{listBox2.SelectedItem}" + " səbətdən silindi.", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBox2.Items.RemoveAt(index);
                prices.RemoveAt(index);   // keep both in sync
                listBox3.Items.Clear();
                maskedTextBox1.Clear();
                listBox1.Items.Clear();
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count!=0)
            { finalTotal = prices.Sum();
                listBox3.Items.Clear();
                listBox3.Items.Add($"${finalTotal:F2}");
            } 
        }

        private void button5_Click(object sender, EventArgs e)
            {
            maskedTextBox1.Clear();
            listBox1.Items.Clear();
            }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(maskedTextBox1.Text, out double daxilEdilenMebleg))
            {
                MessageBox.Show("Xahiş olunur məbləği düzgün qeyd edin.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double total = prices.Sum();   

            if (daxilEdilenMebleg < total)
            {
                MessageBox.Show("Daxil edilən məbləğ hesabdan azdır.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            listBox1.Items.Clear();
            listBox1.Items.Add($"${daxilEdilenMebleg - total:F2}");
        }
    }
    }
