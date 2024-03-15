using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang
{
    public partial class Form1 : Form
    {
        Classes.ConnectData data = new Classes.ConnectData();
        Classes.CommonFuntions funtion = new Classes.CommonFuntions();
        String fileAnh;
        void loadData()
        {
            DataTable dtHang = data.ReadData("select * from DMHang");
            dgv.DataSource = dtHang;

        }
        public Form1()
        {
            InitializeComponent();
            DataTable dtChatLieu = data.ReadData("select * from DMChatLieu");
            funtion.FillComboBox(cbbID, dtChatLieu, "MaChatLieu", "MaChatLieu");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
            dgv.Columns[0].HeaderText = "Mã Hàng";
            dgv.Columns[1].HeaderText = "Tên Hàng";
            dgv.Columns[2].HeaderText = "Mã Chất Liệu";
            dgv.Columns[3].HeaderText = "Số Lượng";
            dgv.Columns[4].HeaderText = "Đơn giá nhập";
            dgv.Columns[5].HeaderText = "Đơn giá bán";
            dgv.Columns[6].HeaderText = "Ảnh";
            dgv.Columns[7].HeaderText = "Ghi chú";
            ResetValue();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHang.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            txtTenHang.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            cbbID.SelectedValue = dgv.CurrentRow.Cells[2].Value.ToString();
            txtSoLuong.Text = dgv.CurrentRow.Cells[3].Value.ToString();
            txtDonGiaNhap.Text = dgv.CurrentRow.Cells[4].Value.ToString();
            txtDonGiaBan.Text = dgv.CurrentRow.Cells[5].Value.ToString();
            txtGhiChu.Text = dgv.CurrentRow.Cells[7].Value.ToString();
            fileAnh = dgv.CurrentRow.Cells[6].Value.ToString();
            pictureAnh.Image = Image.FromFile(Application.StartupPath + "\\images\\" + fileAnh);
            bntThem.Enabled = false;
            bntSua.Enabled = true;
            bntXoa.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] image;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "JPEG images|*.jpg|PNG images|*.png|All files|*.*";
            openFile.FilterIndex = 1;
            openFile.InitialDirectory = Application.StartupPath;
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                pictureAnh.Image = Image.FromFile(openFile.FileName);
                image = openFile.FileName.ToString().Split('\\');
                fileAnh = image[image.Length-1];
                MessageBox.Show(fileAnh);
            }
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            //Kiem tra co trung ma hang khong
            DataTable dtCheckHang = data.ReadData("Select * from DMHang where MaHang = '"+txtMaHang.Text+"'");
            if (dtCheckHang.Rows.Count>0)
            {
                MessageBox.Show("Mã Hàng Đã Có Rồi, Vui Lòng Nhập Mã Hàng Khác");
                txtMaHang.Focus();
                return;
            }
            string sqlInsert = "insert into DMHang values('"+txtMaHang.Text+"',N'"+txtTenHang.Text+"','"+cbbID.SelectedValue
                +"',"+int.Parse(txtSoLuong.Text)+","+float.Parse(txtDonGiaNhap.Text)+","+ float.Parse(txtDonGiaBan.Text)+",'"+fileAnh+"',N'"+txtGhiChu.Text+"')";
            data.UpdateData(sqlInsert);
            loadData();
            MessageBox.Show("Thêm Mới Thành Công!");
        }
        void ResetValue()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            cbbID.Text = "";
            txtSoLuong.Text = "";
            txtDonGiaNhap.Text = ""; 
            txtDonGiaBan.Text = "";
            pictureAnh.Image = null;
            fileAnh = "";
            txtMaHang.Focus();
            bntThem.Enabled = true;
            bntSua.Enabled = false;
            bntXoa.Enabled = false;
        }

        private void bntBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa không", "Thông Báo !",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                data.UpdateData("delete DMHang where MaHang='"+txtMaHang.Text+"' ");
                loadData() ;
                ResetValue();
            }
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            //Kiểm tra tính đầy đủ và chính xác của dữ liệu
            //Sửa dữ liệu
            data.UpdateData("update DMHang set TenHang =N'"+txtTenHang.Text+
                "',MaChatLieu ='"+cbbID.SelectedValue+"',SoLuong="+int.Parse(txtSoLuong.Text)+
                " ,DonGiaNhap="+float.Parse(txtDonGiaNhap.Text)+" ,DonGiaBan="+float.Parse(txtDonGiaBan.Text)+
                " ,Hinh='"+fileAnh+"', GhiChu=N'"+txtGhiChu.Text+"' where MaHang='"+txtMaHang.Text+"' ");
            loadData() ; 
            ResetValue();
        }

        private void bntDong_Click(object sender, EventArgs e)
        {
            DialogResult dialog  =MessageBox.Show("Bạn Có Chắc Chắn Muốn Thoát Không", "Thông Báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
