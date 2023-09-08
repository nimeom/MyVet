using System;
using System.Collections.Generic;
using System.Text;

namespace MyVet.Common.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Registro { get; set; }
    }


    void func()
    {
        Student s = new Student();
        s.Id = 1;
        s.Nombre = "asf";
        s.Registro = DateTime.Now;

        string sql = $"INSERT INTO Students (ID, Nombre, Registro) VALUES ('{s.Id}', '{s.Nombre}', '{s.Registro}')";
    }
}
