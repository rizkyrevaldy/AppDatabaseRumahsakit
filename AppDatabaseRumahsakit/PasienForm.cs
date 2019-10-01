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
    public partial class PasienForm : Form
    {
        private static string connectionString = "server=localhost;port=3306;username=root;password=;database=rumah_sakit;";
        private MySqlConnection databaseConnection = new MySqlConnection(connectionString);

        public PasienForm()
        {
            InitializeComponent();
            if (Form1.status == 'u')
            {
                string select = "SELECT * FROM pasien WHERE id=@id";
                try
                {
                    databaseConnection.Open();
                    MySqlCommand slt = new MySqlCommand(select, databaseConnection);
                    slt.CommandTimeout = 60;
                    slt.Parameters.AddWithValue("@id", Form1.id);
                    MySqlDataReader reader = slt.ExecuteReader();
                    while (reader.Read())
                    {
                        tbNama.Text = reader["nama_pasien"].ToString();
                        cbJK.SelectedItem = reader["jenis_kelamin"].ToString();
                        tbAlamat.Text = reader["alamat"].ToString();
                        tbTelp.Text = reader["no_telp"].ToString();
                        tbUmur.Text = reader["umur"].ToString();
                        tbBB.Text = reader["berat_badan"].ToString();
                        tbTB.Text = reader["tinggi_badan"].ToString();
                        cbGD.SelectedItem = reader["golongan_darah"].ToString();
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
                string query = "INSERT INTO pasien (nama_pasien, jenis_kelamin, alamat, no_telp, umur, berat_badan, tinggi_badan, golongan_darah) VALUES(@nama, @jenis_kelamin, @alamat, @no_telp, @umur, @berat_badan, @tinggi_badan, @golongan_darah)"; 


            try
                {
                    databaseConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                    cmd.CommandTimeout = 60;
                    cmd.Parameters.AddWithValue("@nama", tbNama.Text);
                    cmd.Parameters.AddWithValue("@jenis_kelamin", cbJK.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@alamat", tbAlamat.Text);
                    cmd.Parameters.AddWithValue("@no_telp", tbTelp.Text);
                    cmd.Parameters.AddWithValue("@umur", tbUmur.Text);
                    cmd.Parameters.AddWithValue("@berat_badan", tbBB.Text);
                    cmd.Parameters.AddWithValue("@tinggi_badan", tbTB.Text);
                    cmd.Parameters.AddWithValue("@golongan_darah", cbGD.SelectedItem.ToString());
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
                try
                {
                    databaseConnection.Open();
                    string query = "UPDATE pasien SET nama_pasien = @nama, jenis_kelamin = @jenis_kelamin, alamat = @alamat, no_telp = @no_telp, umur = @umur, berat_badan = @berat_badan, tinggi_badan = @tinggi_badan, golongan_darah = @golongan_darah  WHERE ID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                    cmd.CommandTimeout = 60;
                    cmd.Parameters.AddWithValue("@id", Form1.id);
                    cmd.Parameters.AddWithValue("@nama", tbNama.Text);
                    cmd.Parameters.AddWithValue("@jenis_kelamin", cbJK.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@alamat", tbAlamat.Text);
                    cmd.Parameters.AddWithValue("@no_telp", tbTelp.Text);
                    cmd.Parameters.AddWithValue("@umur", tbUmur.Text);
                    cmd.Parameters.AddWithValue("@berat_badan", tbBB.Text);
                    cmd.Parameters.AddWithValue("@tinggi_badan", tbTB.Text);
                    cmd.Parameters.AddWithValue("@golongan_darah", cbGD.SelectedItem.ToString());
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
