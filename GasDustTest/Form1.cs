using Microsoft.Data.Sqlite;
using System.Xml.Linq;

namespace GasDustTest
{
    public partial class Form1 : Form
    {
        private double m11;
        private double m21;
        private double m12;
        private double m22;
        private double V1;
        private double V2;

        public Form1()
        {
            InitializeComponent();
        }

        private void bCalculate_Click(object sender, EventArgs e)
        {
            if (m11 <= 0 || m12 <= 0 || m21 <= 0 || m22 <= 0)
            {
                lError.Text = "Заполните все поля массы";
                return;
            }
            if (V1 <= 0 || V2 <= 0)
            {
                lError.Text = "Заполните все поля объёма газа";
                return;
            }
            double dust1 = CalculateDust(m11, m21, V1);
            double dust2 = CalculateDust(m12, m22, V2);
            tbDust1.Text = dust1.ToString();
            tbDust2.Text = dust2.ToString();
            double cons = Math.Abs(dust1 - dust2);
            if (cons > 0.05)
            {
                lError.Text = "Результаты не согласуются";
                tbCons.BackColor = Color.LightPink;
            }
            else
            {
                lError.Text = "";
                tbCons.BackColor = SystemColors.Control;
            }
            tbCons.Text = cons.ToString();
            tbResult.Text = ((dust1 + dust2) / 2).ToString();
            bSaveFile.Enabled = true;
            bSaveDB.Enabled = true;
        }

        private double CalculateDust(double m1, double m2, double V)
        {
            return (m2 - m1) * 100 / V;
        }

        private void OnlyDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ',' && e.KeyChar != '.')
                e.Handled = true;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            string name = (sender as TextBox).Name;
            try
            {
                switch (name)
                {
                    case "tbm11": m11 = double.Parse(tbm11.Text); break;
                    case "tbm12": m12 = double.Parse(tbm12.Text); break;
                    case "tbm21": m21 = double.Parse(tbm21.Text); break;
                    case "tbm22": m22 = double.Parse(tbm22.Text); break;
                    case "tbV1": V1 = double.Parse(tbV1.Text); break;
                    case "tbV2": V2 = double.Parse(tbV2.Text); break;
                }
                lError.Text = "";
            }
            catch (FormatException ex)
            {
                switch (name)
                {
                    case "tbm11": m11 = 0; break;
                    case "tbm12": m12 = 0; break;
                    case "tbm21": m21 = 0; break;
                    case "tbm22": m22 = 0; break;
                    case "tbV1": V1 = 0; break;
                    case "tbV2": V2 = 0; break;
                }
                lError.Text = "Введите корректное число";
            }
        }

        private void bSaveFile_Click(object sender, EventArgs e)
        {            
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string consres = tbCons.BackColor == SystemColors.Control ? "Результаты согласованы" : "Результаты не согласуются";
                string text = $"Дата проведение: {DateTime.Now.ToString("dd.MM.yyyy")},\n Массовая доля смолы и пыли: {tbResult.Text},\n Согласованность результатов: {tbCons.Text},\n {consres}";
                File.WriteAllText(sfd.FileName, text);
            };
        }

        private void bSaveDB_Click(object sender, EventArgs e)
        {
            if (tbCons.BackColor != SystemColors.Control)
            {
                MessageBox.Show("Для вывода необходимо согласовать испытания");
                return;
            }
            using (var conn = new SqliteConnection("Data source = dbGasDustTest.db"))
            {
                conn.Open();
                SqliteCommand query = new SqliteCommand($"INSERT INTO DustTest (Date, Dust, Consistense)  VALUES (\"{DateTime.Now.ToString("dd.MM.yyyy")}\", {ReplacecComma(tbResult.Text)}, {ReplacecComma(tbCons.Text)})", conn);
                query.ExecuteNonQuery();
                MessageBox.Show("Данные успешно записсаны");
            }
        }

        private string ReplacecComma(string s)
        {
            if (tbResult.Text.IndexOf(",") == -1)
                return s;
            else return s.Replace(',', '.');
        }
    }
}
