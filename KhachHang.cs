using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp3
{
    public partial class KhachHang : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BachVietERP"].ConnectionString;

        public KhachHang()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Customers";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (!dt.Columns.Contains("Phân loại"))
                    dt.Columns.Add("Phân loại", typeof(string));

                foreach (DataRow row in dt.Rows)
                {
                    DateTime ngayTao = Convert.ToDateTime(row["created_at"]);
                    int soNam = DateTime.Now.Year - ngayTao.Year;

                    if (ngayTao > DateTime.Now.AddYears(-soNam))
                        soNam--;

                    row["Phân loại"] = (soNam >= 10)
                        ? "Khách hàng lâu năm"
                        : "Khách hàng mới";
                }
                dataGridView1.DataSource = dt;
            }
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
            CbLoaiKH.Items.Clear();
            CbLoaiKH.Items.AddRange(new string[] { "CaNhan", "DoanhNghiep" });
            CbLoaiKH.SelectedIndex = 0;
            ngaymotaikhoan.Format = DateTimePickerFormat.Custom;
            ngaymotaikhoan.CustomFormat = "dd/MM/yyyy";

        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                    string.IsNullOrWhiteSpace(txtSDT.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                    CbLoaiKH.SelectedItem == null)
                {
                    MessageBox.Show("⚠️ Vui lòng nhập đầy đủ thông tin khách hàng!");
                    return; 
                }
                if (!txtEmail.Text.Contains("@"))
                {
                    MessageBox.Show("⚠️ Email không hợp lệ! Phải chứa ký tự '@'");
                    return;
                }
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string checkPhone = "SELECT COUNT(*) FROM Customers WHERE phone = @phone";
                    SqlCommand checkCmd = new SqlCommand(checkPhone, conn);
                    checkCmd.Parameters.AddWithValue("@phone", txtSDT.Text);

                    int exists = (int)checkCmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        MessageBox.Show("⚠️ Số điện thoại này đã tồn tại trong hệ thống!");
                        return;
                    }

                    string query = "INSERT INTO Customers (name, phone, email, address, type, created_at) " +
                                   "VALUES (@name, @phone, @email, @address, @type, @created_at)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@name", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@phone", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@address", txtDiaChi.Text);
                    cmd.Parameters.AddWithValue("@type", CbLoaiKH.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@created_at", ngaymotaikhoan.Value);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("✅ Thêm khách hàng thành công!");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi thêm: " + ex.Message);
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                    string.IsNullOrWhiteSpace(txtSDT.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                    CbLoaiKH.SelectedItem == null)
            {
                MessageBox.Show("⚠️ Vui lòng nhập đầy đủ thông tin khách hàng!");
                return;
            }

            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("⚠️ Email không hợp lệ! Phải chứa ký tự '@'");
                return;
            }

            if (dataGridView1.CurrentRow == null) return;
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string checkPhone = "SELECT COUNT(*) FROM Customers WHERE phone = @phone";
                SqlCommand checkCmd = new SqlCommand(checkPhone, conn);
                checkCmd.Parameters.AddWithValue("@phone", txtSDT.Text);

                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0)
                {
                    MessageBox.Show("⚠️ Số điện thoại này đã tồn tại trong hệ thống!");
                    return;
                }

                string query = @"UPDATE Customers 
                         SET name=@name, phone=@phone, email=@email, 
                             address=@address, type=@type, created_at=@created_at
                         WHERE customer_id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);  
                cmd.Parameters.AddWithValue("@name", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@phone", txtSDT.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@address", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@type", CbLoaiKH.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@created_at", ngaymotaikhoan.Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("✅ Sửa khách hàng thành công!");
                LoadData();
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);


            DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?",
                                                   "Xác nhận xóa",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Customers WHERE customer_id=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("🗑️ Xóa khách hàng thành công!");
                LoadData();
            }
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Customers WHERE name LIKE @name and customer_id LIKE @id";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@name", "%" + txtTenKH_TimKiem.Text + "%");
                da.SelectCommand.Parameters.AddWithValue("@id", "%" + txtMaKH_TimKiem.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);          
                dataGridView1.DataSource = dt;
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            ngaymotaikhoan.Value = DateTime.Now;
            if (CbLoaiKH.Items.Count > 0)
                CbLoaiKH.SelectedIndex = -1;
            LoadData();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                txtSDT.Text = row.Cells[2].Value.ToString();
                txtEmail.Text = row.Cells[3].Value.ToString();
                txtDiaChi.Text = row.Cells[4].Value.ToString();
                CbLoaiKH.Text = row.Cells[5].Value.ToString();
                if (row.Cells[6].Value != null && row.Cells[6].Value != DBNull.Value)
                {
                    ngaymotaikhoan.Value = Convert.ToDateTime(row.Cells[6].Value);
                }
            }
        }
    }
}
