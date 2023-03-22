using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace ZagajaLukasz_DB
{
    public partial class Form1 : Form
    {
        bool Wyswietlanie = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void WyswietlButton_Click(object sender, EventArgs e)
        {
            if (Wyswietlanie)
            {
                dataGridView1.Rows.Clear();
            }
            else
            {
                string imie = "";// imie;
                string nazwisko = "";//nazwisko;
                int ocena = 0;//ocena;

                try
                {
                    mySqlConnection1.Open();
                    MySqlDataReader reader = mySqlCommand1.ExecuteReader();

                    while (reader.Read())
                    {
                        imie = reader.GetString(0);
                        nazwisko = reader.GetString(1);
                        ocena = reader.GetInt32(2);
                        dataGridView1.Rows.Add(imie, nazwisko, ocena);
                    }

                    mySqlConnection1.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Wyswietlanie = !Wyswietlanie;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
