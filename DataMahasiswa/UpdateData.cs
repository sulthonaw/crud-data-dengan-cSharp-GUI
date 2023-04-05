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
        public UpdateData(string id)
        {
            InitializeComponent();

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
            }


        }

        SqlConnection conn = new KoneksiDatabase().GetConnectionDBSekolah();

        private void UpdateData_Load(object sender, EventArgs e)
        {

        }
    }
}
