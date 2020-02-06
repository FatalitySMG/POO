using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Punto 1
            /* short Segundos = 0;
             double Costo = 0.5, Total;


             Console.WriteLine("Ingrese la cantidad de minutos que ha consumido");
             Segundos = short.Parse(Console.ReadLine());
             if (Segundos <= 3)
             {
                 Total = (Costo);
             }
             else
             {
                 Total = (Costo + 0.1 * Segundos);
             }
             Console.WriteLine("Total a pagar: " + Total);*/

            // Punto 2
            /*
            double i = 0, n, Gauss = 0; 
            Console.WriteLine("Ingrese un numero positivo");
             n = double.Parse(Console.ReadLine());

            while(i < n)
            {
                Gauss = i*(i + 1) / 2;
                i++;
                Console.WriteLine("Esta es la sumatoria desde 1 hasta el valor que ingreso: " +Gauss + n);
            }
            */



            //Punto 3
            /*
             double i = 0, n, MultiplosDeTres = 0, m = 0;
             Console.WriteLine("Ingrese un numero positivo");
             n = double.Parse(Console.ReadLine());

             while(i < n)
             {
                 if (i % 3 == 0)
                 {
                     MultiplosDeTres = MultiplosDeTres + i;
                 }
                 i++;
             }

             //Otro ejemplo
             while (i < n)
             {
                 if (i % 3 == 0 && i != 3)
                 {
                     m++;
                     MultiplosDeTres = 3 * (m * (m + 1) / 2);


                 }
                 Console.WriteLine(MultiplosDeTres);
                 i++;
             }
             Console.WriteLine("Esta es la sumatoria desde 1 hasta el valor que ingreso: " + MultiplosDeTres);

             Console.ReadKey();
             */


            //Punto 4
            /* double Numero;

             Console.WriteLine("Ingrese un numero cualquiera para hallar su tabla de multiplicar hasta el 12");
             Numero = double.Parse(Console.ReadLine());

             for(short i = 1; i <= 12; i++)
             {
                 Console.WriteLine(Numero * i);
             } */

            //Punto 5

            /* short year = 2020,SumBisiesto;

             Console.WriteLine("Los proximos 20 a;os bisiestos son: ");
             for (short i = 0; i <= 20; i++)
             {
                 Console.WriteLine(year+=4);

             }
             */

            //Punto 6

            /*
            Random numero = new Random();

            Console.WriteLine("Cunatos datos quiere ingresar");
            int max = 0, n = int.Parse(Console.ReadLine());
            int[] numeros = new int[n];


            for(int i = 0; i <= 4; i++)
            {
                numeros[i] = numero.Next(0, 100);
                if(numeros[i] > max)
                {
                    max = numeros[i];
                }
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine(max);
            */

            //Punto 7
            /*
            Random numero = new Random();

            int max = 0, min = 100;
            int[] numeros = new int[100];


            for (int i = 0; i <= 99; i++)
            {
                numeros[i] = numero.Next(0, 1000);
                if (numeros[i] > max)
                {
                    max = numeros[i];
                }
                Console.WriteLine(numeros[i]);
                if (numeros[i] < min)
                {
                    min = numeros[i];
                }
            }
            Console.WriteLine("Maximo: "+max+ " Minimo: " + min);
            */

            //Punto 8

            /*
            double i = 0, n, Gauss = 0, multi = 1, j = 1;
            string funcion;

            Console.WriteLine("Escriba '+' si quiere hallar la suma o '*' si quiere hallar el producto de 1 hasta n");
            funcion = Console.ReadLine();
            Console.WriteLine("Ingrese un numero positivo");
            n = double.Parse(Console.ReadLine());

            if(funcion == "+")
            {
                while (i < n)
                {
                    Gauss = i * (i + 1) / 2;
                    i++;
                }
                Console.WriteLine("Esta es la sumatoria desde 1 hasta n que ingreso: " + (Gauss + n));
            }
            else
            {
                while (j <= n)
                {
                    multi = multi * j;
                    j++;
                }
                Console.WriteLine("Esta es la sumatoria desde 1 hasta n que ingreso: " + multi);
            }
            */

            //Punto 9
            /*
            Random notas = new Random();
            double i = 0, numNotas = 0, nota = 0, promG = 0, promP = 0, g = 0, p = 0;

            Console.WriteLine("Escriba la cantidad de notas que va a agregar: ");
            numNotas = int.Parse(Console.ReadLine());
            
            while (i < numNotas)
            {
                nota = notas.Next(0, 6);
                //Console.WriteLine(nota);
                if(nota >= 3)
                {
                    promG = promG + nota;
                    g++;
                    //Console.WriteLine("Prom:" + promG + " G " + g);
                }
                else
                {
                    promP = promP + nota;
                    p++;
                    //Console.WriteLine("Prom:" + promP + " G " + p);
                }
                i++;
            }
            Console.WriteLine("Promedio de los estudiantes que ganaron: " + (promG / g) + " Promedio de los estudiantes que perdieron " + (promP / p));
            */

            //Punto 10
            /*
            double i = 1, n, Gauss = 0;
            Console.WriteLine("Ingrese un numero positivo");
            n = double.Parse(Console.ReadLine());

            while (i <= n)
            {
                Gauss = (i * (i + 1) * ((2 * i) + 1)) / 6;
                i++;
                Console.WriteLine("Esta es la sumatoria desde 1 hasta el valor que ingreso: " + Gauss);
            }
            Console.WriteLine("Esta es la sumatoria desde 1 hasta el valor que ingreso: " + Gauss);
            */

            //Punto 11
            /*
            double precio = 0, descuento = 0;

            Console.WriteLine("Ingrese el valor de la prenda para saber el descuento que tiene: ");
            precio = double.Parse(Console.ReadLine());

            if (precio > 100000) descuento = precio * 0.1;
            else if (precio > 50000 && precio <= 100000) descuento = precio * 0.2;
            else descuento = 0;
            Console.WriteLine("El descuento es de: " + descuento + " Pesos, por lo tanto el valor total es " + (precio-descuento) + " Pesos");
            */

            //Punto 12
            /*
            Random horas = new Random();
            int i = 0, numH = 0, persona = 0;
            double valorH = 4571.890625;

            while (i < 20)
            {
                persona++;
                numH = horas.Next(0, 192);
                Console.WriteLine("La persona: " + persona + " ha trabajado: " + numH + " y el valor por hora teniendo en cuenta el smmlv es:" + valorH + " por lo tanto gano: " + (numH* valorH));
                i++;
            }
            */

            //Punto 13
            /*
            int i = 0, num = 0, nom = 0;
            Console.WriteLine("Ingrese un numero");

            while (i < 20)
            {
                num = int.Parse(Console.ReadLine());
                nom++;
                if(num <= 25)
                {
                    Console.WriteLine("El numero: " + nom + " de la lista de 20 numeros es menor o igual a 25 y el valor de este numero es: " + num);
                    i++;
                }
                else
                {
                    Console.WriteLine("El numero es superior a 25");
                }
                i++;
            }
            */

            //Punto 14
            /*
            Random numero = new Random();

            int max = 0, n = 100;
            int[] numeros = new int[n];


            for (int i = 0; i <= 99; i++)
            {
                numeros[i] = numero.Next(0, 100);
                if (numeros[i] % 3 == 0)
                {
                    max = max + numeros[i];
                    //Console.WriteLine(max);
                }
                //Console.WriteLine(numeros[i]);
            }
            Console.WriteLine(max);
            */

            //Punto 15
            /*
            double Numero = 1, sum = 0;

            Console.WriteLine("Ingrese un numero cualquiera para hallar su tabla de multiplicar hasta el 12");
            //Numero = double.Parse(Console.ReadLine());

            for (short i = 0; i <= 29; i++)
            {
                sum = (sum + Math.Pow(3,Numero));
                Console.WriteLine("3^"+ Numero + " es: " + Math.Pow(3,Numero));
                Numero++;
                
            }
            Console.WriteLine("Sumatoria de las primeras 30 potencias del 3: " + sum);
            */

            //Punto 16
            //Se desea obtener el salario neto de los empleados de una empresa cuyo trabajo se paga por horas y con las siguientes condiciones:
            //El total de horas inferiores a 40 se pagan a una tarifa determinada que se introduce por el teclado al igual que el número de horas y
            //el nombre del trabajador.
            //Las horas superiores a 40 horas se pagan como extras al precio de 2.5 horas normales.
            //Si el trabajador debe cumple con menos de 10 horas trabajadas mostrar "trabajador en observación”

            /*
            float valorH = 0;
            short n = 0, i = 0, j = 0;

            Console.WriteLine("Ingrese el numero de trabajadores a los que le sacara el salario");
            n = short.Parse(Console.ReadLine());

            string[] nombre = new string[n];
            short[] horasT = new short[n];
            
            Console.WriteLine("Ingrese el valor a pagar por horas:");
            valorH = float.Parse(Console.ReadLine());

            while (i < n)
            {
                Console.WriteLine("Ingrese el nombre del trabajador: ");
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el numero de horas");
                horasT[i] = short.Parse(Console.ReadLine());
                i++;
            }
            while (j < n)
            {
                if (horasT[j] < 40)
                {
                    Console.WriteLine("La deducion del salario de " + nombre[j] + " es: " + (valorH * horasT[j]));
                }
                else Console.WriteLine("La deducion del salario de " + nombre[j] + " es: " + ((valorH * 2.5) * horasT[j]));

                if (horasT[j] < 10) Console.WriteLine("El trabajador: " + nombre[j] + "debe entrar a observacion");
                j++;
            }
            */

            //Punto 17
            //Escriba un juego de adivinanzas donde el usuario tiene que adivinar un número secreto.  El programa y el usuario van interactuando 
            //mediante preguntas: su número era mayor o menor. Al final, se debe imprimir: el Número y la cantidad de intentos necesarios para 
            //adivinarlo. 
            /*
            Random numR = new Random();
            int resp = 0, min = -100, max = 101, test = 0;
            string Veracidad = "si";
            Console.WriteLine("Ingrese un numero entre 100 y -100 y Houdini lo adivinara\n Su numero es? ");
            short numeroA = short.Parse(Console.ReadLine());

            while (resp != numeroA && numeroA != test) 
            {
                test = numR.Next(min, max);
                Console.WriteLine("Tu numero es mayor que " + test + " ?");
                Veracidad = Console.ReadLine();
                if (Veracidad == "si")
                {
                    min = test;
                }
                else { max = test; }
                if (test == numeroA)
                {
                    resp = test;
                    break;
                }
            }
            Console.WriteLine("Tu numero es: " + resp);
            */

            //Punto 18
            //Escriba un programa que traduzca una palabra en español en su código morse equivalente. Los caracteres deben ser validados contra la representación en el alfabeto morse. Se debe controlar si la palabra que ingresa 
            //el usuario, tiene algún carácter que no esté en el alfabeto morse.

            //Punto 19
            //Hay un sistema de iluminación en una habitación, que se mantiene encendido solamente cuando hay alguien en moviéndose en la habitación(imagine un sensor de movimiento). Diseñe un programa que calcule cuánto tiempo
            //ha estado encendida la iluminación. Como entrada se le dará un conjunto de intervalos que representa como enteros los tiempos de entrada y salida de alguien a la habitación Cuando los tiempos se solapan, 
            //se necesita encontrar el tiempo entre el número más pequeño y el más grande en ese intervalo.
            //El siguiente ejemplo ilustra lo solicitado: cada línea tiene dos enteros que representa cuando alguien entró y salió de la habitación y cada bloque de líneas representa lo que pasó en una habitación.
            //Habitación 1
            //2 4
            //3 4
            //1 3
            //4 5
            //La luz estuvo encendida: 4 minutos



        }
    }
}