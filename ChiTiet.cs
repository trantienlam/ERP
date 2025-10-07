using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class ChiTiet : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BachVietERP"].ConnectionString;

        public int OrderId { get; set; }
        public DateTime DeliveryDate { get; set; }

        public ChiTiet()
        {
            InitializeComponent();
        }

        private void ChiTiet_Load(object sender, EventArgs e)
        {
            LoadOrderItems();
        }

        private void LoadOrderItems()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        quantity AS [Số Lượng],
                        description AS [Mô tả],
                        shipper_info AS [Thông tin người giao hàng],
                        NULLIF(unit_price, 0) AS [Giá],
                        CASE 
                        WHEN unit_price IS NULL OR quantity IS NULL OR unit_price = 0 THEN NULL 
                        ELSE quantity * unit_price 
                        END AS [Tổng giá],
                        estimated_delivery_time AS [Thời gian giao hàng dự kiến]
                    FROM Order_Details
                    WHERE order_detail_id = @orderId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@orderId", OrderId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValid = true;
                string errorMsg = "";

                // 1️⃣ Kiểm tra rỗng (Trim để loại bỏ khoảng trắng, xuống dòng)
                if (string.IsNullOrWhiteSpace(txtSoLuong.Text.Trim()))
                {
                    isValid = false;
                    errorMsg = "❌ Số lượng không được để trống!";
                }
                else if (string.IsNullOrWhiteSpace(txtGia.Text.Trim()))
                {
                    isValid = false;
                    errorMsg = "❌ Giá không được để trống!";
                }
                else if (string.IsNullOrWhiteSpace(txtMoTa.Text.Trim()))
                {
                    isValid = false;
                    errorMsg = "❌ Mô tả không được để trống!";
                }
                else if (string.IsNullOrWhiteSpace(txtShipper.Text.Trim()))
                {
                    isValid = false;
                    errorMsg = "❌ Tên người giao hàng không được để trống!";
                }

                // ❗Nếu có lỗi rỗng thì dừng luôn
                if (!isValid)
                {
                    MessageBox.Show(errorMsg, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2️⃣ Kiểm tra định dạng số lượng
                if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong))
                {
                    MessageBox.Show("❌ Số lượng phải là số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3️⃣ Kiểm tra định dạng giá
                if (!decimal.TryParse(txtGia.Text.Trim(), out decimal gia))
                {
                    MessageBox.Show("❌ Giá phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 4️⃣ Kiểm tra ngày nhận hàng
                if (ngaynhanhang.Value <= DeliveryDate)
                {
                    MessageBox.Show($"❌ Ngày nhận hàng phải sau ngày giao hàng ({DeliveryDate:dd/MM/yyyy})!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ✅ Nếu qua hết kiểm tra thì cập nhật DB
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                UPDATE Order_Details 
                SET unit_price = @unit_price,
                    quantity = @quantity,
                    description = @description,                           
                    shipper_info = @shipper_info,
                    estimated_delivery_time = @estimated_delivery_time
                WHERE order_detail_id = @orderId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@unit_price", gia);
                        cmd.Parameters.AddWithValue("@quantity", soLuong);
                        cmd.Parameters.AddWithValue("@description", txtMoTa.Text.Trim());
                        cmd.Parameters.AddWithValue("@shipper_info", txtShipper.Text.Trim());
                        cmd.Parameters.AddWithValue("@estimated_delivery_time", ngaynhanhang.Value);
                        cmd.Parameters.AddWithValue("@orderId", OrderId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadOrderItems();
                MessageBox.Show("✅ Đã cập nhật chi tiết đơn hàng!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirm = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa chi tiết đơn hàng này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.No)
                    return;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Order_Details WHERE order_detail_id = @orderId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@orderId", OrderId);
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                            MessageBox.Show("🗑️ Đã xóa chi tiết đơn hàng thành công!");
                        else
                            MessageBox.Show("⚠️ Không tìm thấy bản ghi để xóa!");
                    }
                }
                LoadOrderItems();
                txtSoLuong.Clear();
                txtGia.Clear();
                txtMoTa.Clear();
                txtTongTien.Clear();
                txtShipper.Clear();
                ngaynhanhang.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtSoLuong.Text = row.Cells[0].Value?.ToString();
                txtMoTa.Text = row.Cells[1].Value?.ToString();      // Mã khách
                txtShipper.Text = row.Cells[2].Value?.ToString();     // Tên sản phẩm
                txtGia.Text = row.Cells[3].Value?.ToString();     // Tên sản phẩm
                txtTongTien.Text = row.Cells[4].Value?.ToString();     // Tên sản phẩm
                ngaynhanhang.Value = Convert.ToDateTime(row.Cells[5].Value);
            }
        }
    }
}
