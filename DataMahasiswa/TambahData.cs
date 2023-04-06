﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMahasiswa
{
    public partial class TambahData : Form
    {
        public TambahData()
        {
            InitializeComponent();
        }

        private void TambahData_Load(object sender, EventArgs e)
        {
            
        }

        SqlConnection conn = new KoneksiDatabase().GetConnectionDBSekolah();

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            bool checkRadioButton = true;
            char gender = '0';
            if (radioButtonL.Checked)
            {
                checkRadioButton = false;
                gender = 'L';
            }
            else if (radioButtonP.Checked)
            {
                checkRadioButton = false;
                gender = 'P';
            }

            if (textBoxNip.Text == "" || textBoxNama.Text == "" || textBoxGaji.Text == "" || checkRadioButton || textBoxMataPelajaran.Text == "")
            {
                MessageBox.Show("Data belum valid");
            }
            else
            {
                string query = $"INSERT INTO tb_guru VALUES ('{textBoxNip.Text}', '{textBoxNama.Text}', '{dateTimePickerTanggalLahir.Value}', '{gender}', '{textBoxMataPelajaran.Text}', '{textBoxGaji.Text}',  '0', '{DateTime.Now}', '{DateTime.Now}')";

                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    if (MessageBox.Show("Data berhasil ditambahkan!", "Succes") == DialogResult.OK) reset();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void reset()
        {
            textBoxNip.Text = "";
            textBoxNama.Text = "";
            textBoxGaji.Text = "";
            textBoxMataPelajaran.Text = "";

            Panel genderOptions = this.Controls.Find("panel2", true).FirstOrDefault() as Panel;

            foreach (Control ctrl in genderOptions.Controls) if(ctrl is RadioButton) ((RadioButton)ctrl).Checked = false;

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
