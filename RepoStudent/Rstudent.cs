using System;
using System.Collections.Generic;
using System.Linq;
using ModelApi;

namespace RepoStudent
{
    public class Rstudent
    {
        public static List<Student> _liststudent = new List<Student>()
        {
            new Student() {Dni = 11111111, Name="Samuel", LastName= "Jackson", Course = "Programación V",Year = 2020},
            new Student() {Dni = 22222222, Name="Kurt", LastName= "Cobija", Course = "Programación V",Year = 2020}
        };

        public IEnumerable<Student> ReturnStudent()
        {
            return _liststudent;
        }
        public Student ReturnStudentDni(int dni)
        {
            var student = _liststudent.Where(x => x.Dni == dni);
            return student.FirstOrDefault();
        }

        public void Add(Student student)
        {
            _liststudent.Add(student);
        }
    }
}
