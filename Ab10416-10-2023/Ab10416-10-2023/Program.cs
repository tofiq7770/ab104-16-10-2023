using Ab10416_10_2023;
using System;

class Program
{
    static void Main(string[] args)
    {
        //task1
        //    var student = new Student("Murad", "Aliyev");
        //    if (student != null)
        //    {
        //        Console.WriteLine($"Id: {student.Id}");
        //        Console.WriteLine($"Name: {student.Name}");
        //        Console.WriteLine($"Surname: {student.Surname}");
        //        Console.WriteLine($"CodeEmail: {student.CodeEmail}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid.");
        //    }






        //task2

        //int num = 5;
        //Console.WriteLine($"{num} odd? {num.IsOdd()}");
        //Console.WriteLine($"{num} even? {num.IsEven()}");

        //string text = "Hello123";
        //Console.WriteLine($" {text} contain a digit? {text.HasDigit()}");

        //string password = "Password";
        //Console.WriteLine($" {password} correct password? {password.CheckPassword()}");

        //string sentence = "this is a test sentence";
        //Console.WriteLine($"Capitalized: {sentence.Capitalize()}");

        //task3

        Group group1 = new Group("Group A");
        Group group2 = new Group("Group B");

        Student student1 = new Student("Tofiq", "Nasibli");
        Student student2 = new Student("Ali", "Huseynov");
        Student student3 = new Student("Ali", "Shukurlu");
        Student student4 = new Student("Super", "Mario");

        group1.AddStudent(student1);
        group1.AddStudent(student2);
        group2.AddStudent(student3);
        group2.AddStudent(student4);

        Group.ShowAllGroups();

        Console.WriteLine();
        group1.ShowStudents();

        Console.WriteLine();
        group2.ShowStudents();

        Console.WriteLine();
        group1.Search("Tofiq");

        Console.WriteLine();
        group1.RemoveStudent(2);
        group1.ShowStudents();

    }
}
