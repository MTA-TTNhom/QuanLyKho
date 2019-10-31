using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLiNhanVien
{
    public partial class frmMain : Form
    {
        string connStr = @"Data Source=DESKTOP-5052T8O\SQLEXPRESS;Initial Catalog=QLNVPB;Integrated Security=True";
        SqlConnection conn;
        public frmMain()
        {
            InitializeComponent();
        }
        private void LoadDataPB()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM phongban", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPhongBan.DataSource = dt;
            dgvPhongBan.AutoResizeColumns();
        }

        private void LoadDataNV()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM nhanvien", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvNhanVien.DataSource = dt;
            dgvNhanVien.AutoResizeColumns();
        }

        private void LoadDataDA()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM duan", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDuAn.DataSource = dt;
            dgvDuAn.AutoResizeColumns();
          

        }
        private void LoadDataPC()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM phancong", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPhanCong.DataSource = dt;
            dgvPhanCong.AutoResizeColumns();
        }
        private void LoadDataTN()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM thannhan", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvThanNhan.DataSource = dt;
            dgvThanNhan.AutoResizeColumns();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
            conn.Open();
            LoadDataPB();
            LoadDataNV();
            LoadDataDA();
            LoadDataPC();
            LoadDataTN();
        }
       
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaNV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["colMaNV"].Value);
                txtTenNV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["colTenNV"].Value);
                txtNS.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["colNS"].Value);
                txtDiaChi.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["colDiaChi"].Value);
                txtLuong.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["colLuong"].Value);
                txtGT.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["colGT"].Value);
                txtMaNGS.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["colMaNGS"].Value);
                txtMaPB_NV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["colMaPB_NV"].Value);
            }
        }

        private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaPB.Text = Convert.ToString(dgvPhongBan.CurrentRow.Cells["colMaPB"].Value);
                txtTenPB.Text = Convert.ToString(dgvPhongBan.CurrentRow.Cells["colTenPB"].Value);
                txtMaTP.Text = Convert.ToString(dgvPhongBan.CurrentRow.Cells["colMaTP"].Value);
                txtNg_NhanChuc.Text = Convert.ToString(dgvPhongBan.CurrentRow.Cells["colNg_NhanChuc"].Value);
            }
        }

        private void dgvDuAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaDA.Text = Convert.ToString(dgvDuAn.CurrentRow.Cells["colMaDA"].Value);
                txtTenDA.Text = Convert.ToString(dgvDuAn.CurrentRow.Cells["colTenDA"].Value);
                txtMaPB_DA.Text = Convert.ToString(dgvDuAn.CurrentRow.Cells["colMaPB_DA"].Value);
                txtDiaDiem.Text = Convert.ToString(dgvDuAn.CurrentRow.Cells["colDiaDiem"].Value);
            }
        }

        private void dgvPhanCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaNV_PC.Text = Convert.ToString(dgvPhanCong.CurrentRow.Cells["colMaNV_PC"].Value);
                txtMaDA_PC.Text = Convert.ToString(dgvPhanCong.CurrentRow.Cells["colMaDA_PC"].Value);
                txtSoGio.Text = Convert.ToString(dgvPhanCong.CurrentRow.Cells["colSoGio"].Value);
            }
        }

        private void dgvThanNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaNV_TN.Text = Convert.ToString(dgvThanNhan.CurrentRow.Cells["colMaNV_TN"].Value);
                txtTenTN.Text = Convert.ToString(dgvThanNhan.CurrentRow.Cells["colTenTN"].Value);
                txtGT_TN.Text = Convert.ToString(dgvThanNhan.CurrentRow.Cells["colGT_TN"].Value);
                txtNgSinh_TN.Text = Convert.ToString(dgvThanNhan.CurrentRow.Cells["colNgSinh_TN"].Value);
                txtQuanHe.Text = Convert.ToString(dgvThanNhan.CurrentRow.Cells["colQuanHe"].Value);
            }
        }
        int NVflag;

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            NVflag = 1;           
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            NVflag = 2;
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            NVflag = 3;
        }
        private void btnLuuNV_Click(object sender, EventArgs e)
        {
            if (NVflag == 1)
            {
                SqlCommand cmd = new SqlCommand("ThemNhanVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p;
                p = new SqlParameter("@MaNV", txtMaNV.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenNV", txtTenNV.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@NS", Convert.ToDateTime(txtNS.Text));
                cmd.Parameters.Add(p);
                p = new SqlParameter("@DiaChi", txtDiaChi.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Luong", Convert.ToInt32(txtLuong.Text));
                cmd.Parameters.Add(p);
                p = new SqlParameter("@GT", txtGT.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaNGS", txtMaNGS.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaPB", txtMaPB_NV.Text);
                cmd.Parameters.Add(p);

                int cnt = cmd.ExecuteNonQuery();
                if (cnt > 0)
                {
                    MessageBox.Show("Thêm mới thành công!!");
                    LoadDataNV();
                }
                else MessageBox.Show("Không thể thêm mới!!");
            }
            else if (NVflag == 2)
            {

                SqlCommand cmd = new SqlCommand("SuaNhanVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p;
                p = new SqlParameter("@MaNV", txtMaNV.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenNV", txtTenNV.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@NS", Convert.ToDateTime(txtNS.Text));
                cmd.Parameters.Add(p);
                p = new SqlParameter("@DiaChi", txtDiaChi.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@Luong", Convert.ToInt32(txtLuong.Text));
                cmd.Parameters.Add(p);
                p = new SqlParameter("@GT", txtGT.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaNGS", txtMaNGS.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaPB", txtMaPB_NV.Text);
                cmd.Parameters.Add(p);

                int cnt = cmd.ExecuteNonQuery();
                if (cnt > 0)
                {
                    MessageBox.Show("Chỉnh sửa thành công!!");
                    LoadDataNV();
                }
                else MessageBox.Show("Không thể chỉnh sửa!!");
            }
            else if (NVflag == 3)
            {
                SqlCommand cmd = new SqlCommand("XoaNhanVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p;
                p = new SqlParameter("@MaNV", txtMaNV_TN.Text);
                cmd.Parameters.Add(p);
                int cnt = cmd.ExecuteNonQuery();
                if (cnt > 0)
                {
                    MessageBox.Show("Xóa thành công!!");
                    LoadDataTN();
                }
                else MessageBox.Show("Không thể Xóa!!");
            }
        }

        private void btnHuyNV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hủy bỏ!");
        }
        int PBflag;
        private void btnThemPB_Click(object sender, EventArgs e)
        {
            PBflag = 1;
         }

        private void btnSuaPB_Click(object sender, EventArgs e)
        {
            PBflag = 2;
        }

        private void btnXoaPB_Click(object sender, EventArgs e)
        {
            PBflag = 3;
        }
        private void btnHuyPB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hủy bỏ!");
        }

        private void btnLuuPB_Click(object sender, EventArgs e)
        {
            if (PBflag == 1)
            {
                SqlCommand cmd = new SqlCommand("ThemPhongBan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p;
                p = new SqlParameter("@MaPB", txtMaPB.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenPB", txtTenPB.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaTP", txtMaTP.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@NgNhanChuc", Convert.ToDateTime(txtNg_NhanChuc.Text));
                cmd.Parameters.Add(p);
                //-------
                int cnt = cmd.ExecuteNonQuery();
                if (cnt > 0)
                {
                    MessageBox.Show("Thêm thành công!!");
                    LoadDataPB();
                }
                else MessageBox.Show("Không thể Thêm!!");
            }
            else if (PBflag == 2) {
                SqlCommand cmd = new SqlCommand("SuaPhongBan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p;
                p = new SqlParameter("@MaPB", txtMaPB.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenPB", txtTenPB.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaTP", txtMaTP.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@NgNhanChuc", Convert.ToDateTime(txtNg_NhanChuc.Text));
                cmd.Parameters.Add(p);
                //-------
                int cnt = cmd.ExecuteNonQuery();
                if (cnt > 0)
                {
                    MessageBox.Show("Sửa thành công!!");
                    LoadDataPB();
                }
                else MessageBox.Show("Không thể Sửa!!");
            }
            else if (PBflag == 3)
            {
                SqlCommand cmd = new SqlCommand("XoaPhongBan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p;
                p = new SqlParameter("@MaPB", txtMaPB.Text);
                cmd.Parameters.Add(p);
                int cnt = cmd.ExecuteNonQuery();
                if (cnt > 0)
                {
                    MessageBox.Show("Xóa thành công!!");
                    LoadDataPB();
                }
                else MessageBox.Show("Không thể Xóa!!");
            }
        }
        int DAflag;
        private void btnThemDA_Click(object sender, EventArgs e)
        {
            DAflag = 1;
        }

        private void btnSuaDA_Click(object sender, EventArgs e)
        {
            DAflag = 2;          
        }

        private void btnXoaDA_Click(object sender, EventArgs e)
        {
            DAflag = 3;            
        }
        private void btnLuuDA_Click(object sender, EventArgs e)
        {
            if (DAflag == 1)
            {
                SqlCommand cmd = new SqlCommand("ThemDuAn", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p;
                p = new SqlParameter("@MaDA", txtMaDA.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenDA", txtTenDA.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaPB", txtMaPB_DA.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@DiaDiem", txtDiaDiem.Text);
                cmd.Parameters.Add(p);
                //----------
                int cnt = cmd.ExecuteNonQuery();
                if (cnt > 0)
                {
                    MessageBox.Show("Thêm thành công!!");
                    LoadDataDA();
                }
                else MessageBox.Show("Không thể Thêm!!");
            }
            else if (DAflag == 2)
            {
                SqlCommand cmd = new SqlCommand("SuaDuAn", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p;
                p = new SqlParameter("@MaDA", txtMaDA.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenDA", txtTenDA.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaPB", txtMaPB_DA.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@DiaDiem", txtDiaDiem.Text);
                cmd.Parameters.Add(p);
                //----------
                int cnt = cmd.ExecuteNonQuery();
                if (cnt > 0)
                {
                    MessageBox.Show("Sửa thành công!!");
                    LoadDataDA();
                }
                else MessageBox.Show("Không thể Sửa!!");
            }
            else if (DAflag == 3)
            {
                SqlCommand cmd = new SqlCommand("XoaDuAn", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p;
                p = new SqlParameter("@MaDA", txtMaDA.Text);
                cmd.Parameters.Add(p);
                int cnt = cmd.ExecuteNonQuery();
                if (cnt > 0)
                {
                    MessageBox.Show("Xóa thành công!!");
                    LoadDataDA();
                }
                else MessageBox.Show("Không thể Xóa!!");
            }
        }

        private void btnHuyDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hủy bỏ!");
        }
        int PCflag;
        private void btnThemPC_Click(object sender, EventArgs e)
        {
            PCflag = 1;
        }

        private void btnSuaPC_Click(object sender, EventArgs e)
        {
            PCflag = 2;
        }

        private void btnXoaPC_Click(object sender, EventArgs e)
        {
            PCflag = 3;            
        }
        private void btnLuuPC_Click(object sender, EventArgs e)
        {
            if (PCflag == 1)
            {
                SqlCommand cmd = new SqlCommand("ThemPhanCong", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p;
                p = new SqlParameter("@MaNV", txtMaNV_PC.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaDA", txtMaDA_PC.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@SoGio", Convert.ToInt32(txtSoGio.Text));
                cmd.Parameters.Add(p);
                int cnt = cmd.ExecuteNonQuery();
                if (cnt > 0)
                {
                    MessageBox.Show("Thêm thành công!!");
                    LoadDataPC();
                }
                else MessageBox.Show("Không thể Thêm!!");
            }
            else if (PCflag == 2)
            {
                SqlCommand cmd = new SqlCommand("SuaPhanCong", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p;
                p = new SqlParameter("@MaNV", txtMaNV_PC.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaDA", txtMaDA_PC.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@SoGio", Convert.ToInt32(txtSoGio.Text));
                cmd.Parameters.Add(p);
                int cnt = cmd.ExecuteNonQuery();
                if (cnt > 0)
                {
                    MessageBox.Show("Sửa thành công!!");
                    LoadDataPC();
                }
                else MessageBox.Show("Không thể Sửa!!");
            }
            else if (PCflag == 3)
            {
                SqlCommand cmd = new SqlCommand("XoaPhanCong", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p;
                p = new SqlParameter("@MaNV", txtMaNV_PC.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@MaDA", txtMaDA_PC.Text);
                cmd.Parameters.Add(p);
                int cnt = cmd.ExecuteNonQuery();
                if (cnt > 0)
                {
                    MessageBox.Show("Xóa thành công!!");
                    LoadDataPC();
                }
                else MessageBox.Show("Không thể Xóa!!");
            }
        }

        private void btnHuyPC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hủy bỏ!");
        }
        int TNflag;
        private void btnThemTN_Click(object sender, EventArgs e)
        {
            TNflag = 1;
            }

        private void btnSuaTN_Click(object sender, EventArgs e)
        {
            TNflag = 2;
        }

        private void btnXoaTN_Click(object sender, EventArgs e)
        {
            TNflag = 3;
        }

        private void btnLuuTN_Click(object sender, EventArgs e)
        {
            if (TNflag == 1)
            {
                SqlCommand cmd = new SqlCommand("ThemThanNhan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p;
                p = new SqlParameter("@MaNV", txtMaNV_TN.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenTN", txtTenTN.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@GT", txtGT_TN.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@NS", Convert.ToDateTime(txtNgSinh_TN.Text));
                cmd.Parameters.Add(p);
                p = new SqlParameter("@QuanHe", txtQuanHe.Text);
                cmd.Parameters.Add(p);
                int cnt = cmd.ExecuteNonQuery();
                if (cnt > 0)
                {
                    MessageBox.Show("Thêm thành công!!");
                    LoadDataTN();
                }
                else MessageBox.Show("Không thể Thêm!!");
            }
            else if (TNflag == 2)
            {
                SqlCommand cmd = new SqlCommand("SuaThanNhan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p;
                p = new SqlParameter("@MaNV", txtMaNV_TN.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenTN", txtTenTN.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@GT", txtGT_TN.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@NS", Convert.ToDateTime(txtNgSinh_TN.Text));
                cmd.Parameters.Add(p);
                p = new SqlParameter("@QuanHe", txtQuanHe.Text);
                cmd.Parameters.Add(p);
                int cnt = cmd.ExecuteNonQuery();
                if (cnt > 0)
                {
                    MessageBox.Show("Sửa thành công!!");
                    LoadDataTN();
                }
                else MessageBox.Show("Không thể Sửa!!");
            }
            else if (TNflag == 3)
            {
                SqlCommand cmd = new SqlCommand("XoaThanNhan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p;
                p = new SqlParameter("@MaNV", txtMaNV_TN.Text);
                cmd.Parameters.Add(p);
                p = new SqlParameter("@TenTN", txtTenTN.Text);
                cmd.Parameters.Add(p);
               int cnt = cmd.ExecuteNonQuery();
                if (cnt > 0)
                {
                    MessageBox.Show("Xóa thành công!!");
                    LoadDataTN();
                }
                else MessageBox.Show("Không thể Xóa!!");
            }
        }

        private void tabNhanVien_Click(object sender, EventArgs e)
        {

        }
    }
   }