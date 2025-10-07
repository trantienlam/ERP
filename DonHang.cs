using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class DonHang : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BachVietERP"].ConnectionString;

        public DonHang()
        {
            InitializeComponent();
        }

        private void DonHang_Load(object sender, EventArgs e)
        {
            LoadOrders();

            cbTrangThai.Items.Clear();
            cbTrangThai.Items.AddRange(new string[] { "Chờ xử lí", "Chờ lấy hàng", "Đang vận chuyển" });
            cbTrangThai.SelectedIndex = 0;

            ngaydathang.CustomFormat = "dd/MM/yyyy";
        }

        private void LoadOrders()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        o.order_detail_id AS [Mã Đơn Hàng],
                        o.customer_id AS [Mã Khách],
                        c.name AS [Tên Khách Hàng],
                        o.product_name AS [Tên Sản Phẩm],
                        o.status AS [Trạng Thái],
                        o.order_date AS [Ngày Đặt],
                        o.delivery_address AS [Địa Chỉ Giao],
                        o.customer_note AS [Ghi Chú]
                    FROM Order_Details o
                    JOIN Customers c ON o.customer_id = c.customer_id";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        // Hàm kiểm tra dữ liệu nhập
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text) ||
                string.IsNullOrWhiteSpace(txtTenSP.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtGhiChu.Text))
            {
                MessageBox.Show("❌ Không được để trống bất kỳ trường nào (trừ Mã đơn hàng)!",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtMaKH.Text, out _))
            {
                MessageBox.Show("⚠️ Mã khách hàng phải là số!",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbTrangThai.SelectedItem == null)
            {
                MessageBox.Show("⚠️ Vui lòng chọn trạng thái đơn hàng!",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                    return;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    int customerId = int.Parse(txtMaKH.Text);
                    string productName = txtTenSP.Text;
                    string note = txtGhiChu.Text;
                    string status = cbTrangThai.SelectedItem.ToString();
                    string address = txtDiaChi.Text;

                    // Kiểm tra khách hàng có tồn tại
                    string checkCustomer = "SELECT COUNT(*) FROM Customers WHERE customer_id = @customer_id";
                    using (SqlCommand cmdCheck = new SqlCommand(checkCustomer, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@customer_id", customerId);
                        int exists = (int)cmdCheck.ExecuteScalar();
                        if (exists == 0)
                        {
                            MessageBox.Show("Không tìm thấy khách hàng có ID này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Thêm đơn hàng mới
                    string query = @"INSERT INTO Order_Details 
                                    (customer_id, order_date, status, delivery_address, product_name, customer_note)
                                     VALUES (@customer_id, @order_date, @status, @address, @product_name, @customer_note)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@customer_id", customerId);
                        cmd.Parameters.AddWithValue("@order_date", DateTime.Now);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@product_name", productName);
                        cmd.Parameters.AddWithValue("@customer_note", note);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("✅ Thêm đơn hàng thành công!");
                    LoadOrders();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                    return;
                if (dataGridView1.Tag == null)
                {
                    MessageBox.Show("Vui lòng chọn đơn hàng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int orderId = (int)dataGridView1.Tag; // lấy ID đơn hàng
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    int customerId = int.Parse(txtMaKH.Text);
                    string productName = txtTenSP.Text;
                    string note = txtGhiChu.Text;
                    string status = cbTrangThai.SelectedItem.ToString();
                    string address = txtDiaChi.Text;

                    string query = @"
                        UPDATE Order_Details
                        SET customer_id = @customer_id,
                            order_date = @order_date,
                            status = @status,
                            delivery_address = @address,
                            product_name = @product_name,
                            customer_note = @customer_note
                        WHERE order_detail_id = @order_detail_id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@customer_id", customerId);
                        cmd.Parameters.AddWithValue("@order_date", DateTime.Now);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@product_name", productName);
                        cmd.Parameters.AddWithValue("@customer_note", note);
                        cmd.Parameters.AddWithValue("@order_detail_id", orderId);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                            MessageBox.Show("✅ Cập nhật đơn hàng thành công!");
                        else
                            MessageBox.Show("⚠️ Không có đơn hàng nào được cập nhật!");
                    }

                    LoadOrders();
                }
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
                dataGridView1.Tag = Convert.ToInt32(row.Cells[0].Value);
                MaDH.Text = row.Cells[0].Value?.ToString();
                txtMaKH.Text = row.Cells[1].Value?.ToString();      // Mã khách
                txtTenSP.Text = row.Cells[3].Value?.ToString();     // Tên sản phẩm
                cbTrangThai.Text = row.Cells[4].Value?.ToString();  // Trạng thái
                ngaydathang.Value = Convert.ToDateTime(row.Cells[5].Value);
                txtDiaChi.Text = row.Cells[6].Value?.ToString();    // Địa chỉ
                txtGhiChu.Text = row.Cells[7].Value?.ToString();    // Ghi chú
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Tag == null)
                {
                    MessageBox.Show("⚠️ Vui lòng chọn đơn hàng cần xóa!");
                    return;
                }

                int orderId = (int)dataGridView1.Tag;

                DialogResult confirm = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa đơn hàng này không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.No)
                    return;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "DELETE FROM Order_Details WHERE order_detail_id = @order_detail_id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@order_detail_id", orderId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("🗑️ Xóa đơn hàng thành công!");
                    LoadOrders();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi: " + ex.Message);
            }
        }
        private void ClearFields()
        {
            txtMaKH.Clear();
            txtTenSP.Clear();
            txtGhiChu.Clear();
            txtDiaChi.Clear();
            cbTrangThai.SelectedIndex = 0;
            ngaydathang.Value = DateTime.Now;
            dataGridView1.Tag = null;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string madonhang = txtMaDH.Text.Trim();
            string hoten = txtHoTen.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT 
            o.order_detail_id AS [Mã Đơn Hàng],
            o.customer_id AS [Mã Khách],
            c.name AS [Tên Khách Hàng],
            o.product_name AS [Tên Sản Phẩm],
            o.status AS [Trạng Thái],
            o.order_date AS [Ngày Đặt],
            o.delivery_address AS [Địa Chỉ Giao],
            o.customer_note AS [Ghi Chú]
        FROM Order_Details o
        JOIN Customers c ON o.customer_id = c.customer_id
        WHERE 
            (@madonhang = '' OR o.order_detail_id = @madonhang)
            AND (@hoten = '' OR c.name LIKE '%' + @hoten + '%')";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@madonhang", madonhang);
                    cmd.Parameters.AddWithValue("@hoten", hoten);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy đơn hàng nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            MaDH.Clear();
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtTenSP.Clear();
            txtDiaChi.Clear();
            txtGhiChu.Clear();
            txtDiaChi.Clear();
            ngaydathang.Value = DateTime.Now;
            if (cbTrangThai.Items.Count > 0)
                cbTrangThai.SelectedIndex = -1;
            LoadOrders();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {     
            if (dataGridView1.CurrentRow != null)
            {
                // Lấy customer_id từ dòng đang chọn
                int orderId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Mã Đơn Hàng"].Value);
                DateTime deliveryDate = DateTime.MinValue;

                if (dataGridView1.CurrentRow.Cells["Ngày Đặt"].Value != DBNull.Value)
                {
                    deliveryDate = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Ngày Đặt"].Value);
                }
                // Mở form chi tiết và truyền customerId sang
                ChiTiet frmChiTiet = new ChiTiet();
                frmChiTiet.OrderId = orderId;
                frmChiTiet.DeliveryDate = deliveryDate;
                frmChiTiet.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một đơn hàng để xem chi tiết!");
            }
        }
    }
}
