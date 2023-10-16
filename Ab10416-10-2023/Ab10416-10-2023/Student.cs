using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab10416_10_2023
{
    public class Student : ICodeAcademy
    {
        private static int Count = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CodeEmail { get; set; }

        public Student(string name, string surname)
        {
            if (CheckName(name, surname))
            {
                Count++;
                Id = Count;
                Name = name;
                Surname = surname;
                GenerateEmail();
            }
            else
            {
                Console.WriteLine(("Name and Surname are not valid."));
            }
        }

            public string GetInfo()
            {
                return $"Id: {Id}, Name: {Name}, Surname: {Surname}";
            }

        public static bool CheckName(string name, string surname)
        {
            bool validName = !string.IsNullOrEmpty(name) && name.Length >= 3 && name.Length <= 25 && IsAlphabetic(name);
            bool validSurname = !string.IsNullOrEmpty(surname) && surname.Length >= 3 && surname.Length <= 25 && IsAlphabetic(surname);
            return validName && validSurname;
        }

        private static bool IsAlphabetic(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        public void GenerateEmail()
        {
            string email = $"{Name.ToLower()}.{Surname.ToLower()}{Id}@code.edu.az";
            CodeEmail = email;
        }
    }

}
