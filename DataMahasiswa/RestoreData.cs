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
                    string query = $"UPDATE tb_guru SET isDeleted = 0  WHERE isDeleted=1 AND NOT nip IN (SELECT nip FROM tb_guru WHERE isDeleted=0)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    int dataYangDikembalikan = cmd.ExecuteNonQuery() - 1;

                    MessageBox.Show($"Berhasil: {dataYangDikembalikan}\nGagal: {dataGridView1.Rows.Count - dataYangDikembalikan}", "Info");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tidak bisa direstore. and {ex.Message}", "Alert");
            } finally
            {
                conn.Close();
                TampilData();
            }
        }
    }
}
