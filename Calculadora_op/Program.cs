using System;
using CalculadoraOperaciones;
namespace Calculadora_op
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.-Instanciamos nuestra libreria DLL
           Operaciones operacion = new Operaciones();
            double a, b;
            int op = 0;
            do {
                try
                {
                    Console.WriteLine("1.-Suma\n2.-Resta\n3.-Multiplicacion\n4.-Division\n5.-Cuadrado de un numero\n6.-Raiz cuadrada\n7.-Salir\n¿Que desea realizar?");
                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1://Suma
                            {
                                Console.WriteLine("Introduce el primer número:");
                                a = double.Parse(Console.ReadLine());
                                Console.WriteLine("Introduce el segundo número:");
                                b = double.Parse(Console.ReadLine());
                                Console.WriteLine("El resultado de la suma es "+operacion.suma(a,b));
                                break;
                            }
                        case 2: { //Resta
                                Console.WriteLine("Introduce el primer número:");
                                a = double.Parse(Console.ReadLine());
                                Console.WriteLine("Introduce el segundo número:");
                                b = double.Parse(Console.ReadLine());
                                Console.WriteLine("El resultado de la resta es " + operacion.resta(a, b));
                                break;
                            }
                        case 3: { //Multiplicacion
                                Console.WriteLine("Introduce el primer número:");
                                a = double.Parse(Console.ReadLine());
                                Console.WriteLine("Introduce el segundo número:");
                                b = double.Parse(Console.ReadLine());
                                Console.WriteLine("El resultado de la multiplicacion es " + operacion.multiplicacion(a, b));
                                break;
                            }
                        case 4: { //Division
                                Console.WriteLine("Introduce el primer número:");
                                a = double.Parse(Console.ReadLine());
                                Console.WriteLine("Introduce el segundo número:");
                                b = double.Parse(Console.ReadLine());
                                Console.WriteLine("El resultado de la division de "+a +"/"+b+"=" + operacion.division(a, b));

                                break;
                            }
                        case 5: {
                                Console.WriteLine("Introduce el numero que deseas elevar al cuadrado:");
                                a = double.Parse(Console.ReadLine());
                                Console.WriteLine("El numero "+a+" elevado al cuadrado =" + operacion.cuadradoNumero(a));
                                break;
                            }
                        case 6: {
                                Console.WriteLine("Introduce el numero que deseas saber la raiz cuadrada:");
                                a = double.Parse(Console.ReadLine());
                                Console.WriteLine("La raiz cuadrada del numero "+a+" es =" + operacion.raizCuadrada(a));
                                break;
                            }
                        case 7: {
                                Console.WriteLine("Cerrando programa");
                                break;
                            }
                        default: {
                                Console.WriteLine("Introduce valores validos");
                                break;
                            }
                    }
                }
                catch (Exception e) {
                    Console.WriteLine("Error"+e.Message);
                }
           } while (op!=7);



           

        }
    }
}
