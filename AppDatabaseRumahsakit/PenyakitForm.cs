﻿using System;
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
    public partial class PenyakitForm : Form
    {
        private static string connectionString = "server=localhost;port=3306;username=root;password=;database=rumah_sakit;";
        private MySqlConnection databaseConnection = new MySqlConnection(connectionString);

        public PenyakitForm()
        {
            InitializeComponent();
            if (Form1.status == 'u')
            {
                string select = "SELECT * FROM penyakit WHERE kode_penyakit=@kode";
                try
                {
                    databaseConnection.Open();
                    MySqlCommand slt = new MySqlCommand(select, databaseConnection);
                    slt.CommandTimeout = 60;
                    slt.Parameters.AddWithValue("@kode", Form1.id);
                    MySqlDataReader reader = slt.ExecuteReader();
                    while (reader.Read())
                    {
                        tbKode.Text = reader["kode_penyakit"].ToString();
                        tbNama.Text = reader["nama_penyakit"].ToString();
                        tbGol.Text = reader["golongan"].ToString();
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
                string query = "INSERT INTO penyakit (kode_penyakit, nama_penyakit, golongan) VALUES (@kode_penyakit, @nama_penyakit, @golongan)";

                try
                {
                    databaseConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                    cmd.CommandTimeout = 60;
                    cmd.Parameters.AddWithValue("@kode_penyakit", tbKode.Text);
                    cmd.Parameters.AddWithValue("@nama_penyakit", tbNama.Text);
                    cmd.Parameters.AddWithValue("@golongan", tbGol.Text);
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
                string query = "UPDATE penyakit SET nama_penyakit = @nama_penyakit, golongan = @golongan WHERE kode_penyakit = @kode_penyakit";

                try
                {
                    databaseConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                    cmd.CommandTimeout = 60;
                    cmd.Parameters.AddWithValue("@kode_penyakit", tbKode.Text);
                    cmd.Parameters.AddWithValue("@nama_penyakit", tbNama.Text);
                    cmd.Parameters.AddWithValue("@golongan", tbGol.Text);
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
