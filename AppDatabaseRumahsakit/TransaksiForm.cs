using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppDatabaseRumahsakit
{
    public partial class TransaksiForm : Form
    {
        private static string connectionString = "server=localhost;port=3306;username=root;password=;database=rumah_sakit;";
        private MySqlConnection databaseConnection = new MySqlConnection(connectionString);

        public TransaksiForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.status == 'c')
            {
                string query = "INSERT INTO transaksi (no_transaksi, id_pasien, id_dokter, kode_penyakit, biaya_perawatan) VALUES(@no_transaksi, @id_pasien, @id_dokter, @kode_penyakit, @biaya_perawatan)"; 


            try
                {
                    databaseConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                    cmd.CommandTimeout = 60;
                    cmd.Parameters.AddWithValue("@no_transaksi", textBox1.Text);
                    cmd.Parameters.AddWithValue("@id_pasien", textBox2.Text);
                    cmd.Parameters.AddWithValue("@id_dokter", textBox3.Text);
                    cmd.Parameters.AddWithValue("@kode_penyakit", textBox4.Text);
                    cmd.Parameters.AddWithValue("@biaya_perawatan", textBox5.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil ditambahkan");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    databaseConnection.Close();
                }
                this.Close();
            }
            else if (Form1.status == 'u')
            {
                string query = "UPDATE transaksi SET id_pasien = @id_pasien, id_dokter = @id_dokter, kode_penyakit = @kode_penyakit ,biaya_perawatan = @biaya_perawatan, WHERE no_transaksi = @no_transaksi";

                try
                {
                    databaseConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                    cmd.CommandTimeout = 60;
                    cmd.Parameters.AddWithValue("@no_transaksi", textBox1.Text);
                    cmd.Parameters.AddWithValue("@id_pasien", textBox2.Text);
                    cmd.Parameters.AddWithValue("@id_dokter", textBox3.Text);
                    cmd.Parameters.AddWithValue("@kode_penyakit", textBox4.Text);
                    cmd.Parameters.AddWithValue("@biaya_perawatan", textBox5.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil diupdate");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    databaseConnection.Close();
                }
                this.Close();
            }
        }
    }
}
