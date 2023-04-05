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
using System.Xml.Serialization;

namespace DataMahasiswa
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteData = new System.Windows.Forms.DataGridViewButtonColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mataPelajaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.btnDeleteData,
            this.edit,
            this.nip,
            this.nama,
            this.gender,
            this.mataPelajaran});
            this.dataGridView1.Location = new System.Drawing.Point(106, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 4;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(590, 277);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Mahasiswa";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInsert.Location = new System.Drawing.Point(598, 68);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(103, 36);
            this.buttonInsert.TabIndex = 2;
            this.buttonInsert.Text = "Tambah Data";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(106, 58);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(93, 33);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btnDeleteData.HeaderText = "Delete";
            this.btnDeleteData.MinimumWidth = 70;
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.ReadOnly = true;
            this.btnDeleteData.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDeleteData.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnDeleteData.Text = "Delete";
            this.btnDeleteData.UseColumnTextForButtonValue = true;
            this.btnDeleteData.Width = 70;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.edit.HeaderText = "Edit";
            this.edit.MinimumWidth = 70;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "Edit";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 70;
            // 
            // nip
            // 
            this.nip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nip.DataPropertyName = "nip";
            this.nip.FillWeight = 294.7369F;
            this.nip.HeaderText = "NIP";
            this.nip.MinimumWidth = 120;
            this.nip.Name = "nip";
            this.nip.ReadOnly = true;
            this.nip.Width = 120;
            // 
            // nama
            // 
            this.nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nama.DataPropertyName = "nama";
            this.nama.FillWeight = 21.92372F;
            this.nama.HeaderText = "Nama";
            this.nama.MinimumWidth = 100;
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.FillWeight = 30.39933F;
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // mataPelajaran
            // 
            this.mataPelajaran.DataPropertyName = "mataPelajaran";
            this.mataPelajaran.FillWeight = 52.94007F;
            this.mataPelajaran.HeaderText = "Mata Pelajaran";
            this.mataPelajaran.Name = "mataPelajaran";
            this.mataPelajaran.ReadOnly = true;
            // 
            // Home
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 458);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Mahasiswa";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        SqlConnection conn = new KoneksiDatabase().GetConnectionDBSekolah();

        private void TampilData()
        {


            string query = "SELECT * FROM tb_guru WHERE isDeleted='False'";

            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = table;

            conn.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            TampilData();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            new TambahData().Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                try
                {

                    bool ms = MessageBox.Show($"Apakah anda ingin menghapus data {dataGridView1.Rows[e.RowIndex].Cells["nama"].Value.ToString()}", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes;

                    if (ms)
                    {
                        string query = $"UPDATE tb_guru SET isDeleted = 1 WHERE nip = {dataGridView1.Rows[e.RowIndex].Cells["nip"].Value.ToString()}";

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
            else if (e.ColumnIndex == 2)
            {
                try
                {
                    string dataID = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                    new UpdateData(dataID).Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            TampilData();
        }
    }
}
