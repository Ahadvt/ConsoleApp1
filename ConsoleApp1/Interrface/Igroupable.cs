using ConsoleApp1.enums;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    interface Igroupable
    {
        public List<AGroup> _groups { get;}
        public List<Student> students { get;  }
        string CreatGroup(EdCategory category);
        void GetGrouplists();
        void EditGroup(string no, string newno);
        void GetStuOfGroup(string no);
        void GetAllStu();
        string CreatStudent(string fullname, EducationType educationType, string groupno);

    }
}
