using System;

namespace INF512_Unidad1
{
    
    public class Estudiante
    {
        
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Carrera { get; set; }

      
        private double indiceAcademico;

        
        public Estudiante(string nombre, string matricula, string carrera)
        {
            Nombre = nombre;
            Matricula = matricula;
            Carrera = carrera;
            indiceAcademico = 0.0;
        }

       
        public void Estudiar(string materia)
        {
            Console.WriteLine($"{Nombre} está estudiando {materia}.");
        }

        public void ActualizarIndice(double nuevoIndice)
        {
            if (nuevoIndice >= 0 && nuevoIndice <= 4.0)
            {
                indiceAcademico = nuevoIndice;
                Console.WriteLine($"Índice actualizado a: {indiceAcademico}");
            }
            else
            {
                Console.WriteLine("Error: El índice debe estar entre 0 y 4.0");
            }
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante est1 = new Estudiante(
                "Jeffry Gilma",
                "2024-001",
                "Ingeniería en Sistemas"
            );

            Console.WriteLine("Datos del estudiante:");
            Console.WriteLine(est1.Nombre);
            Console.WriteLine(est1.Matricula);
            Console.WriteLine(est1.Carrera);

            Console.WriteLine();

            est1.Estudiar("Programación en C#");
            est1.ActualizarIndice(3.7);

            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}

