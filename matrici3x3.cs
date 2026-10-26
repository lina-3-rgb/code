using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double Det3(double a1, double b1, double c1,
                    double a2, double b2, double c2,
                    double a3, double b3, double c3)
        {
            return a1 * (b2 * c3 - b3 * c2)
                 - b1 * (a2 * c3 - a3 * c2)
                 + c1 * (a2 * b3 - a3 * b2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a1 = Convert.ToDouble(textBox1.Text);
                double b1 = Convert.ToDouble(textBox2.Text);
                double c1 = Convert.ToDouble(textBox3.Text);
                double d1 = Convert.ToDouble(textBox4.Text);

                double a2 = Convert.ToDouble(textBox5.Text);
                double b2 = Convert.ToDouble(textBox6.Text);
                double c2 = Convert.ToDouble(textBox7.Text);
                double d2 = Convert.ToDouble(textBox8.Text);

                double a3 = Convert.ToDouble(textBox9.Text);
                double b3 = Convert.ToDouble(textBox10.Text);
                double c3 = Convert.ToDouble(textBox11.Text);
                double d3 = Convert.ToDouble(textBox12.Text);

                double det = Det3(a1, b1, c1,
                                  a2, b2, c2,
                                  a3, b3, c3);

                if (Math.Abs(det) < 1e-12)
                {
                    MessageBox.Show("Определитель равен нулю — система не имеет единственного решения.");
                    return;
                }

                double dx = Det3(d1, b1, c1,
                                 d2, b2, c2,
                                 d3, b3, c3);

                double dy = Det3(a1, d1, c1,
                                 a2, d2, c2,
                                 a3, d3, c3);

                double dz = Det3(a1, b1, d1,
                                 a2, b2, d2,
                                 a3, b3, d3);

                double x = dx / det;
                double y = dy / det;
                double z = dz / det;

                listBox1.Items.Clear();
                listBox2.Items.Clear();

                listBox1.Items.Add($"Δ  = {det}");
                listBox1.Items.Add($"Δx = {dx}");
                listBox1.Items.Add($"Δy = {dy}");
                listBox1.Items.Add($"Δz = {dz}");

                listBox2.Items.Add($"x = {x}");
                listBox2.Items.Add($"y = {y}");
                listBox2.Items.Add($"z = {z}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Проверьте ввод: все поля должны содержать числа.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}