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

namespace GasDustTest
{
    public partial class FormDBView : Form
    {
        public FormDBView()
        {
            InitializeComponent();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDBView_Load(object sender, EventArgs e)
        {
            dgTable.ColumnCount = 4;
            dgTable.Columns[0].HeaderText = "ID";
            dgTable.Columns[1].HeaderText = "Дата испытания";
            dgTable.Columns[2].HeaderText = "Содержание пыли";
            dgTable.Columns[3].HeaderText = "Согласованность";
            using (var conn = new SqliteConnection("Data source = dbGasDustTest.db"))
            {
                conn.Open();
                SqliteCommand query = new SqliteCommand($"SELECT * FROM DustTest", conn);
                var reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dgTable.Rows.Add();
                        for (int i = 0; i < 4; i++)
                        {
                            var value = reader.GetValue(i);
                            dgTable.Rows[dgTable.RowCount-1].Cells[i].Value = value;
                        }
                    }
                }
            }
        }
    }
}
