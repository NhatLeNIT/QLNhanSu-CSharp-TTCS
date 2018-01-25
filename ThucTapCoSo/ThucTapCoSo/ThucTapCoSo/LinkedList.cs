using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapCoSo
{
    public class LinkedList
    {
        public Node PHead { get; set; }
        public Node PTail { get; set; }

        /// <summary>
        /// Khoi tao danh sach lien ket
        /// </summary>
        public LinkedList()
        {
            PHead = new Node();
            PTail = new Node();
            PHead = PTail = null;
        }

        /// <summary>
        /// Thêm node vào đầu DSLK
        /// </summary>
        /// <param name="p">Node cần thêm</param>
        public void AddHead(Node p)
        {
            if (this.PHead == null)
            {
                this.PHead = this.PTail = p;
            }
            else
            {
                p.PNext = this.PHead;
                this.PHead = p;
            }
        }

        /// <summary>
        /// Thêm node vào cuối DSLK
        /// </summary>
        /// <param name="p">Node cần thêm</param>
        public void AddTail(Node p)
        {
            if (this.PHead == null)
            {
                this.PHead = this.PTail = p;
            }
            else
            {
                this.PTail.PNext = p;
                this.PTail = p;
            }
        }

        /// <summary>
        /// Xóa node đầu tiên của DSLK
        /// </summary>
        public void RemoveHead()
        {
            this.PHead = this.PHead.PNext;
        }

        /// <summary>
        /// Xóa node cuối cùng của DSLK
        /// </summary>
        public void RemoveTail()
        {
            Node prevNode = new Node(); // Node nằm trước node tail
            for (Node indexNode = this.PHead; indexNode != null; indexNode = prevNode.PNext)
            {
                if (indexNode == this.PTail)
                {
                    this.PTail = prevNode;
                    this.PTail.PNext = null;
                    return;
                }
                prevNode = indexNode;
            }
        }

        /// <summary>
        /// Xóa một node sau node cho trước
        /// </summary>
        /// <param name="nodeRemove"></param>
        public void RemoveAfterNode(Node nodeRemove)
        {
            Node itemNode = nodeRemove.PNext;
            nodeRemove.PNext = itemNode.PNext;
        }

        /// <summary>
        /// Xóa node theo từ khóa
        /// </summary>
        /// <param name="keyword"></param>
        public void Remove(string keyword)
        {
            for (Node indexNode = this.PHead; indexNode != null; indexNode = indexNode.PNext)
            {
                if (indexNode.Data.Name.ToUpper().Contains(keyword.ToUpper())
                    || indexNode.Data.Office.ToUpper().Equals(keyword.ToUpper())
                    || indexNode.Data.Birthday.ToString().Equals(keyword)
                    || indexNode.Data.Salary.ToString().Equals(keyword))
                {
                    RemoveNode(indexNode);
                }
            }
        }

        /// <summary>
        /// Xóa node bất kỳ
        /// </summary>
        /// <param name="nodeRemove"></param>
        public void RemoveNode(Node nodeRemove)
        {
            if (this.PHead == nodeRemove)
            {
                RemoveHead();
            }
            else if (this.PTail == nodeRemove)
            {
                RemoveTail();
            }
            else
            {
                Node prevNode = new Node();
                for (Node indexNode = this.PHead; indexNode != null; indexNode = indexNode.PNext)
                {
                    if (indexNode == nodeRemove)
                    {
                        RemoveAfterNode(prevNode);
                        return;
                    }
                    prevNode = indexNode;
                }
            }
        }

        /// <summary>
        /// Sắp xếp DSLK theo hệ số lương
        /// </summary>
        /// <param name="typeSort">Kiểu sắp xếp ["asc" => tăng dần, "desc" => giảm dần]</param>
        public void QuickSortBySalary(string typeSort)
        {
            LinkedList l1, l2; //tạo 2 danh sách đầu và cuối
            Node tag, temp;
            if (this.PHead == this.PTail) return; //Kiểm tra danh sách có sắp xếp chưa
            //Khởi tạo 2 DSLK
            l1 = new LinkedList();
            l2 = new LinkedList();
            //cho node cờ bằng node đầu tiên
            tag = this.PHead;
            //Cập nhật lại DSLK hiện tại
            this.PHead = this.PHead.PNext;
            //Cô lập tag
            tag.PNext = null;
            //tách các node ra DS l1, l2 (l1: các node có data < tag) và (l2: các node có data > tag)
            while (this.PHead != null)
            {
                temp = this.PHead;
                this.PHead = this.PHead.PNext;
                temp.PNext = null;
                if (typeSort.Equals("asc")) //sắp xếp tăng dần
                {
                    if (temp.Data.Salary <= tag.Data.Salary)
                        l1.AddHead(temp);
                    else l2.AddHead(temp);
                }
                else //sắp xếp giảm dần
                {
                    if (temp.Data.Salary > tag.Data.Salary)
                        l1.AddHead(temp);
                    else l2.AddHead(temp);
                }
            }

            //Gọi đệ quy sắp xếp l1, l2
            if (typeSort.Equals("asc"))
            {
                l1.QuickSortBySalary("asc");
                l2.QuickSortBySalary("asc");
            }
            else
            {
                l1.QuickSortBySalary("desc");
                l2.QuickSortBySalary("desc");
            }

            if (l1.PHead != null)
            {
                //l1 không rỗng
                this.PHead = l1.PHead;
                l1.PTail.PNext = tag;
            }
            else this.PHead = tag;
            tag.PNext = l2.PHead;

            this.PTail = l2.PHead != null ? l2.PTail : tag;
        }

        /// <summary>
        /// Sắp xếp DSLK theo ngày sinh
        /// </summary>
        /// <param name="typeSort">Kiểu sắp xếp ["asc" => tăng dần, "desc" => giảm dần]</param>
        public void QuickSortByBirthday(string typeSort)
        {
            LinkedList l1, l2; //tạo 2 danh sách đầu và cuối
            Node tag, temp;
            if (this.PHead == this.PTail) return; //Kiểm tra danh sách có sắp xếp chưa
            //Khởi tạo 2 DSLK
            l1 = new LinkedList();
            l2 = new LinkedList();
            //cho node cờ bằng node đầu tiên
            tag = this.PHead;
            //Cập nhật lại DSLK hiện tại
            this.PHead = this.PHead.PNext;
            //Cô lập tag
            tag.PNext = null;
            //tách các node ra DS l1, l2 (l1: các node có data < tag) và (l2: các node có data > tag)
            while (this.PHead != null)
            {
                temp = this.PHead;
                this.PHead = this.PHead.PNext;
                temp.PNext = null;
                if (typeSort.Equals("asc")) //sắp xếp tăng dần
                {
                    if (temp.Data.Birthday.CompareTo(tag.Data.Birthday) != 1)
                        l1.AddHead(temp);
                    else l2.AddHead(temp);
                }
                else //sắp xếp giảm dần
                {
                    if (temp.Data.Birthday.CompareTo(tag.Data.Birthday) == 1)
                        l1.AddHead(temp);
                    else l2.AddHead(temp);
                }
            }

            //Gọi đệ quy sắp xếp l1, l2
            if (typeSort.Equals("asc"))
            {
                l1.QuickSortByBirthday("asc");
                l2.QuickSortByBirthday("asc");
            }
            else
            {
                l1.QuickSortByBirthday("desc");
                l2.QuickSortByBirthday("desc");
            }

            if (l1.PHead != null)
            {
                //l1 không rỗng
                this.PHead = l1.PHead;
                l1.PTail.PNext = tag;
            }
            else this.PHead = tag;
            tag.PNext = l2.PHead;
            this.PTail = l2.PHead != null ? l2.PTail : tag;
        }

        /// <summary>
        /// Sắp xếp DSLK theo chức vụ
        /// </summary>
        /// <param name="l">DSLK cần được sắp xếp</param>
        /// <param name="typeSort">Kiểu sắp xếp ["asc" => tăng dần, "desc" => giảm dần]</param>
        public void QuickSortByOffice(string typeSort)
        {
            LinkedList l1, l2; //tạo 2 danh sách đầu và cuối
            Node tag, temp;
            MyProcess process = new MyProcess(); //đối tượng xử lý

            if (this.PHead == this.PTail) return; //Kiểm tra danh sách có sắp xếp chưa
            //Khởi tạo 2 DSLK
            l1 = new LinkedList();
            l2 = new LinkedList();
            //cho node cờ bằng node đầu tiên
            tag = this.PHead;
            //Cập nhật lại DSLK hiện tại
            this.PHead = this.PHead.PNext;
            //Cô lập tag
            tag.PNext = null;
            //tách các node ra DS l1, l2 (l1: các node có data < tag) và (l2: các node có data > tag)
            while (this.PHead != null)
            {
                temp = this.PHead;
                this.PHead = this.PHead.PNext;
                temp.PNext = null;
                if (typeSort.Equals("asc")) //sắp xếp tăng dần
                {
                    if (process.GetIndexOfArray(temp.Data.Office) <= process.GetIndexOfArray(tag.Data.Office))
                        l1.AddHead(temp);
                    else l2.AddHead(temp);
                }
                else //sắp xếp giảm dần
                {
                    if (process.GetIndexOfArray(temp.Data.Office) > process.GetIndexOfArray(tag.Data.Office))
                        l1.AddHead(temp);
                    else l2.AddHead(temp);
                }
            }

            //Gọi đệ quy sắp xếp l1, l2
            if (typeSort.Equals("asc"))
            {
                l1.QuickSortByOffice("asc");
                l2.QuickSortByOffice("asc");
            }
            else
            {
                l1.QuickSortByOffice("desc");
                l2.QuickSortByOffice("desc");
            }

            if (l1.PHead != null)
            {
                //l1 không rỗng
                this.PHead = l1.PHead;
                l1.PTail.PNext = tag;
            }
            else this.PHead = tag;
            tag.PNext = l2.PHead;

            this.PTail = l2.PHead != null ? l2.PTail : tag;
        }

        /// <summary>
        /// Sắp xếp DSLK theo tên
        /// </summary>
        /// <param name="typeSort">Kiểu sắp xếp ["asc" => tăng dần, "desc" => giảm dần]</param>
        public void QuickSortByName(string typeSort)
        {
            LinkedList l1, l2; //tạo 2 danh sách đầu và cuối
            Node tag, temp;
            MyProcess process = new MyProcess();

            if (this.PHead == this.PTail) return; //Kiểm tra danh sách có sắp xếp chưa
            //Khởi tạo 2 DSLK
            l1 = new LinkedList();
            l2 = new LinkedList();
            //cho node cờ bằng node đầu tiên
            tag = this.PHead;
            //Cập nhật lại DSLK hiện tại
            this.PHead = this.PHead.PNext;
            //Cô lập tag
            tag.PNext = null;
            //tách các node ra DS l1, l2 (l1: các node có data < tag) và (l2: các node có data > tag)
            while (this.PHead != null)
            {
                temp = this.PHead;
                this.PHead = this.PHead.PNext;
                temp.PNext = null;
                if (typeSort.Equals("asc")) //sắp xếp tăng dần
                {
                    if (process.CompareTwoString(temp.Data.Name, tag.Data.Name) != 1)
                        l1.AddHead(temp);
                    else l2.AddHead(temp);
                }
                else //sắp xếp giảm dần
                {
                    if (process.CompareTwoString(temp.Data.Name, tag.Data.Name) == 1)
                        l1.AddHead(temp);
                    else l2.AddHead(temp);
                }
            }

            //Gọi đệ quy sắp xếp l1, l2
            if (typeSort.Equals("asc"))
            {
                l1.QuickSortByName("asc");
                l2.QuickSortByName("asc");
            }
            else
            {
                l1.QuickSortByName("desc");
                l2.QuickSortByName("desc");
            }

            if (l1.PHead != null)
            {
                //l1 không rỗng
                this.PHead = l1.PHead;
                l1.PTail.PNext = tag;
            }
            else this.PHead = tag;
            tag.PNext = l2.PHead;

            this.PTail = l2.PHead != null ? l2.PTail : tag;
        }

        /// <summary>
        /// Sắp xếp DSLK theo tiêu chí đưa vào
        /// </summary>
        /// <param name="typeSort">Kiểu sắp xếp (asc, desc)</param>
        /// <param name="sortBy">Tiêu chí sắp xếp</param>
        public void Sort(string typeSort, string sortBy)
        {
            if (sortBy.Equals("salary"))
                this.QuickSortBySalary(typeSort);
            else if (sortBy.Equals("birthday"))
                this.QuickSortByBirthday(typeSort);
            else if (sortBy.Equals("office"))
                this.QuickSortByOffice(typeSort);
            else this.QuickSortByName(typeSort);
        }

        /// <summary>
        /// Thêm một node mới vào danh sách
        /// </summary>
        /// <param name="employeeNode">Node cần được thêm vào</param>
        /// <param name="sortBy">Tiêu chí sắp xếp</param>
        /// <param name="typeSort">Kiểu sắp xếp ["asc" => tăng dần, "desc" => giảm dần]</param>
        public void Insert(Node employeeNode, string sortBy, string typeSort)
        {
            this.AddTail(employeeNode);
            this.Sort(typeSort, sortBy);
        }

        /// <summary>
        /// Copy một node sang DSLK khác
        /// </summary>
        /// <param name="listAdd">DSLK cần thêm node mới vào</param>
        /// <param name="nodeCopy">Node cần copy</param>
        public void CopyNodeAddToList(ref LinkedList listAdd, Node nodeCopy)
        {
            Employee itemEmployee = new Employee(nodeCopy.Data);
            Node itemNode = new Node(itemEmployee);
            listAdd.AddTail(itemNode);
        }

        /// <summary>
        /// Tìm kiếm theo từ khóa
        /// </summary>
        /// <param name="l">Danh sách cần tìm kiếm</param>
        /// <param name="searchBy">Tìm kiếm theo tiêu chí nào</param>
        /// <param name="keyword">Từ khóa cần tìm</param>
        /// <returns>Trả về DSLK chứa các node nếu tìm thấy, còn không thì trả về DSLK rỗng</returns>
        public LinkedList Search(string keyword)
        {
            LinkedList result = new LinkedList();

            for (Node nodeIndex = this.PHead; nodeIndex != null; nodeIndex = nodeIndex.PNext)
            {
                if (nodeIndex.Data.Name.ToUpper().Contains(keyword.ToUpper()) || nodeIndex.Data.Office.ToUpper().Equals(keyword.ToUpper()) || nodeIndex.Data.Birthday.ToString().Equals(keyword) || nodeIndex.Data.Salary.ToString().Equals(keyword))
                {
                    CopyNodeAddToList(ref result, nodeIndex);
                }
            }
            return result;
        }

        /// <summary>
        /// Lấy vị  trí của obj Employee trong DSLK
        /// </summary>
        /// <param name="l"></param>
        /// <param name="objEmployee"></param>
        /// <returns></returns>
        public int IndexOf(Employee objEmployee)
        {
            int index = 0;
            for (Node nodeIndex = this.PHead; nodeIndex != null; nodeIndex = nodeIndex.PNext)
            {
                index++;
                if (objEmployee.Equals(nodeIndex.Data))
                {
                    return index;
                }
            }
            return -1;
        }

        public void EmptyList()
        {
            this.PHead = this.PTail = null;
        }
    }
}
