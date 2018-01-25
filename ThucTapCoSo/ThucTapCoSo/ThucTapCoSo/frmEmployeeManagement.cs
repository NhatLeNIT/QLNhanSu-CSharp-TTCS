using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapCoSo
{
    public partial class frmEmployeeManagement : Form
    {
        LinkedList employeeList = new LinkedList();
        MyProcess process = new MyProcess();
        private string filePath = "../../Data/ListEmployee.txt";
        private bool isSaved = false;
        public frmEmployeeManagement()
        {
            InitializeComponent();
            cbbTieuChiSapXep.SelectedIndex = 0;
        }

        private bool ValidateData()
        {
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (txtHeSoLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập hệ số lương. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void frmEmployeeManagement_Load(object sender, EventArgs e)
        {
            cbbChucVu.DataSource = process.arrOffice;
            process.ImportDataFromFile(ref employeeList, filePath);
            process.LoadToDataGridView(msdsNhanVien, employeeList);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                // Sắp xếp theo
                string sortBy = process.GetNameSelected(cbbTieuChiSapXep.SelectedIndex);
                // Kiểu sắp xếp
                string typeSort = "";
                if (rbtnTangDan.Checked) typeSort = "asc";
                else typeSort = "desc";
                // Khởi tạo obj employee
                Employee itemEmployee = new Employee();
                itemEmployee.Name = txtHoTen.Text;
                itemEmployee.Office = cbbChucVu.Text;
                itemEmployee.Birthday = Date.ParseDate(dpNgaySinh.Text);
                try
                {
                    itemEmployee.Salary = Convert.ToDouble(txtHeSoLuong.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hệ số lương bạn nhập không phải là số. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // Khởi tạo node mới
                Node itemNode = new Node(itemEmployee);
                //thêm
                employeeList.Insert(itemNode, sortBy, typeSort);
                //tải lại danh sách
                process.LoadToDataGridView(msdsNhanVien, employeeList);

                this.ResetInput();
            }
        }

        private void btnThucHienSapXep_Click(object sender, EventArgs e)
        {
            // Sắp xếp theo
            string sortBy = process.GetNameSelected(cbbTieuChiSapXep.SelectedIndex);
            // Kiểu sắp xếp
            string typeSort = "";
            if (rbtnTangDan.Checked) typeSort = "asc";
            else typeSort = "desc";
            //sắp xếp
            employeeList.Sort(typeSort, sortBy);
            //tải lại danh sách
            process.LoadToDataGridView(msdsNhanVien, employeeList);
        }

        private void btnThucHienTimKiem_Click(object sender, EventArgs e)
        {
            if (txtNoiDungTim.Text != "")
            {
                // Tìm kiếm theo
                string keyword = txtNoiDungTim.Text;
                LinkedList searchResult = new LinkedList();

                searchResult = employeeList.Search(keyword);
                if (searchResult.PHead != null)
                    process.LoadSearchResultToDataGridView(msdsNhanVien, employeeList, searchResult);
                else
                    MessageBox.Show("Không tìm thấy nhân viên nào phù hợp với từ khóa", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            else MessageBox.Show("Bạn chưa nhập nội dung cần tìm. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void btnThucHienXoa_Click(object sender, EventArgs e)
        {
            if (txtTuKhoaXoa.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập từ khóa. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                if (process.GetInfoEmployeeByKeyword(employeeList, txtTuKhoaXoa.Text) != "")
                {
                    if (MessageBox.Show("Bạn có chắc muốn xóa những nhân viên này không?\n\n" + process.GetInfoEmployeeByKeyword(employeeList, txtTuKhoaXoa.Text), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        employeeList.Remove(txtTuKhoaXoa.Text);
                        process.LoadToDataGridView(msdsNhanVien, employeeList);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên có thông tin liên quan với từ khóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            process.LoadToDataGridView(msdsNhanVien, employeeList);
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            process.SaveFile(employeeList, filePath);
            this.isSaved = true;
        }

        private void frmEmployeeManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSaved)
            {
                if (MessageBox.Show("Bạn có muốn lưu lại dữ liệu trước khi thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    process.SaveFile(employeeList, filePath);
                }
            }
        }

        private void ResetInput()
        {
            this.txtHoTen.Text = string.Empty;
            this.cbbChucVu.Text = string.Empty;
            this.txtHeSoLuong.Text = string.Empty;
        }

        private void btn_DocLaiFile_Click(object sender, EventArgs e)
        {
            process.ImportDataFromFile(ref employeeList, filePath);
            process.LoadToDataGridView(msdsNhanVien, employeeList);
        }
    }
}
