using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trimestre_3_act_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nMENU" +
                "\n1. Leer un número por teclado y definir si es par o impar" +
                "\n" +
                "\n2. Leer un número por teclado y generar las Tabla de multiplicar de ese número del 1 al 10" +
                "\n" +
                "\n3. Generar las tablas de multiplicar del 2 al 9, cada una del 1 al 10" +
                "\n" +
                "\n4. Leer un número por teclado y definir si es primo o no" +
                "\n" +
                "\n5. Dado el vector edad = [12,50,23,10,18,35,41,85,16,45], ordenarlos en forma ascendiente" +
                "\n" +
                "\n6. Datos los vectores" +
                "\nedad = [12, 50, 23, 10, 18, 35, 41, 85, 16, 45]" +
                "\nnombre = [juan, maria, tereza, pedro, javier, ana, diana, jorge, dayana, lady]" +
                "\nLeer un nombre por teclado y definir si existe, y en caso de existir mostrar su edad de lo contrario un mensaje" +
                "\nque el nombre no existe" +
                "\n" +
                "\n7. Partiendo de los vectores anteriores buscar el menor y el mayor y presentar sus respectivos nombres" +
                "\ncon su edad." +
                "\n" +
                "\n8. Dado una palabra definir si es palíndromo o no." +
                "\n");

            int Menu;
            Console.WriteLine("Digite el indice del programa que desea utilizar.");
            Menu = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (Menu)
            {
                case 1:

                    Console.WriteLine("Digite un numero");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    int modulo = numero % 2;
                    if (modulo == 0)
                    {
                        Console.WriteLine("El numero ingresado es par.");
                    }
                    else
                    {
                        Console.WriteLine("El numero ingresado es impar.");
                    }
                    break;
                case 2:
                    Console.WriteLine("Digite el numero del cual quiere saber las tablas de multiplicar.");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    for (int i = 1; i <= 10; i++)
                    {
                        int resultado = num * i;
                        Console.WriteLine(num + "*" + i + "=" + resultado);
                    }
                    break;
                case 3:
                    for (int i = 2; i <= 9; i++)
                    {
                        Console.WriteLine("\n");
                        for (int j = 1; j <= 10; j++)
                        {
                            
                            int resultado = i * j;
                            Console.WriteLine(i + "*" + j + "=" + resultado);
                        }

                    }
                    break;
                case 4:
                    Console.WriteLine("Digite un numero para saber si es primo o no.");
                    int n = Convert.ToInt32(Console.ReadLine());
                    int c = 0;
                    for (int i = 1; i <= n; i++)
                    {
                        if (n % i == 0)
                        {
                            c = c + 1;  
                        }
                    }
                    if (c > 2)
                    {
                        Console.WriteLine("No es primo");
                    }
                    else
                    {
                        Console.WriteLine("Es primo");
                    }
                    break;
                case 5:
                    
                    int[] edad = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
                    int t = edad.Length;
                    int temp;
                    
                    foreach (int elemento in edad)
                    {
                        Console.Write(elemento + "|");
                    }

                    Console.WriteLine("");
                    //Ordenar el vector de manera ascendente

                    for (int j = 0; j < edad.Length; j++)
                    {
                        for (int i = 0; i < t - 1; i++)
                        {

                            if (edad[i] > edad[i + 1])
                            {
                                temp = edad[i];
                                edad[i] = edad[i + 1];
                                edad[i + 1] = temp;
                            }

                        }
                    }
                    foreach (int elemento in edad)
                    {
                        Console.Write(elemento + "|");
                    }



                    break;
                case 6:
                    
                    string[] nombre = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady"};
                    int[] ed = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
                    Console.WriteLine("Digite un nombre");
                    string persona = Console.ReadLine();
                    for (int i = 0; i < nombre.Length; i++)
                    {
                        if (persona == nombre[i])
                        {
                            Console.WriteLine(persona + "-" + ed[i]);
                        }
                        else
                        {
                            Console.WriteLine("No existe");
                        }
                    }

                    break;
                case 7:
                    int temporal;
                    string tempnom;
                    string[] nombr = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
                    int[] eda = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };

                    Console.WriteLine(eda.Length);

                    for (int h = 0; h < eda.Length-1; h++)
                    {
                        for (int i = 0; i < eda.Length - 1; i++)
                        {
                            if (eda[i] < eda[i + 1])
                            {
                                temporal = eda[i];
                                eda[i] = eda[i + 1];
                                eda[i + 1] = temporal;
                                tempnom = nombr[i];
                                nombr[i] = nombr[i + 1];
                                nombr[i+1] = tempnom;

                            }
                        }
                    }
                    Console.Write(nombr[0] + "-" + eda[0]);
                    Console.WriteLine("");
                    Console.Write(nombr[9] + "-" + eda[9]);
                    
                    /*foreach (var elemento in eda)
                    {
                        Console.Write(elemento + "|");
                    }
                    Console.WriteLine("");
                    foreach (var elemento in nombr)
                    {
                        Console.Write(elemento + "|");
                    }*/

                    break;
                case 8:

                    string palabra, inverso, caracter;
                    int l;
                    Console.WriteLine("Digite una palabra");
                    palabra = Convert.ToString(Console.ReadLine());
                    l = palabra.Length;
                    inverso = "";

                    for (int i = l-1; i >= 0; i--)
                    {
                        caracter = palabra.Substring(i, 1);
                        inverso = inverso + caracter;
                    }
                    Console.WriteLine(inverso);
                    if (palabra == inverso)
                    {
                        Console.WriteLine("es palindromo");
                    }
                    else
                    {
                        Console.WriteLine("no es palindromo");
                    }
                    break;
            }


            Console.ReadKey();
        }
    }
}
