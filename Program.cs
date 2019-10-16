using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int yafuexd = 0;
            do
            {
                Console.WriteLine("**********************");
                Console.WriteLine("* MENÚ DE EJERCICIOS *");
                Console.WriteLine("**********************");
                Console.WriteLine("1.- Salir");
                Console.WriteLine("2.- Ejercicio 1");
                Console.WriteLine("3.- Ejercicio 2");
                Console.WriteLine("4.- Ejercicio 3");
                Console.WriteLine("5.- Ejercicio 4");
                Console.WriteLine("6.- Ejercicio 5");
                Console.WriteLine("7.- Ejercicio 6");
                Console.WriteLine("8.- Ejercicio 7");
                Console.WriteLine("9.- Ejercicio 8");
                Console.WriteLine("10.-Ejercicio 9");
                Console.WriteLine("11.- Ejercicio 10");
                Console.WriteLine("Elije una opción a ejecutar del 1-11");

                String opcionxd = Console.ReadLine();
                int opcionx = Convert.ToInt16(opcionxd);
                if (opcionx == 1)
                {
                    Console.WriteLine("Para salir presione cualquier tecla");
                    yafuexd = 1;

                }

                if (opcionx == 2)
                {
                    int c = 0;
                    Console.WriteLine("Ingrese la cantidad de números que desea ingresar");
                    String n = Console.ReadLine();
                    int nu = Convert.ToInt16(n);
                    for (int i = 0; i < nu; i++)
                    {
                        Console.WriteLine("Ingrese número");
                        String num = Console.ReadLine();
                        int nume = Convert.ToInt16(num);
                        if (nume > c)
                        {
                            c = nume;
                        }

                    }
                    Console.WriteLine("El mayor es: " + c);
                }
                if (opcionx == 3)
                {
                    Console.WriteLine("Ingrese el número para el tamaño del cuadrado");
                    string num = Console.ReadLine();
                    bool error = Int16.TryParse(num, out short nu_ta);
                    if (error)
                    {
                        for (int i = 1; i <= nu_ta; i++)
                        {
                            Console.Write("*  ");
                        }
                        Console.WriteLine();

                        for (int i3 = 1; i3 <= nu_ta; i3++)
                        {
                            Console.Write("*");
                            for (int i2 = 1; i2 <= nu_ta - 2; i2++)
                            {
                                Console.Write("   ");
                            }
                            Console.WriteLine("  *  ");
                        }
                        for (int i4 = 1; i4 <= nu_ta; i4++)
                        {
                            Console.Write("*  ");
                        }
                    }
                }
                if (opcionx == 4)
                {
                    int c = 1, can = 1;
                    float pre = 1, total = 0, st = 0;
                    while (c != 0)
                    {
                        if (can != 0)
                        {
                            Console.WriteLine("Ingrese la cantidad vendida: ");
                            can = int.Parse(Console.ReadLine());
                            while (can < 0)
                            {
                                Console.WriteLine("Valor ingresado incorrecto, por favor ingrese una cantidad positiva: ");
                                can = int.Parse(Console.ReadLine());
                            }
                        }
                        else
                        {
                            Console.WriteLine("El valor a pagar: " + st);
                            c = 0;
                        }
                        if (can != 0)
                        {
                            Console.WriteLine("Introduzca el precio: ");
                            pre = float.Parse(Console.ReadLine());
                            while (pre < 0)
                            {
                                Console.WriteLine("Valor ingresado incorrecto, por favor ingrese un precio con número positivo: ");
                                pre = int.Parse(Console.ReadLine());
                            }
                        }
                        else
                        {
                            Console.WriteLine("El valor a pagar: " + st);
                            c = 0;
                        }
                        total = can * pre;
                        st = st + total;
                    }
                }
                    if (opcionx == 5)
                    {
                        int vh = 15, sue = 0;
                        string pre1 = "si";
                        while (pre1 == "si")
                        {
                            Console.WriteLine("Ingrese cantidad de horas semanales: ");
                            int ch = int.Parse(Console.ReadLine());
                            if (ch > 35)
                            {
                                sue = vh * 35;
                                vh = 22;
                                ch = ch - 35;
                                int h_extra = vh * ch;
                                sue = sue + h_extra;
                            }
                            else
                            {
                                sue = vh * ch;
                            }
                            Console.WriteLine("El salario semanal es de: " + sue);
                            Console.WriteLine("¿Quíere calcular el salario de otro empleado?   responda: si/no ");
                            Console.WriteLine("Responda: si/no ");
                            pre1 = Console.ReadLine();
                        }
                    }
                    if (opcionx == 6)
                    {
                        Console.WriteLine("Ingrese el número de niveles para la piramide");
                        int niv = int.Parse(Console.ReadLine());
                        if (niv > 0)
                        {
                            int a;
                            int b;
                            for (int i = 1; i <= niv; i++)
                            {
                                a = niv - i;
                                b = i + (i - 1);
                                for (int i2 = 0; i2 < a; i2++)
                                {
                                    Console.Write(" ");
                                }
                                for (int i3 = 0; i3 < b; i3++)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine(" ");

                            }
                        }
                        else
                        {
                            Console.WriteLine("No se puede realizar una píramide de ese nivel");
                        }
                    }
                    if (opcionx == 7)
                    {
                        Console.WriteLine("Ingrese un número para el tamaño del rombo");
                        int tamaño = int.Parse(Console.ReadLine());
                        if (tamaño != 0)
                        {
                            int a, b;
                            for (int i = 1; i <= tamaño; i++)
                            {
                                a = tamaño - i;
                                b = i + (i - 1);
                                for (int i2 = 0; i2 < a; i2++)
                                {
                                    Console.Write(" ");
                                }
                                for (int i3 = 0; i3 < b; i3++)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine(" ");
                            }

                            for (int i4 = tamaño; i4 >= 1; i4--)
                            {
                                a = tamaño - i4;
                                b = i4 + (i4 - 1);
                                for (int i5 = a; i5 > 0; i5--)
                                {
                                    Console.Write(" ");
                                }
                                for (int i6 = b; i6 > 0; i6--)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine(" ");
                            }
                        }
                    }
                    if (opcionx == 8)
                    {
                        int val = 0, val2 = 101;
                        val = Convert.ToInt32(val);
                        val = Convert.ToInt32(val);
                        do
                        {
                            val = val + 1;
                            val2 = val2 - 1;
                            Console.WriteLine("{0}        {1}", val, val2);
                        } while (val2 > 1);

                    }
                    if (opcionx == 9)
                    {
                        Console.WriteLine("Ingrese un número");
                        int n;
                        n = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= n; i++)
                        {
                            Console.Write(i);
                            if (i <= n / 2)
                            {
                                Console.Write("      " + (i + i));

                            }
                            else
                            {
                                Console.Write(" ");
                            }
                            if (i <= n / 3)
                            {
                                Console.WriteLine("      " + (i + i + i));

                            }
                            else
                            {
                                Console.WriteLine(" ");
                            }

                        }
                    }
                    if (opcionx == 10)
                    {
                        for (int i = 1; i <= 15; i++)
                        {
                            for (int j = 1; j <= 12; j++)
                            {
                                Console.WriteLine("{0} x {1} = {2}", +i, +j, +(i * j));
                            }
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                        }
                    }
                    if (opcionx == 11)
                    {
                        Console.WriteLine("Elije una opción/n");
                        Console.WriteLine("/n1.- Salir");
                        Console.WriteLine("/n2.- Sumatoria");
                        Console.WriteLine("/n3.- Factorial");
                        string abc = null;
                        abc = Console.ReadLine();

                        switch (abc)
                        {
                            case "1":
                                Console.WriteLine("Para salir precione cualquier tecla: ");

                                break;
                            case "2":
                                Console.WriteLine("Ingrese el primer número a sumar: ");
                                string num1 = Console.ReadLine();
                                int numero1 = Convert.ToInt16(num1);
                                Console.WriteLine("Ingrese el segundo número a sumar: ");
                                string num2 = Console.ReadLine();
                                int numero2 = Convert.ToInt16(num2), su = 0;
                                su = Convert.ToInt16(su);
                                {
                                    su = numero1 + numero2;
                                    Console.WriteLine("La suma de los dos números es: " + su);
                                }
                                break;
                            case "3":
                                Console.WriteLine("Ingrese un número");
                                string f = Console.ReadLine();
                                int fac = Convert.ToInt16(f);
                                int total1 = 1;
                                total1 = Convert.ToInt16(total1);
                                for (int i = fac; i > 0; i--)
                                {
                                    total1 = total1 * i;
                                }
                                Console.WriteLine("El factorial es: " + total1);
                                break;

                        }
                        Console.ReadKey();


                    }
                if(opcionx>11)
                {
                    Console.WriteLine("Valor ingresado incorrecto. por vafor ingresar un valor entre 1-11");
                }
                
             } while (yafuexd != 1) ;

                Console.ReadKey();
            

        }
    }
}

        
            

        
    


