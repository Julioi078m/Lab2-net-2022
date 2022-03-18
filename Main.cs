using Laboratorio2.Entities;
using System;
public class Program
{
    public static void Main(string[] args)
    {
         Console.WriteLine("prueba");
         Alumno alumno = new Alumno("1234 123casd123", "15", new Persona("123asdf", "test", "test", "test@mail.com"));
         Alumno alumno1 = new Alumno("1234 123casd123", "15", new Persona("123asdf", "test", "test", "test@mail.com"));
         Alumno alumno2 = new Alumno("1234 123casd123", "15", new Persona("123asdf", "test", "test", "test@mail.com"));
         Alumno alumno3 = new Alumno("1234 123casd123", "15", new Persona("123asdf", "test", "test", "test@mail.com"));
         Alumno alumno4 = new Alumno("1234 123casd123", "15", new Persona("123asdf", "test", "test", "test@mail.com"));
         Alumno alumno5 = new Alumno("1234 123casd123", "15", new Persona("123asdf", "test", "test", "test@mail.com"));
         Alumno alumno6 = new Alumno("1234 123casd123", "15", new Persona("123asdf", "test", "test", "test@mail.com"));
         Alumno alumno7 = new Alumno("1234 123casd123", "15", new Persona("123asdf", "test", "test", "test@mail.com"));

        alumno.tomarAsistencia(1);

        Console.WriteLine("alumno 1 asistencia "+ alumno.asistencia + " "+ alumno.CUI);
        
    }
}