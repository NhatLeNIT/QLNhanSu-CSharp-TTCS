using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapCoSo
{
    public class Node
    {
        public Employee Data { get; set; }
        public Node PNext { get; set; }

        /// <summary>
        /// Khởi tạo node
        /// </summary>
        public Node()
        {
            Data = new Employee();
            PNext = null;
        }

        /// <summary>
        /// Khởi tạo node với nhân viên truyền vào
        /// </summary>
        public Node(Employee objEmployee)
        {
            Data = objEmployee;
            PNext = null;
        }
    }
}
