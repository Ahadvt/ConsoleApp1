using ConsoleApp1.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Servis
{
    static class Menyuservices
    {
        public static Groupservices groupservices = new Groupservices();

        public static void CreatGroupMenyu()
        {
            Console.WriteLine("please choose yourcategory");

            foreach (var c in Enum.GetValues(typeof(EdCategory)))
            {
                Console.WriteLine($"{(int)c}.{c}");

            }
            int category;
            string catestr = Console.ReadLine();
            bool resulcate = int.TryParse(catestr, out category);


            if (resulcate)
            {
                switch (category)
                {
                    case 1:

                        string Cat = groupservices.CreatGroup(EdCategory.Programing);
                        Console.WriteLine($"programing group created");

                        break;
                    case 2:

                        Cat = groupservices.CreatGroup(EdCategory.Marketing);
                        Console.WriteLine($"marketing group created");

                        break;
                    case 3:

                        Cat = groupservices.CreatGroup(EdCategory.Design);
                        Console.WriteLine($"design group created");

                        break;

                    default:
                        break;
                }
            }
        }

       public static void EditGroupMenyu( )
        {
            Console.WriteLine("please ad valid no");
            string no = Console.ReadLine();

            Console.WriteLine("please add new no");
            string newno = Console.ReadLine();
            groupservices.EditGroup(no, newno);
        }

        public static void GetAllGroupLIstm()
        {
            groupservices.GetGrouplists();
        }

        public static void GetStuOfGroupm()
        {
            Console.WriteLine("please add the group");
            String NO = Console.ReadLine();
            groupservices.GetStuOfGroup(NO);
        }
         public static void GetAllStum()
        {
            groupservices.GetAllStu();
        }

        public static void CreatStudentm()
        {
            Console.WriteLine("please enter your fullname");
            string Fulname = Console.ReadLine();


            Console.WriteLine("please choose your education typr");
            foreach (var a in Enum.GetValues(typeof(EducationType)))
            {
                Console.WriteLine($"{(int)a}.{a}");

            }

            Console.WriteLine("please enter group no");
            string groupno = Console.ReadLine();

            groupservices.CreatStudent(Fulname, EducationType.guaranteed, groupno);


        }
    } 
}