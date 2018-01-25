using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapCoSo
{
    public class MyProcess
    {
        public string[] arrOffice;

        /// <summary>
        /// Constructor
        /// </summary>
        public MyProcess()
        {
            arrOffice = new string[]
            {
                "Nhân viên", "Phó trưởng phòng", "Trưởng phòng", "Thư ký", "Phó giám đốc", "Giám đốc", "Tổng giám đốc"
            };
        }

        /// <summary>
        /// Hàm kiểm tra và lấy thông tin nhân viên trước khi xóa
        /// </summary>
        /// <param name="l"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public string GetInfoEmployeeByKeyword(LinkedList l, string keyword)
        {
            string result = "", strTemp = "";
            int count = 0;
            for (Node indexNode = l.PHead; indexNode != null; indexNode = indexNode.PNext)
            {
                if (indexNode.Data.Name.ToUpper().Contains(keyword.ToUpper())
                    || indexNode.Data.Office.ToUpper().Equals(keyword.ToUpper())
                    || indexNode.Data.Birthday.ToString().Equals(keyword)
                    || indexNode.Data.Salary.ToString().Equals(keyword))
                {
                    count++;
                    strTemp += indexNode.Data.Display() + "\n\n";
                }
            }
            if (count != 0)
            {
                result = "Có " + count + " nhân viên được tìm thấy: \n";
                result += strTemp;
            }
            return result;
        }

        /// <summary>
        /// Lấy data từ file đưa vào DSLK
        /// </summary>
        /// <param name="l">DSLK cần đưa vào</param>
        /// <param name="filePath">Đường dẫn file cần import</param>
        public void ImportDataFromFile(ref LinkedList l, string filePath)
        {
            Employee e = null;
            l.EmptyList();
            StreamReader file = File.OpenText(filePath);
            string line;
            bool flag = false;
            do
            {
                line = file.ReadLine();
                if (line == null) continue;
                if (flag)
                {
                    //Tạo đối tượng mới
                    e = new Employee();
                    string[] words = line.Split('\t');
                    e.Name = words[0];
                    e.Office = words[1];
                    e.Birthday = Date.ParseDate(words[2]);
                    e.Salary = Convert.ToDouble(words[3]);
                    //Lưu đối tượng vào trong danh sách liên kết
                    Node p = new Node(e);
                    l.AddTail(p);
                }
                else
                {
                    flag = true;
                }

            }
            while (line != null);
            file.Close();
        }

        /// <summary>
        /// Load dữ liệu từ DSLK lên DataGridView
        /// </summary>
        /// <param name="dg">Tên DataGridView</param>
        /// <param name="list">DSLK cần hiển thị lên DataGridView</param>
        public void LoadToDataGridView(DataGridView dg, LinkedList list)
        {
            dg.Rows.Clear();
            int i = 0;
            for (Node p = list.PHead; p != null; p = p.PNext)
            {
                dg.Rows.Add(++i, p.Data.Name, p.Data.Office, p.Data.Birthday, p.Data.Salary);
            }
            dg.Columns[0].HeaderText = "STT";
        }

        /// <summary>
        /// Lấy chỉ số chức vụ trong mảng
        /// </summary>
        /// <param name="office">Chức vụ cần lấy chỉ số</param>
        /// <returns></returns>
        public int GetIndexOfArray(string office)
        {
            for (int i = 0; i < arrOffice.Length; i++)
            {
                if (arrOffice[i].Equals(office))
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// Lấy tiêu chí cần sắp xếp
        /// </summary>
        /// <param name="selectedIndex"></param>
        /// <returns></returns>
        public string GetNameSelected(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0:
                    return "name";
                case 1:
                    return "office";
                case 2:
                    return "birthday";
                case 3:
                    return "salary";
                default: return null;
            }
        }

        /// <summary>
        /// Đảo ngược mảng
        /// </summary>
        /// <param name="arrStrings">mảng array truyền vào</param>
        /// <returns></returns>
        public string[] ReverseArrayString(string[] arrStrings)
        {
            string[] result = new string[arrStrings.Length];
            int j = 0;
            for (int i = arrStrings.Length - 1; i >= 0; i--)
            {
                result[j] = arrStrings[i];
                j++;
            }
            return result;
        }

        /// <summary>
        /// So sánh 2 chuỗi (lớn hơn là nằm sau, nhỏ hơn nằm trước)
        /// </summary>
        /// <param name="firstString">Chuỗi thứ nhất</param>
        /// <param name="secondString">Chuỗi thứ hai</param>
        /// <returns>[-1 => "nhỏ hơn", 0 => "bằng nhau", 1 => "lớn hơn"]</returns>
        public int CompareTwoString(string firstString, string secondString)
        {
            string[] arrFirstString = ReverseArrayString(firstString.Split(' '));
            string[] arrSecondString = ReverseArrayString(secondString.Split(' '));
            int lenght = arrFirstString.Length > arrSecondString.Length ? arrSecondString.Length : arrFirstString.Length;

            for (int i = 0; i < lenght - 1; i++)
            {
                if (arrFirstString[i].CompareTo(arrSecondString[i]) > 0)
                    return 1;
                else if (arrFirstString[i].CompareTo(arrSecondString[i]) < 0)
                    return -1;
            }
            // Kiểm tra trường hợp nếu so sánh ở trên bằng nhau
            if (arrFirstString.Length == arrSecondString.Length)
                return 0;
            else if (arrFirstString.Length > arrSecondString.Length)
                return 1;
            else return -1;
        }

        /// <summary>
        /// Load dữ liệu từ DSLK kết quả tìm kiếm lên DataGridView
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="currentList"></param>
        /// <param name="resultList"></param>
        public void LoadSearchResultToDataGridView(DataGridView dg, LinkedList currentList, LinkedList resultList)
        {
            dg.Rows.Clear();
            for (Node p = resultList.PHead; p != null; p = p.PNext)
            {
                dg.Rows.Add(currentList.IndexOf(p.Data), p.Data.Name, p.Data.Office, p.Data.Birthday, p.Data.Salary);
            }
            dg.Columns[0].HeaderText = "Vị trí";
        }

        /// <summary>
        /// Lưu dữ liệu từ DSLK xuống file text
        /// </summary>
        /// <param name="l"></param>
        /// <param name="filePath"></param>
        public void SaveFile(LinkedList l, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Truncate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Họ và tên\tChức vụ\tNgày tháng năm sinh\tHệ số lương");
            for (Node indexNode = l.PHead; indexNode != null; indexNode = indexNode.PNext)
            {
                sw.WriteLine(indexNode.Data.Name + "\t" + indexNode.Data.Office + "\t" + indexNode.Data.Birthday + "\t" + indexNode.Data.Salary);
            }
            sw.Close();

            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
