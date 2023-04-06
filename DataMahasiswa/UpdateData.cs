using System;
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
    public partial class UpdateData : Form
    {
        private int _idData;

        public UpdateData(string id)
        {
            InitializeComponent();

            _idData = Convert.ToInt32(id);

            try
            {
                string query = $"SELECT * FROM tb_guru WHERE id={id}";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader readData = cmd.ExecuteReader();
                if (readData.Read())
                {
                    textBoxNip.Text = readData["nip"].ToString();
                    textBoxNama.Text = readData["nama"].ToString();
                    dateTimePickerTanggalLahir.Value = (DateTime)readData["tanggalLahir"];
                    if (readData["gender"].ToString() == "L") radioButtonL.Checked = true;
                    else if (readData["gender"].ToString() == "P") radioButtonL.Checked = true;
                    textBoxMataPelajaran.Text = readData["mataPelajaran"].ToString();
                    textBoxGaji.Text = readData["gaji"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                conn.Close();
            }


        }

        SqlConnection conn = new KoneksiDatabase().GetConnectionDBSekolah();

        private void UpdateData_Load(object sender, EventArgs e)
        {

        }

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
                string query = $"UPDATE tb_guru SET nip='{textBoxNip.Text}', nama='{textBoxNama.Text}', tanggalLahir='{dateTimePickerTanggalLahir.Value}', gender='{gender}', mataPelajaran='{textBoxMataPelajaran.Text}', gaji='{textBoxGaji.Text}', updatedAt='{DateTime.Now}' WHERE id={_idData}";

                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    if (MessageBox.Show("Data berhasil diupdate!", "Succes") == DialogResult.OK)
                    {
                        reset();
                        this.Close();
                    }
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

            foreach (Control ctrl in genderOptions.Controls) if (ctrl is RadioButton) ((RadioButton)ctrl).Checked = false;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void UpdateData_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin keluar dari form update", "Alert", MessageBoxButtons.YesNo) == DialogResult.No) e.Cancel = true;
        }
    }
}
