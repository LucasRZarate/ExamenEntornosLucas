using System;

namespace Libreria
{    
    /// <summary>
    /// Clase Asignatura
    /// </summary>
    public class Asignatura
    {
        /// <summary>
        /// Almacena el codigo de la asignatura
        /// </summary>
        private string codigoAsignatura { get; set; }

        /// <summary>
        /// Almacena el nombre de la asignatura
        /// </summary>
        private string nombreAsignatura { get; set; }

        /// <summary>
        /// Almacena la nota del primer trimestre
        /// </summary>
        private double notaPrimerTrismestre { get; set; }

        /// <summary>
        /// Almacena la nota del segundo trimestre
        /// </summary>
        private double notaSegundoTrismestre { get; set; }

        /// <summary>
        ///Almacena la nota del tercer trimestre
        /// </summary>
        private double notaTercerTrimestre { get; set; }

        /// <summary>
        /// Almacena la nota final de la asignatura
        /// </summary>
        private double notaFinal { get; set; }

        ///<remarks>Se le ha añadido Properties a las variables, ademas de ponerlas en privado y cambiarles el nombre a uno mas legible</remarks>
             
        /// <summary>
        /// Ha este constructor se le ha cambiado el nombre de las variables a unas que no requieran usar this. para asignarse,
        /// ademas de ser mucho mas legibles y autocomprensivas
        /// </summary>
        /// <param name="NuevoCodigo">Este parametro recibe el codigo que tendra la asignatura</param>
        /// <param name="NuevoNombre">Este parametro recibe el nombre de la asignatura</param>
        /// <param name="NotaPrimerTrismestre">Este parametro recibe la nota del primer trimestre</param>
        /// <param name="NotaSegundoTrismestre">Este parametro recibe la nota del segundo trimestre</param>
        /// <param name="NotaTercerTrismestre">Este parametro recibe la nota del tercer trimestre</param>
        /// <param name="NotaFinal">Este parametro recibe la nota final del curso</param>
        public Asignatura(string NuevoCodigo, string NuevoNombre, double NotaPrimerTrismestre, double NotaSegundoTrismestre, double NotaTercerTrismestre, double NotaFinal)
        {
            codigoAsignatura = NuevoCodigo;
            nombreAsignatura = NuevoNombre;
            notaPrimerTrismestre = NotaPrimerTrismestre;
            notaSegundoTrismestre = NotaSegundoTrismestre;
            notaTercerTrimestre = NotaTercerTrismestre;
            notaFinal = NotaFinal;
        }

        /// <summary>
        /// Este constructor sirve para crear una asignatura sin notas
        /// </summary>
        /// <param name="NuevoCodigo">Este parametro recibe el codigo que tendra la asignatura</param>
        /// <param name="NuevoNombre">Este parametro recibe el nombre de la asignatura</param>
        public Asignatura(string NuevoCodigo,string NuevoNombre)
        {
            codigoAsignatura = NuevoCodigo;
            nombreAsignatura = NuevoNombre;
        }       

        /// <summary>
        /// La funcion sirve para introducir una asignatura
        /// </summary>
        /// <param name="CodAsignatura">Este parametro almacena el codigo de la asignatura</param>
        /// <param name="NombreAsignatura">Este parametro almacena el nombre de la asignatura</param>
        /// <remarks>Se le ha cambiado el nombre de la funcion para que sea mas intuitivo</remarks>
        public void IntroducirAsignatura(string CodAsignatura, string NombreAsignatura)
        {
            codigoAsignatura = CodAsignatura;
            nombreAsignatura = NombreAsignatura;
        }

        /// <summary>
        /// Con esta funcion puedes introduciar las nota de una asignatura a traves de la peticion de la consola
        /// </summary>
        /// <remarks>Esta funcion ha sufrido diversos cambios, ya no recibe parametros, sino que te los pide la consola directamente</remarks>
        public void IntroducirlasNotas()
        {
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Trimestre evaluado 1, 2 ó 3: ");
                var Trimestre = Console.ReadLine();
                Console.WriteLine("Nota de las prácticas: ");
                double notaPracticas = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Nota del examen: ");
                double notaExamen = Convert.ToDouble(Console.ReadLine());
                switch (Trimestre)
                {
                    case "1":
                        CalcularPrimerTrismestre(notaPracticas, notaExamen);
                        return;
                    case "2":
                        CalcularSegundoTrimestre(notaPracticas, notaExamen);
                        return;
                    case "3":
                        CalcularTercerTrimetre(notaPracticas, notaExamen);
                        return;
                }
            }
        }

        /// <summary>
        /// La funcion calcula la nota del primer trimestre
        /// </summary>
        /// <param name="notaExamen">Este parametro almacena la nota del examen</param>
        /// <param name="notaPracticas">Este parametro almacena la nota de las practicas</param>
        /// <returns>Devuelve un numero real que contiene el calcualo del 80% del examen + el 20% de las practicas</returns>
        public double CalcularPrimerTrismestre(double notaExamen, double notaPracticas)
        {
            return notaPrimerTrismestre = (notaExamen * 0.8) + notaPracticas * 0.2;
        }

        /// <summary>
        /// La funcion calcula la nota del segundo trimestre
        /// </summary>
        /// <param name="notaExamen">Este parametro almacena la nota del examen</param>
        /// <param name="notaPracticas">Este parametro almacena la nota de las practicas</param>
        /// <returns>Devuelve un numero real que contiene el calcualo del 80% del examen + el 20% de las practicas</returns>
        public double CalcularSegundoTrimestre(double notaExamen, double notaPracticas)
        {
            return notaSegundoTrismestre = (notaExamen * 0.8) + notaPracticas * 0.2;
        }

        /// <summary>
        /// La funcion calcula la nota del tercer trimestre
        /// </summary>
        /// <param name="notaExamen">Este parametro almacena la nota del examen</param>
        /// <param name="notaPracticas">Este parametro almacena la nota de las practicas</param>
        /// <returns>Devuelve un numero real que contiene el calcualo del 80% del examen + el 20% de las practicas</returns>
        public double CalcularTercerTrimetre(double notaExamen, double notaPracticas)
        {
            return notaTercerTrimestre = (notaExamen * 0.8) + notaPracticas * 0.2;
        }

        /// <summary>
        /// Calcula la nota final del curso
        /// </summary>
        /// <returns>Un numero real que representa la nota final del curso</returns>
        public double CalcularNotaFinal()
        {
            return notaFinal = (notaPrimerTrismestre + notaSegundoTrismestre + notaTercerTrimestre) / 3;
        }

        //Las funciones de calculo trimestral han sufrido un cambio en el nombre de las variables para que sea mas entendible

        //Todo el codigo tenia una mala tabulacion y mal diseño, asique ha sido solucionado
    }
    class Program
    {
        static void main()
        {
            ///<example>Con esto tienes un ejemplo de como se crea una asignatura sin las notas</example>
            Asignatura mi_asignatura_ejemplo = new Asignatura("0521385", "Entornos  de Desarrollo");

            ///<example>Este ejemplo es para crear una asignatura con notas</example>
            Asignatura asignatura2 = new Asignatura("2741029", "Lenguaje de Marcas", 5, 5, 5, 5);
        }
    }
}
