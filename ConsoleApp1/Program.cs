using ConsoleApp1.enums;
using ConsoleApp1.Servis;
using System;

namespace ConsoleApp1
{
    class Program
    {
        private static EdCategory isonline;

        static void Main(string[] args)
        {
            Console.WriteLine("***********************");
            Console.WriteLine();

            int selection;
            do
            {
                Console.WriteLine("hello welcome to console aplication of course");
                Console.WriteLine("***********************");
                Console.WriteLine();
                Console.WriteLine("1.Creat New Group");
                Console.WriteLine("2.Edit Group");
                Console.WriteLine("3.Get All Group LIst");
                Console.WriteLine("4.Get Students Of Group");
                Console.WriteLine("5.Get All Of The Students");
                Console.WriteLine("6.Creat New Students");
                Console.WriteLine("0.exit");

                
                string selecstr = Console.ReadLine();
                bool result = int.TryParse(selecstr, out selection);
                if (result)
                {
                    switch (selection)
                    {
                        case 1:
                            Menyuservices.CreatGroupMenyu();

                            break;
                        case 2:
                            Menyuservices.EditGroupMenyu();
                            break;
                        case 3:
                            Menyuservices.GetAllGroupLIstm();
                            break;
                        case 4:
                            Menyuservices.GetStuOfGroupm();
                            break;
                        case 5:
                            Menyuservices.GetAllStum();
                            break;
                        case 6:
                            Menyuservices.CreatStudentm();
                            break;

                        default:
                            break;
                    }
                }

            } while (selection!=0);
        }
    }
}
