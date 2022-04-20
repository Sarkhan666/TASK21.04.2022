using System;
using System.Collections.Generic;
using System.Text;

namespace Task_21._04._2022
{
   internal class Student
   {
        public string FullName;
        private string _GroupNo;
        public int Age;

        public string No
        { 
           get => _GroupNo;
           set
            
          while (!CheckGroupNo(value))
          {
                Console.WriteLine("error");
                value = Console.ReadLine();
          }
            _GroupNo = value;

        }
        static bool CheckGroupNo( string name)
        {
            if (name.Length == 4)
            {
                if (char.IsUpper(name[0]))
                {
                    bool check = false;
                }
                  for (int i = 1; i < name.Length; i++)
                  {
                    if (char.IsDigit(name[i]))
                    {
                        check = true;
                        return check;
                    }
                  }
                  Console.WriteLine("enter 3 digits");
            }
            Console.WriteLine("first letter must be uppercase");
            Console.WriteLine("group name must contain 4 characters");
            return true;
        }




            
        
   }
}
