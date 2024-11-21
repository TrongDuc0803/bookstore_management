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

namespace bookstore_management
{
    public partial class MainForm : Form
    {
        private string connectionString = "Data Source=Teomathe;Initial Catalog=db_quan_ly_ban_sach;Integrated Security=True";

        public MainForm()
        {
            InitializeComponent();
            LoadLoaiSach(); // Gọi hàm load loại sách vào ComboBox
            LoadSachGrid(); // Gọi hàm load dữ liệu sách vào DataGridView
            LoadLoaiSachGrid(); // Gọi hàm load dữ liệu loại sách vào DataGridView
            LoadHoaDonGrid();
        }

        private void LoadSachGrid()
        {
            string query = "SELECT s.ma_sach, s.ten_sach, l.ten_loai_sach, s.tac_gia, s.so_luong, s.gia_ban FROM tbl_sach s JOIN tbl_loai_sach l ON s.ma_loai_sach = l.ma_loai_sach";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgSach.DataSource = dt;

                // Đổi tên hiển thị các cột
                dgSach.Columns["ma_sach"].HeaderText = "Mã sách";
                dgSach.Columns["ten_sach"].HeaderText = "Tên sách";
                dgSach.Columns["ten_loai_sach"].HeaderText = "Loại sách";
                dgSach.Columns["tac_gia"].HeaderText = "Tác giả";
                dgSach.Columns["so_luong"].HeaderText = "Số lượng";
                dgSach.Columns["gia_ban"].HeaderText = "Giá bán";
            }
        }

