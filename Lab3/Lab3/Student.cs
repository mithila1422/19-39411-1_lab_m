﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Student
    {

        string name;
        string id;
        string department;
        float cgpa;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Id
        {
            set { id = value; }
            get { return id; }
        }

        public string Department
        {
            set { department = value; }
            get { return department; }
        }

        public float Cgpa
        {
            set { cgpa = value; }
            get { return cgpa; }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Student Name : " + Name);
            Console.WriteLine("ID : " + Id);
            Console.WriteLine("Department : " + Department);
            Console.WriteLine("CGPA : " + cgpa);


        }
    }
}
