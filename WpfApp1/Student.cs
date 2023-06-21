using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Student
    {
        public Student(string avatar, string nasurfath, int average, string comment, int attendance)
        {
            id = ++ID;
            this.avatar = avatar;
            this.nasurfath = nasurfath;
            this.average = average;
            this.comment = comment;
            this.attendance = attendance;
        }

        public static int ID { get; set; } = 0;
        public int id { get; set; }
        public string avatar { get; set; }
        public string nasurfath { get; set; }
        public int average { get; set; }
        public string comment { get; set; }
        public int attendance { get; set; }

        
    }
}
