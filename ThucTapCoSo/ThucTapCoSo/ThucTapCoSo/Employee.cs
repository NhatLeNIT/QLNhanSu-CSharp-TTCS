using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapCoSo
{
    public class Employee
    {
        public string Name { get; set; }
        public string Office { get; set; }
        public Date Birthday { get; set; }
        public double Salary { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Employee()
        {
            Name = "";
            Office = "";
            Birthday = new Date(0,0,0);
            Salary = 0;
        }

        /// <summary>
        /// Parameter Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="office"></param>
        /// <param name="birthday"></param>
        /// <param name="salary"></param>
        public Employee(string name, string office, Date birthday, double salary)
        {
            this.Name = name;
            this.Office = office;
            this.Birthday = birthday;
            this.Salary = salary;
        }

        /// <summary>
        /// Copy Constructor
        /// </summary>
        /// <param name="e"></param>
        public Employee(Employee e) : this(e.Name, e.Office, e.Birthday, e.Salary)
        {
        }

        /// <summary>
        /// Hiển thị thông tin tóm tắt của nhân viên
        /// </summary>
        /// <returns></returns>
        public string Display()
        {
            return this.Name + " - Chức vụ: " +this.Office;
        }

        /// <summary>
        /// So sánh 2 đối tượng có giống nhau không
        /// </summary>
        /// <param name="objEmployee"></param>
        /// <returns></returns>
        public bool Equals(Employee objEmployee)
        {
            if (this.Name == objEmployee.Name && this.Office == objEmployee.Office &&
                this.Birthday.CompareTo(objEmployee.Birthday) == 0 && this.Salary == this.Salary)
                return true;
            return false;
        }
    }
}
