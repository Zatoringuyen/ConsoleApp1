// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Tạo danh sách học sinh
        List<Student> students = new List<Student>
        {
            new Student { Id = 01, Name = "Anh", Age = 16 },
            new Student { Id = 02, Name = "Binh", Age = 14 },
            new Student { Id = 03, Name = "Dung", Age = 17 },
            new Student { Id = 04, Name = "Nam", Age = 15 },
            new Student { Id = 05, Name = "Phuong", Age = 18 }
        };

        // a. In danh sách toàn bộ học sinh
        Console.WriteLine("Danh sach toan bo hoc sinh: ");
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        // b. Tìm học sinh có tuổi từ 15 đến 18
        Console.WriteLine("\nHoc sinh có tuoi tu 15 đen 18: ");
        var ageFilter = students.Where(s => s.Age >= 15 && s.Age <= 18);
        foreach (var student in ageFilter)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        // c. Tìm học sinh có tên bắt đầu bằng chữ "A"
        Console.WriteLine("\nHoc sinh co ten bat đau bang chu 'A': ");
        var nameFilter = students.Where(s => s.Name.StartsWith("A"));
        foreach (var student in nameFilter)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        // d. Tính tổng tuổi của tất cả học sinh
        int totalAge = students.Sum(s => s.Age);
        Console.WriteLine($"\nTong tuoi cua tat ca hoc sinh: {totalAge}");

        // e. Tìm học sinh có tuổi lớn nhất
        int maxAge = students.Max(s => s.Age);
        var oldestStudent = students.First(s => s.Age == maxAge);
        Console.WriteLine($"\nHoc sinh co tuoi lon nhat: ID: {oldestStudent.Id}, Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");

        // f. Sắp xếp danh sách học sinh theo tuổi tăng dần
        Console.WriteLine("\nDanh sach hoc sinh theo tuoi tang dan: ");
        var sortedStudents = students.OrderBy(s => s.Age);
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }
    }
}