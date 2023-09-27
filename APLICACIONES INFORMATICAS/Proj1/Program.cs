// See https://aka.ms/new-console-template for more information

using System;

namespace SintaxisBasica;  // otra forma de poner el namespace 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! y ya");

        //tIPOS DE DATOS 

        string fecha1 = "2020-12-12";

        int num1 = -120;
        float num2 = 12.324f;
        double num3 = 124.12343;

        num1++;
        num1--;
        num1 += 12;

        //valores dinamicos 
            dynamic val_dinamico = 12;
            val_dinamico = "Hola como estas";
        
        //var, permite no definir los tipos de datos de las varibbles PRIMITAVAS
            var dato1 = "Hola pe !!";
            var dato2 = 12;


        bool ban = true;

        if (ban) Console.WriteLine($"MI nacimiento es: {fecha1}");

        Console.WriteLine(num1 + " ");

        Console.WriteLine(CalculateProm(num2,num3));

        //CONSTATNES

        const int FIN = 9999;
        //Console.WriteLine(FIN);


        //estructuras de datos 

        Console.WriteLine($"\t\tINgresar el tamanio del array ");

        int tam = int.Parse(Console.ReadLine());            //Ingreso de datos

        Console.WriteLine($"Tamanio del array es de {tam}");


        int[] vec1 = new int[tam];      //Incializandole el tamaño

        int a = 1;

            //Bucles
            for (int i = 0; i < vec1.Length; i++)
            {
                vec1[i] = a;
                Console.WriteLine(vec1[i]);
                a *= 2;
            }

            foreach (int i in vec1) Console.WriteLine(i);  //para estructuras con elementos dentro 


        var vec2 = new string[]{"fein", "hola que haces pe mano ", "que cosa"};     //inicializando con valores


        Console.WriteLine($"\n{vec2.Length}");

        //DICCIONARIOS, claves valor 
        var Dictionarity1 = new Dictionary<string, double>
        {
            {"EEFF", 12 },
            {"Mate", 14},
            {"Gym", 134 }
        };

        Console.WriteLine("IMPRIMIR DICCIONARIO");
        foreach (var i in Dictionarity1) Console.WriteLine(i);

        //SETs, no es indexado y elimina datos redundantes

        var Set1 = new HashSet<int> { 12, 12, 32, 424 };

        Console.WriteLine("IMPRIMIR HASHSET");
        foreach (var i in Set1) Console.WriteLine(i);

        //TUPLAS, no son indexados y se accede a los elementos recorrinedo 

        var Tupla1 = (12, 12, 32, 424);

        Console.WriteLine("IMPRIMIR TUPLA");
        Console.WriteLine(Tupla1);


        Console.WriteLine($"\n\tOBJETOS Y CLASES ");

        var est1 = new Estudiante("Juan Perez", 22);
        est1.MostrarDatos(22);
        est1.MensjeError(22);

    }

    static double CalculateProm(double n1, double n2)
    {
        return n2 + n1;
    }


    class Estudiante
    {
        //Propierties
        private string Name { get; set; }
        private int Code { get; set; }

        //Methods

        public Estudiante(string name, int code)
        {
            //this.name = name;     solo cundo el nombre del parametro constructor sea igual a la propiedad(campo instancia )
            Name = name;
            Code = code;
        }

        public void MostrarDatos(int age)
        {
            Console.WriteLine($"Hola me llamo {Name} y tengo el codigo: {Code} y tengo {age} de dif");
        }

        public  void MensjeError(int edad)
        {
            if (edad <= 18) Console.WriteLine($"Lo siento no eres estudiante");
            else Console.WriteLine("Matriculado");
        }
    
    }
}

