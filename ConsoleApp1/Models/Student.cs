using ConsoleApp1.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Student
    {
        public static int scount = 0;
        public string Fullname { get; set; }
        public EducationType EdType { get; set; }
        public string GroupNO { get; set; }

        public Student(string fullname, EducationType educationType,string groupno)
        {
            Fullname = fullname;
            EdType = educationType;
            GroupNO = groupno;

            switch (educationType)
            {
                case  EducationType.guaranteed:
                    groupno = "guaranted" + scount; ;
                    break;
                case EducationType.unsecured:
                    groupno = "unsecured"+scount;
                    break;
                default:
                    break;
            }
        }
       
        
    }
}
