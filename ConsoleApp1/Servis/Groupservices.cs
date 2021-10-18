using ConsoleApp1.enums;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Servis
{
    class Groupservices : Igroupable
    {
        private List<AGroup> _agroup = new List<AGroup>();
        public List<AGroup> _groups => _agroup;
        private List<Student> _student = new List<Student>();
        public List<Student> students => _student;
        public string CreatGroup(EdCategory category)
        {
            AGroup group = new AGroup(category);
            _agroup.Add(group);
            return group.No;
        }

        public string CreatStudent(string fullname, EducationType educationType, string groupno)
        {
            Student student = new Student(fullname, educationType,groupno);
            _student.Add(student);
            
            return student.ToString();    
        }

        public void EditGroup(string no,string newno)
        {
            
                AGroup exgroup = FindGroup(no);
                if (exgroup == null)
                {
                    Console.WriteLine($"{no}there is no group");
                    return;
                }
            foreach (AGroup group in _agroup)
            {
                if (group.No.ToString().Trim()==newno.ToLower().Trim())
                {
                    Console.WriteLine($"{newno} alrady created");
                    return;
                }
            }
            exgroup.No = newno.ToUpper();
            Console.WriteLine($"{no} Changed to {newno}");
                
            
           
        }

        public AGroup FindGroup(string no)
        {
            foreach (AGroup group in _agroup)
            {
                if (group.No.ToLower().Trim() == no.ToLower().Trim())
                {
                    return group;
                }
            }
            return null;
        }

        public void GetAllStu()
        {
            foreach (Student stu in _student)
            {
                Console.WriteLine($"{stu.Fullname},{stu.GroupNO}");
                return;
            }
            
        }

        public void GetGrouplists()
        {
            foreach (AGroup group in _agroup)

            {
                Console.WriteLine($"{group.Category},{group.No},{group.Students}");
                return;
            }
        }

        public void GetStuOfGroup(string no)
        {
            foreach (var group in _groups)
            {
                if (group.No.ToLower().Trim() != no.ToLower().Trim())
                {
                    Console.WriteLine("there is no group");
                    return;
                }
                
                Console.WriteLine(group.Students);

            }
        }
    }
}
