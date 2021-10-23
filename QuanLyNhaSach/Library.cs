using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach
{
    class Library
    {
        public string changeDate(string name)
        {
            string day = "";
            switch (name)
            {
                case "Monday":
                    day = "Thứ hai";
                    break;
                case "Tuesday":
                    day = "Thứ ba";
                    break;
                case "Wednesday":
                    day = "Thứ tư";
                    break;
                case "Thursday":
                    day = "Thứ năm";
                    break;
                case "Friday":
                    day = "Thứ sáu";
                    break;
                case "Saturday":
                    day = "Thứ bảy";
                    break;
                default:
                    day = "Chủ nhật";
                    break;
            }
            return day;
        }
    }
}