        private void LoadLoaiSach()
        {
            string query = "SELECT ma_loai_sach, ten_loai_sach FROM tbl_loai_sach";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0) // Kiểm tra nếu có dữ liệu
                {
                    cbSachLoaiSach.DataSource = dt;
                    cbSachLoaiSach.DisplayMember = "ten_loai_sach";
                    cbSachLoaiSach.ValueMember = "ma_loai_sach";
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu loại sách.", "Thông báo");
                }
            }
        }

        private void LoadLoaiSachGrid()
        {
            string query = "SELECT ma_loai_sach AS [Mã loại sách], ten_loai_sach AS [Tên loại sách] FROM tbl_loai_sach";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgLoaiSach.DataSource = dt;
            }
        }

        private void LoadHoaDonGrid()
        {
            string query = "SELECT ma_hoa_don AS [Mã Hóa Đơn], ngay_lap AS [Ngày Lập], ten_khach_hang AS [Tên Khách Hàng], sdt_khach_hang AS [SDT Khách Hàng]FROM tbl_hoa_don";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgHoaDon.DataSource = dt;
            }
        }


        private void btnSachThem_Click(object sender, EventArgs e)
        {
            string tenSach = txtSachTenSach.Text.Trim();
            string tacGia = txtSachTacGia.Text.Trim();
            int soLuong;
            decimal giaBan;

            if (string.IsNullOrEmpty(tenSach) ||
                !int.TryParse(numSachSoLuong.Text, out soLuong) ||
                !decimal.TryParse(numSachGiaBan.Text, out giaBan) ||
                cbSachLoaiSach.SelectedValue == null ||
                soLuong <= 0 || giaBan <= 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và hợp lệ thông tin sách.", "Thông báo");
                return;
            }

            int maLoaiSach = int.Parse(cbSachLoaiSach.SelectedValue.ToString());

            string query = "INSERT INTO tbl_sach (ten_sach, ma_loai_sach, tac_gia, so_luong, gia_ban) VALUES (@tenSach, @maLoaiSach, @tacGia, @soLuong, @giaBan)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@tenSach", tenSach);
                command.Parameters.AddWithValue("@maLoaiSach", maLoaiSach);
                command.Parameters.AddWithValue("@tacGia", tacGia);
                command.Parameters.AddWithValue("@soLuong", soLuong);
                command.Parameters.AddWithValue("@giaBan", giaBan);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Thêm sách thành công!", "Thông báo");
                LoadSachGrid();
            }
        }

        private void btnLoaiSachThem_Click(object sender, EventArgs e)
        {
            string tenLoaiSach = txtLoaiSachTenLoaiSach.Text.Trim();

            if (string.IsNullOrEmpty(tenLoaiSach))
            {
                MessageBox.Show("Vui lòng nhập tên loại sách.", "Thông báo");
                return;
            }

            string query = "INSERT INTO tbl_loai_sach (ten_loai_sach) VALUES (@tenLoaiSach)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@tenLoaiSach", tenLoaiSach);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Thêm loại sách thành công!", "Thông báo");
                LoadLoaiSachGrid();
                LoadLoaiSach();
            }
        }

        private void btnLoaiSachSua_Click(object sender, EventArgs e)
        {
            if (dgLoaiSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn loại sách cần sửa.", "Thông báo");
                return;
            }

            int maLoaiSach = int.Parse(dgLoaiSach.CurrentRow.Cells["Mã loại sách"].Value.ToString());
            string tenLoaiSach = txtLoaiSachTenLoaiSach.Text.Trim();

            if (string.IsNullOrEmpty(tenLoaiSach))
            {
                MessageBox.Show("Vui lòng nhập tên loại sách.", "Thông báo");
                return;
            }

            string query = "UPDATE tbl_loai_sach SET ten_loai_sach = @tenLoaiSach WHERE ma_loai_sach = @maLoaiSach";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@tenLoaiSach", tenLoaiSach);
                command.Parameters.AddWithValue("@maLoaiSach", maLoaiSach);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Sửa loại sách thành công!", "Thông báo");
                LoadLoaiSachGrid();
            }
        }

        private void btnLoaiSachXoa_Click(object sender, EventArgs e)
        {
            if (dgLoaiSach.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn loại sách cần xóa.", "Thông báo");
                return;
            }

            int maLoaiSach = int.Parse(dgLoaiSach.SelectedRows[0].Cells["Mã loại sách"].Value.ToString());

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa loại sách này không? Lưu ý: Các sách liên quan cũng sẽ bị xóa.",
                                                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                string query = "DELETE FROM tbl_loai_sach WHERE ma_loai_sach = @maLoaiSach";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@maLoaiSach", maLoaiSach);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Xóa loại sách thành công!", "Thông báo");
                    LoadLoaiSachGrid();
                    LoadSachGrid(); 
                }
            }
        }

        private void dgLoaiSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo rằng dòng được chọn là hợp lệ
            {
                DataGridViewRow row = dgLoaiSach.Rows[e.RowIndex];
                txtLoaiSachTenLoaiSach.Text = row.Cells["Tên loại sách"].Value.ToString(); // Sử dụng alias nếu có
            }
        }

        private void btnSachSua_Click(object sender, EventArgs e)
        {
            if (dgSach.CurrentRow == null) // Kiểm tra xem có dòng nào được chọn không
            {
                MessageBox.Show("Vui lòng chọn sách cần sửa.", "Thông báo");
                return;
            }

            string tenSach = txtSachTenSach.Text.Trim();
            string tacGia = txtSachTacGia.Text.Trim();
            int soLuong;
            decimal giaBan;

            // Kiểm tra dữ liệu nhập
            if (string.IsNullOrEmpty(tenSach) ||
                !int.TryParse(numSachSoLuong.Text, out soLuong) ||
                !decimal.TryParse(numSachGiaBan.Text, out giaBan) ||
                cbSachLoaiSach.SelectedValue == null ||
                soLuong <= 0 || giaBan <= 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và hợp lệ thông tin sách.", "Thông báo");
                return;
            }

            int maLoaiSach = int.Parse(cbSachLoaiSach.SelectedValue.ToString());
            int maSach = int.Parse(dgSach.CurrentRow.Cells["ma_sach"].Value.ToString()); // Lấy mã sách từ dòng được chọn

            string query = "UPDATE tbl_sach SET ten_sach = @tenSach, ma_loai_sach = @maLoaiSach, tac_gia = @tacGia, so_luong = @soLuong, gia_ban = @giaBan WHERE ma_sach = @maSach";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@tenSach", tenSach);
                command.Parameters.AddWithValue("@maLoaiSach", maLoaiSach);
                command.Parameters.AddWithValue("@tacGia", tacGia);
                command.Parameters.AddWithValue("@soLuong", soLuong);
                command.Parameters.AddWithValue("@giaBan", giaBan);
                command.Parameters.AddWithValue("@maSach", maSach);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Sửa sách thành công!", "Thông báo");
                LoadSachGrid(); // Cập nhật lại danh sách
            }
        }

        private void btnSachXoa_Click(object sender, EventArgs e)
        {
            if (dgSach.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa.", "Thông báo");
                return;
            }

            int maSach = int.Parse(dgSach.SelectedRows[0].Cells["ma_sach"].Value.ToString());
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                string query = "DELETE FROM tbl_sach WHERE ma_sach = @maSach";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@maSach", maSach);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Xóa sách thành công!", "Thông báo");
                    LoadSachGrid(); // Cập nhật lại danh sách
                }
            }
        }

        private void dgSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo rằng dòng được chọn là hợp lệ
            {
                DataGridViewRow row = dgSach.Rows[e.RowIndex];
                txtSachTenSach.Text = row.Cells["ten_sach"].Value.ToString();
                cbSachLoaiSach.Text = row.Cells["ten_loai_sach"].Value.ToString(); // Loại sách hiển thị tên, không phải mã
                txtSachTacGia.Text = row.Cells["tac_gia"].Value.ToString();
                numSachSoLuong.Value = Convert.ToDecimal(row.Cells["so_luong"].Value);
                numSachGiaBan.Value = Convert.ToDecimal(row.Cells["gia_ban"].Value);
            }
        }

        private void btnHoaDonThem_Click(object sender, EventArgs e)
        {
            string ngayLap = dateNgayLapHoaDon.Value.ToString("yyyy-MM-dd");
            string tenKhachHang = txtHoaDonTenKH.Text.Trim();
            string sdtKhachHang = txtHoaDonSDTKH.Text.Trim();

            // Kiểm tra thông tin nhập
            if (string.IsNullOrEmpty(tenKhachHang) || string.IsNullOrEmpty(sdtKhachHang))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.", "Thông báo");
                return;
            }

            string query = "INSERT INTO tbl_hoa_don (ngay_lap, ten_khach_hang, sdt_khach_hang) VALUES (@ngayLap, @tenKhachHang, @sdtKhachHang)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ngayLap", ngayLap);
                command.Parameters.AddWithValue("@tenKhachHang", tenKhachHang);
                command.Parameters.AddWithValue("@sdtKhachHang", sdtKhachHang);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo");
                LoadHoaDonGrid(); // Cập nhật lại danh sách
            }
        }

        private void btnHoaDonSua_Click(object sender, EventArgs e)
        {
            if (dgHoaDon.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần sửa.", "Thông báo");
                return;
            }

            int maHoaDon = int.Parse(dgHoaDon.CurrentRow.Cells["Mã Hóa Đơn"].Value.ToString());
            string ngayLap = dateNgayLapHoaDon.Value.ToString("yyyy-MM-dd");
            string tenKhachHang = txtHoaDonTenKH.Text.Trim();
            string sdtKhachHang = txtHoaDonSDTKH.Text.Trim();

            // Kiểm tra thông tin nhập
            if (string.IsNullOrEmpty(tenKhachHang) || string.IsNullOrEmpty(sdtKhachHang))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.", "Thông báo");
                return;
            }

            string query = "UPDATE tbl_hoa_don SET ngay_lap = @ngayLap, ten_khach_hang = @tenKhachHang, sdt_khach_hang = @sdtKhachHang WHERE ma_hoa_don = @maHoaDon";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ngayLap", ngayLap);
                command.Parameters.AddWithValue("@tenKhachHang", tenKhachHang);
                command.Parameters.AddWithValue("@sdtKhachHang", sdtKhachHang);
                command.Parameters.AddWithValue("@maHoaDon", maHoaDon);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Sửa hóa đơn thành công!", "Thông báo");
                LoadHoaDonGrid(); // Cập nhật lại danh sách
            }
        }

        private void btnHoaDonXoa_Click(object sender, EventArgs e)
        {
            if (dgHoaDon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa.", "Thông báo");
                return;
            }

            int maHoaDon = int.Parse(dgHoaDon.SelectedRows[0].Cells["Mã Hóa Đơn"].Value.ToString());
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                string query = "DELETE FROM tbl_hoa_don WHERE ma_hoa_don = @maHoaDon";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@maHoaDon", maHoaDon);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo");
                    LoadHoaDonGrid(); // Cập nhật lại danh sách
                }
            }
        }

        private void dgHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgHoaDon.Rows[e.RowIndex];
                dateNgayLapHoaDon.Value = Convert.ToDateTime(row.Cells["Ngày Lập"].Value);
                txtHoaDonTenKH.Text = row.Cells["Tên Khách Hàng"].Value.ToString();
                txtHoaDonSDTKH.Text = row.Cells["SDT Khách Hàng"].Value.ToString();
            }
        }
    }
}
