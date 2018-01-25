using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapCoSo
{
    public class Date
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        /// <summary>
        /// Kiểm tra date có hợp lệ
        /// </summary>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        private static bool ValidateDate(int day, int month, int year)
        {
            if (year <= 0) return false;
            if (month < 1 || month > 12) return false;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: return day > 0 && day <= 31;
                case 4:
                case 6:
                case 9:
                case 11: return day > 0 && day <= 30;
                case 2:
                    {
                        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)) // là năm nhuận
                            return day > 0 && day <= 29;
                        else return day > 0 && day <= 28;
                    }
                default: return false;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        public Date(int day, int month, int year)
        {
            if (ValidateDate(day, month, year))
            {
                this.Day = day;
                this.Month = month;
                this.Year = year;
            }
            else
            {
                this.Day = 0;
                this.Month = 0;
                this.Year = 0;
            }
        }

        /// <summary>
        /// Chuyển chuỗi dạng dd/mm/YYYY sang kiểu obj Date
        /// </summary>
        /// <param name="dateString">Chuỗi date cần chuyển</param>
        /// <returns></returns>
        public static Date ParseDate(string dateString)
        {
            int day, month, year;
            string[] arrDate = dateString.Split('/');
            day = int.Parse(arrDate[0]);
            month = int.Parse(arrDate[1]);
            year = int.Parse(arrDate[2]);
            return new Date(day, month, year);
        }

        /// <summary>
        /// So sánh Date
        /// </summary>
        /// <param name="objDate">object Date cần so sánh</param>
        /// <returns>-1: nhỏ hơn, 0: bằng, 1: lớn hơn</returns>
        public int CompareTo(Date objDate)
        {
            if (this.Year > objDate.Year)
                return 1;
            else if (this.Year == objDate.Year)
            {
                if (this.Month > objDate.Month)
                    return 1;
                else if (this.Month == objDate.Month)
                {
                    if (this.Day > objDate.Day) return 1;
                    else if (this.Day == objDate.Day) return 0;
                    else return -1;
                }
                else return -1;
            }
            else return -1;
        }

        /// <summary>
        /// Hiển thị date theo format
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string printDate = "";
            if (this.Day < 10)
            {
                if (this.Month < 10)
                    printDate += "0" + this.Day + "/0" + this.Month + "/" + this.Year;
                else printDate += "0" + this.Day + "/" + this.Month + "/" + this.Year;
            }
            else if (this.Month < 10)
                printDate += this.Day + "/0" + this.Month + "/" + this.Year;
            else printDate += this.Day + "/" + this.Month + "/" + this.Year;
            return printDate;
        }

    }
}
