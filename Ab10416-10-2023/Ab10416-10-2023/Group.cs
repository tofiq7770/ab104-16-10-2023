using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab10416_10_2023
{
    public class Group
    {
        public static Group[] Groups = new Group[123];
        private static int groupCount = 0;

        public int GroupId { get; private set; }
        public string GroupName { get; set; }
        public Student[] Students { get; private set; }

        public Group(string groupName)
        {
            GroupId = groupCount + 1;
            GroupName = groupName;
            Students = new Student[123];
            Groups[groupCount++] = this;
        }

        public string GetGroupInfo()
        {
            return $"Group {GroupId}: {GroupName}, Total Students: {Students.Length}";
        }

        public Student GetStudent(int id)
        {
            return Students.FirstOrDefault(s => s != null && s.Id == id);
        }

        public void AddStudent(Student student)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i] == null)
                {
                    Students[i] = student;
                    break;
                }
            }
        }

        public void RemoveStudent(int id)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i] != null && Students[i].Id == id)
                {
                    Students[i] = null;
                    break;
                }
            }
        }

        public void Search(string searchText)
        {
            Console.WriteLine($"Search results for '{searchText}':");
            foreach (var student in Students)
            {
                if (student != null && (student.Name.Contains(searchText) || student.Surname.Contains(searchText)))
                {
                    Console.WriteLine(student.GetInfo());
                }
            }
        }

        public void ShowStudents()
        {
            Console.WriteLine($"Students in Group {GroupId} - {GroupName}:");
            foreach (var student in Students)
            {
                if (student != null)
                {
                    Console.WriteLine(student.GetInfo());
                }
            }
        }

        public static void ShowAllGroups()
        {
            Console.WriteLine("List of all groups:");
            for (int i = 0; i < groupCount; i++)
            {
                if (Groups[i] != null)
                {
                    Console.WriteLine(Groups[i].GetGroupInfo());
                }
            }
        }

        public static void AddGroup(Group group)
        {
            if (groupCount < Groups.Length)
            {
                Groups[groupCount++] = group;
            }
        }
    }

}
