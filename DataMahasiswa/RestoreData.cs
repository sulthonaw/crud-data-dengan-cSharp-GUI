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
    public partial class RestoreData : Form
    {
        public RestoreData()
        {
            InitializeComponent();
        }

        SqlConnection conn = new KoneksiDatabase().GetConnectionDBSekolah();

        private void TampilData()
        {
            string query = "SELECT * FROM tb_guru WHERE isDeleted='True'";

            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = table;

            conn.Close();
        }

        private void RestoreData_Load(object sender, EventArgs e)
        {
            TampilData();
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"Apakah anda ingin menghapus data?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query = $"DELETE FROM tb_guru WHERE idDeleted='True';";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    TampilData();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tidak bisa didelete.", "Alert");
            }
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"Apakah anda ingin merestore data?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query = $"UPDATE tb_guru SET isDeleted = '0', updatedAt = '{DateTime.Now}' WHERE isDeleted=1 AND NOT nip IN (SELECT nip FROM tb_guru WHERE isDeleted=0)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    int dataPertama = dataGridView1.Rows.Count;
                    int dataKedua = 0;

                    conn.Open();
                    cmd.ExecuteScalar();

                    query = "SELECT COUNT(*) AS total FROM tb_guru WHERE isDeleted = 1";

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) dataKedua = (int)dr["total"];

                    int dataYangDikembalikan = dataPertama - dataKedua;

                    if (dataYangDikembalikan == 0 && dataGridView1.Rows.Count == 0)
                    {
                        MessageBox.Show("Tidak ada data yang dikembalikan", "Alert");
                    }
                    else if (dataYangDikembalikan > 0)
                    {
                        MessageBox.Show($"Berhasil: {dataYangDikembalikan}\nGagal: {dataGridView1.Rows.Count - dataYangDikembalikan}", "Info");
                    }
                    else if (dataGridView1.Rows.Count > 0 && dataYangDikembalikan == 0)
                    {
                        MessageBox.Show("Data tidak bisa dikembalikan", "Alert");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                conn.Close();
                TampilData();
            }
        }
    }
}
