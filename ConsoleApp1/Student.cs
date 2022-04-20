using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Student
    {
        private string _groupNo;
        public string FullName;
        public int Age;

        public Student(string no, string name,int age  )
        {
            No = no;
            Age = age;
            FullName = name;

        }
        public string No 
        {
            get => _groupNo;
            set
            {
                while (!CheckGroupNo(value))
                {
                    Console.WriteLine("error");
                    value = Console.ReadLine();
                }    
                _groupNo = value;



            }
        }

        static bool CheckGroupNo(string name)
        {
            if (name.Length == 4)
            {
                if (char.IsUpper(name[0]))
                {
                    bool check = false; 
                    for (int i = 1; i < name.Length; i++)
                    {
                        if (char.IsDigit(name[i]))
                        {
                            check = true;

                            return check;
                        }
                    }
                    Console.WriteLine("3 eded daxil et");
                }
                Console.WriteLine("1ci boyuk herf olmalidir");
            }
            Console.WriteLine("qrup adi 4 simvol olmalidi");

            return true;
        }
     
    }
   
}