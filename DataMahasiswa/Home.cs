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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDeleteData = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mataPelajaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gaji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.labelTotalData = new System.Windows.Forms.Label();
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
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edit,
            this.btnDeleteData,
            this.id,
            this.nip,
            this.nama,
            this.gender,
            this.mataPelajaran,
            this.gaji});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(108, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 4;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(595, 277);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.edit.Frozen = true;
            this.edit.HeaderText = "Edit";
            this.edit.MinimumWidth = 70;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "Edit";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 70;
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btnDeleteData.Frozen = true;
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
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nip
            // 
            this.nip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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
            this.nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama.DataPropertyName = "nama";
            this.nama.FillWeight = 21.92372F;
            this.nama.HeaderText = "Nama";
            this.nama.MinimumWidth = 100;
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gender.DataPropertyName = "gender";
            this.gender.FillWeight = 30.39933F;
            this.gender.HeaderText = "Gender";
            this.gender.MinimumWidth = 100;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // mataPelajaran
            // 
            this.mataPelajaran.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mataPelajaran.DataPropertyName = "mataPelajaran";
            this.mataPelajaran.FillWeight = 52.94007F;
            this.mataPelajaran.HeaderText = "Mata Pelajaran";
            this.mataPelajaran.MinimumWidth = 120;
            this.mataPelajaran.Name = "mataPelajaran";
            this.mataPelajaran.ReadOnly = true;
            // 
            // gaji
            // 
            this.gaji.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gaji.DataPropertyName = "gaji";
            this.gaji.HeaderText = "Gaji";
            this.gaji.MinimumWidth = 100;
            this.gaji.Name = "gaji";
            this.gaji.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(100, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Guru";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonInsert.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsert.Location = new System.Drawing.Point(600, 64);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(103, 36);
            this.buttonInsert.TabIndex = 2;
            this.buttonInsert.Text = "Tambah Data";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonRestore
            // 
            this.buttonRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRestore.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestore.Location = new System.Drawing.Point(600, 405);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(103, 36);
            this.buttonRestore.TabIndex = 4;
            this.buttonRestore.Text = "Restore Data";
            this.buttonRestore.UseVisualStyleBackColor = false;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // labelTotalData
            // 
            this.labelTotalData.AutoSize = true;
            this.labelTotalData.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelTotalData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTotalData.Location = new System.Drawing.Point(104, 64);
            this.labelTotalData.Name = "labelTotalData";
            this.labelTotalData.Size = new System.Drawing.Size(79, 19);
            this.labelTotalData.TabIndex = 6;
            this.labelTotalData.Text = "Total: NULL";
            // 
            // Home
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(802, 458);
            this.Controls.Add(this.labelTotalData);
            this.Controls.Add(this.buttonRestore);
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

            string query = "EXEC TampilData";

            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = table;

            conn.Close();

            try
            {
                conn.Open();
                query = "SELECT totalGuru FROM tb_total";
                cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read()) labelTotalData.Text = $"Total: {dr["totalGuru"].ToString()}";
            }
            catch (Exception)
            {
                labelTotalData.Text = "Total: Err";
            }
            finally
            {
                conn.Close();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            TampilData();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            new TambahData().ShowDialog();
            TampilData();
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
                        string query = $"UPDATE tb_guru SET isDeleted = '1', updatedAt = '{DateTime.Now}' WHERE id = {dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString()}";

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
            else if (e.ColumnIndex == 0)
            {
                try
                {
                    string dataID = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                    new UpdateData(dataID).ShowDialog();
                    TampilData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            new RestoreData().ShowDialog();
            TampilData();
        }
    }
}
