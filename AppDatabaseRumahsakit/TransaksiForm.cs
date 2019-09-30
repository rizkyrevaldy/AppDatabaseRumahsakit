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
            if (Form1.status == 'c')
            {
                string select = "SELECT nama_penyakit FROM penyakit";
                string select2 = "SELECT ID FROM pasien";
                string select3 = "SELECT NIP FROM dokter";

                try
                {
                    databaseConnection.Open();
                    MySqlCommand slt = new MySqlCommand(select, databaseConnection);
                    slt.CommandTimeout = 60;
                    MySqlCommand slt2 = new MySqlCommand(select2, databaseConnection);
                    slt2.CommandTimeout = 60;
                    MySqlCommand slt3 = new MySqlCommand(select3, databaseConnection);
                    slt3.CommandTimeout = 60;
                    MySqlDataReader reader = slt.ExecuteReader();
                    while (reader.Read())
                    {
                        cbKode.Items.Add(reader["nama_penyakit"].ToString());
                    }
                    reader.Close();
                    reader = slt2.ExecuteReader();
                    while (reader.Read())
                    {
                        cbPasien.Items.Add(reader["ID"].ToString());
                    }
                    reader.Close();
                    reader = slt3.ExecuteReader();
                    while (reader.Read())
                    {
                        cbDokter.Items.Add(reader["NIP"].ToString());
                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    databaseConnection.Close();
                }
            }
            else if (Form1.status == 'u')
            {
                string select = "SELECT * FROM transaksi WHERE no_transaksi=@no";
                try
                {
                    databaseConnection.Open();
                    MySqlCommand slt = new MySqlCommand(select, databaseConnection);
                    slt.CommandTimeout = 60;
                    slt.Parameters.AddWithValue("@no", Form1.id);
                    MySqlDataReader reader = slt.ExecuteReader();
                    while (reader.Read())
                    {
                        cbPasien.SelectedItem = reader["id_pasien"].ToString();
                        cbDokter.SelectedItem = reader["nip_dokter"].ToString();
                        cbKode.SelectedItem = reader["kode_penyakit"].ToString();
                        tbBiaya.Text = reader["biaya_perawatan"].ToString();
                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    databaseConnection.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.status == 'c')
            {
                string query = "INSERT INTO transaksi (id_pasien, nip_dokter, kode_penyakit, biaya_perawatan) VALUES(@id_pasien, @nip_dokter, @kode_penyakit, @biaya_perawatan)"; 


            try
                {
                    databaseConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                    cmd.CommandTimeout = 60;
                    cmd.Parameters.AddWithValue("@id_pasien", cbPasien.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@nip_dokter", cbDokter.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@kode_penyakit", cbKode.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@biaya_perawatan", tbBiaya.Text);
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
                string query = "UPDATE transaksi SET id_pasien = @id_pasien, nip_dokter = @nip_dokter, kode_penyakit = @kode_penyakit ,biaya_perawatan = @biaya_perawatan, WHERE no_transaksi = @no_transaksi";

                try
                {
                    databaseConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                    cmd.CommandTimeout = 60;
                    cmd.Parameters.AddWithValue("@no_transaksi", Form1.id);
                    cmd.Parameters.AddWithValue("@id_pasien", cbPasien.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@nip_dokter", cbDokter.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@kode_penyakit", cbKode.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@biaya_perawatan", tbBiaya.Text);
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
