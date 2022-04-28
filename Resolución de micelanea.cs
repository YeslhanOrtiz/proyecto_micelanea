using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_micelanea
{
    internal class Resolución_de_micelanea
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Elija una de las siguinetes opciones: \n1. Operadores \n2. Condicionales \n3. Ciclos \n4. Arreglos \n9. Salir ");
            int opciones = Convert.ToInt32(Console.ReadLine());

            switch (opciones)
            {
                case 1:

                    int num1;
                    int num2;
                    int num3;
                    int opcion_1;
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("Elija la operación a realizar");
                    Console.WriteLine("1. Clacular el area de un triangulo");
                    Console.WriteLine("2. Suma de terminos");
                    Console.WriteLine("3. Un número elvado al cuadradro (x^2)");
                    Console.WriteLine("4. Conversor de Euros a Dolares");
                    Console.WriteLine("5. Area y perímetro de un cuadrado");
                    Console.WriteLine("6. Área y Volúmen de un cilindro");
                    Console.WriteLine("7. Radio, longitud y area de un circulo");
                    Console.WriteLine("8. Promedio de tres números");
                    Console.WriteLine("-------------------------------");
                    opcion_1 = Convert.ToInt32(Console.ReadLine());

                    switch (opcion_1)
                    {
                        case 1:
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("Ingrese el primer número entero: ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo número entero: ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("El area del triángulo es: ");
                            Console.WriteLine((num1 * num2) / 2);
                            Console.WriteLine("-------------------------------");
                            break;

                        case 2:
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("Ingrese el primer número entero: ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo número entero: ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("La suma de los dos números enteros es: ");
                            Console.WriteLine(num1 + num2);
                            Console.WriteLine("-------------------------------");
                            break;

                        case 3:
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("Ingrese el primer número entero: ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("El Numero elvado al cuadrado es: ");
                            Console.WriteLine(num1 ^ 2);
                            Console.WriteLine("-------------------------------");
                            break;

                        case 4:
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("Ingrese el número de Euros: ");
                            num1 = (int)Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Número de Dolares: ");
                            Console.WriteLine(num1 * 1.06);
                            Console.WriteLine("-------------------------------");
                            break;

                        case 5:
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("Ingrese la medida de un lado del cuadrado: ");
                            num1 = (int)Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("El área del cuadrado es: ");
                            Console.WriteLine((num1 * num1) + "cm2");
                            Console.WriteLine("El perímetro del cuadrado es: ");
                            Console.WriteLine(num1 + num1 + num1 + num1 + "cm");
                            Console.WriteLine("-------------------------------");
                            break;

                        case 6:
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("Ingrese el radio del cilindro: ");
                            num1 = (int)Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese la altura del cilindro: ");
                            num2 = (int)Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("El area del cilindro es: ");
                            Console.WriteLine(2 * Math.PI * num1 * (num1 * num2));
                            Console.WriteLine("El volúmen del cilindro es: ");
                            Console.WriteLine((Math.PI * num1 * num1 * num2) + "cm3");
                            Console.WriteLine("-------------------------------");
                            break;


                        case 7:
                            double Rad;
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("Ingrese el diametro de la circunferencia: ");
                            num1 = (int)Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("----------");
                            Console.WriteLine("El radio de la circunferencia es: ");
                            Console.WriteLine(Rad = num1 / 2);
                            Console.WriteLine("La longitud de la circunferencia es: ");
                            Console.WriteLine(2 * Math.PI * Rad);
                            Console.WriteLine("El área de la circunferencia es: ");
                            Console.WriteLine(Math.PI * (Rad * Rad));
                            Console.WriteLine("-------------------------------");
                            break;

                        case 8:
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("Ingrese el primer número entero: ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo número entero: ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el tercer numero entero: ");
                            num3 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("El promedio es: ");
                            Console.WriteLine((num1 + num2 + num3) / 3);
                            Console.WriteLine("-------------------------------");
                            break;

                        default:
                            break;

                    }
                    break;

                case 2:

                    int opcion_2;

                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("Condicionnales");
                    Console.WriteLine("Elija una de las siguientes opciones a relaizar: ");
                    Console.WriteLine("1. Número positivo o negativo");
                    Console.WriteLine("2. Número mayor y menor entre dos números");
                    Console.WriteLine("3. Número mayor y menor entre tres números");
                    Console.WriteLine("4. Sumar dos números si A < B o sino restarlos");
                    Console.WriteLine("5. Encontrar el cociente entre A y B");
                    Console.WriteLine("6. sumar A y B si uno de ellos es negativo, sino multiplicarlos");
                    Console.WriteLine("7. Año bisiesto o no");
                    Console.WriteLine("-------------------------------");
                    opcion_2 = Convert.ToInt32(Console.ReadLine());

                    switch (opcion_2)
                    {
                        case 1:
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("Ingrese el número");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            if (num1 > 0)
                            {
                                Console.WriteLine("El número ingrsado es positivo");
                            }
                            else if (num1 == 0)
                            {
                                Console.WriteLine("El número cero es un número neutral");
                            }
                            else
                            {
                                Console.WriteLine("El número ingresado es negativo");
                            }
                            break;

                        case 2:
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("Ingrese el primer número");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingres el segundo número");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            if (num1 > num2)
                            {
                                Console.WriteLine("El número mayor es: " + num1);
                                Console.WriteLine("El número menor es: " + num2);
                            }
                            else
                            {
                                Console.WriteLine("El número mayor es: " + num2);
                                Console.WriteLine("El número menor es: " + num1);
                            }
                            break;

                        case 3:
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("Ingrese el primer número: ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo número: ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el tercer número: ");
                            num3 = Convert.ToInt32(Console.ReadLine());
                            if (num1 > num2)
                            {
                                Console.WriteLine("El primer número es mayor que el segundo número");
                                Console.WriteLine(num1 + "  Es mayor que  " + num2);
                            }
                            else
                            {
                                Console.WriteLine("El segundo número es mayor que el primer número");
                                Console.WriteLine(num2 + "  Es mayor que  " + num1);
                            }
                            if (num1 > num3)
                            {
                                Console.WriteLine("El primer número es mayor que el tercer número");
                                Console.WriteLine(num1 + "  Es mayor que  " + num3);
                            }
                            else
                            {
                                Console.WriteLine("El tercer número es mayor que el primer número");
                                Console.WriteLine(num3 + "  Es mayor que  " + num1);
                            }
                            if (num2 > num3)
                            {
                                Console.WriteLine("El segundo número es mayor que el tercer número");
                                Console.WriteLine(num2 + "  Es mayor que  " + num3);
                            }
                            else
                            {
                                Console.WriteLine("El tercer número es mayor que el segúndo número");
                                Console.WriteLine(num3 + "  Es mayor que  " + num2);
                            }
                            break;

                        case 4:
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("Ingrese el primer número: ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo número: ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            if (num1 > num2)
                            {
                                Console.WriteLine("Como a es mayor que b el resultado de la suma es: ");
                                Console.WriteLine(num1 + num2);
                            }
                            else
                            {
                                Console.WriteLine("Como a es menor que b el resultado de la resta es: ");
                                Console.WriteLine(num1 - num2);
                            }
                            break;

                        case 5:

                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("Ingrese el primer número: ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo número: ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("El cociente de la división es: ");
                            Console.WriteLine(num1 / num2);
                            if (num2 == 0)
                            {
                                Console.WriteLine("la operación no se puede realizar");
                            }
                            break;

                        case 6:
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("Ingrese el primer número: ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo número: ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            if ((num1 < 0) || (num2 < 0))
                            {
                                Console.WriteLine("Como al menos uno de los número es negativo el valor de la suma es: ");
                                Console.WriteLine(num1 + num2);
                            }
                            else
                            {
                                Console.WriteLine("Como no hay ningun número negativo el valor de la multiplicación es: ");
                                Console.WriteLine(num1 * num2);
                            }
                            break;

                        case 7:
                            Console.WriteLine("Ingrese el año: ");
                            int ano = Convert.ToInt32(Console.ReadLine());
                            if (ano / 4 == 0)
                            {
                                if (ano / 100 == 0)
                                {
                                    if (ano / 400 == 0)
                                    {
                                        Console.WriteLine("El año si es bisiesto");
                                    }
                                    else
                                    {
                                        Console.WriteLine("El año no es bisiesto");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("El año si es bisiesto");
                                }
                            }
                            else
                            {
                                Console.WriteLine("El año no es bisiesto");
                            }
                            break;

                        default:
                            break;

                    }

                    break;

                case 3:
                    int opcion_3;

                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("Ciclos");
                    Console.WriteLine("Elija una de las siguientes opciones a relaizar: ");
                    Console.WriteLine("1. Multiplos de tres que hay entre el 1 y 100");
                    Console.WriteLine("2. Números impares entre el 0 y 100");
                    Console.WriteLine("3. Números pares entre el 1 y 100");
                    Console.WriteLine("4. Cuadrado de los números del 1 al 30");
                    Console.WriteLine("5. Cuadrado de los cien primeros números naturales con el resultado");
                    Console.WriteLine("6. Dos números (sinedo el primero el menor) con los números comprendidos entre ellos de forma ascendente");
                    Console.WriteLine("7. Sumar todos los números que se digitan por teclado mientras no sea cero");
                    Console.WriteLine("-------------------------------");
                    opcion_3 = Convert.ToInt32(Console.ReadLine());

                   switch (opcion_3)
                   {
                         case 1:

                             break;

                         case 2:
                             break;

                         case 3:
                             break;

                         case 4:
                             break;

                         case 5:
                             break;

                         case 6:
                             break;

                         case 7:
                             break;

                         default:
                             break;
                   }

                    break;

                case 4:
                    Console.WriteLine("Arreglos");
                    break;

                case 9:
                    Console.WriteLine("Saliendo del programa");
                    break;

                default:
                    Console.WriteLine("Dato incorrecto");
                    Console.WriteLine("saliendo del programa");
                    break;

            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Fin del programa");
            Console.WriteLine("-------------------------------");
        }
    }
}
