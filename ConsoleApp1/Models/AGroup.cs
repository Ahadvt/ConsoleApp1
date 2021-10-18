using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.enums
{
    class AGroup
    {
        public static int count = 0;
        public string No { get; set; }
        public EdCategory Category { get; set; }
        public string Isonline { get; set; }
        public int Limit { get; set; }
        public List<Student> Students { get; set; }


        public AGroup(EdCategory category)
        {
            switch (Category)
            {
                case EdCategory.Programing:
                    No = "p-223"+count;
                    break;
                case EdCategory.Marketing:
                    No = "m-224"+count;
                    break;
                case EdCategory.Design:
                    No = "d-123"+count;
                    break;
                default:
                    break;
            }
        }
    }
}
