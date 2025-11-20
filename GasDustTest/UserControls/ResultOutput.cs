using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GasDustTest.UserControls
{
    public partial class ResultOutput : UserControl
    {
        public decimal dust1, dust2;

        public ResultOutput()
        {
            InitializeComponent();
        }

        public decimal CalculateDust(decimal m1, decimal m2, decimal V)
        {
            if (V == 0) return 0;
            return (m2 - m1) * 100 / V;
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

        private void ResultOutput_Load(object sender, EventArgs e)
        {
            tbDust1.Text = dust1.ToString();
            tbDust2.Text = dust2.ToString();
            decimal cons = Math.Abs(dust1 - dust2);
            if (cons > (decimal)0.05)
                tbCons.BackColor = Color.LightPink;
            else tbCons.BackColor = SystemColors.Control;
            tbCons.Text = cons.ToString();
            tbResult.Text = ((dust1 + dust2) / 2).ToString();
        }
    }
}
