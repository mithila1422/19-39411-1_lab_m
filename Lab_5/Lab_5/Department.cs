using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Department
    {
        
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
             
        private string id;

        public string Id
             {
            get  {return id;}
               set  {id=value;}
             }
        private Student[] students;

        public void AddStudent (Student s)
        {
            students [studentCount++] = s;
            
        
        }
        public void PrintStudent()
        {
            for (int i = 0; i < studentCount; i++)
            {
                students[i].ShowInfo();
            }
        }
        public Student GetStudent(string id)
        {
            return null;
        }
        public int studentCount;
        public int StudentCount
        {
            get { return studentCount; }
            set { studentCount = value; }
        }

       public Department(){
           students = new Student[50];
       }

        public Department(string name,string id){
    this.name=name;
        this.id=id;
        students = new Student[50];
    
    }

    public void ShowInfo(){
    Console.WriteLine("Name:"+name);
    Console.WriteLine("Id:"+id);
   
    }

    }
}
