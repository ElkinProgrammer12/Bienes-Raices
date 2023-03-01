using System;

namespace ConsoleApp1
{
    internal class Program
    {

        public static float numero1 = 0;
        public static float numero2 = 0;
        public static float dato1 = 0;
        public static string nombre;
        static void Main(string[] args)
        {
            Proceso();
        }
        public static void Proceso()
        {
            int eleccion = 0;
            do
            {
                string validacion;
                Console.WriteLine("\t" + "BIENES RAICES  ASOCIADOS");
                Console.WriteLine("\t" + "=========================");
                Console.WriteLine("\t" + "|alguien en quien confiar|");
                Console.WriteLine("\t" + "=========================");
                Console.WriteLine("\n");
                Console.Write("Ingrese el nombre del comprador: ");
                nombre = (Console.ReadLine());
                Console.WriteLine(nombre + ", lea atentamente el siguiente menú");
                Console.WriteLine("Marque 1 para entrar al programa de registro");
                Console.WriteLine("Marque 2 para finalizar en el Software");
                eleccion = int.Parse(Console.ReadLine());
                switch (eleccion)
                {
                    case 1:
                        Console.Write("Añada el valor de la vivienda que se desea comprar: ");
                        numero1 = int.Parse(Console.ReadLine());
                        Console.Write("Coloca los ingresos actuales del comprador: ");
                        numero2 = int.Parse(Console.ReadLine());
                        if (numero2 <= 600000)
                        {
                            Console.WriteLine("Se cancela 15% de cuota inicial. El valor restante queda diferido a 10 años");
                            float ingresoMenor = Calculo1(numero1);
                            Console.WriteLine("\n");
                            Console.WriteLine("la cuota incial es: " + ingresoMenor + " y serán descontados del valor total de la vivienda");
                            float total = numero1 - Calculo1(numero1);
                            Console.WriteLine("\n");
                            Console.WriteLine("La vivienda, descontando cuota inicial es: " + total);
                            float cuotas1 = total / 120;
                            Console.WriteLine("Se deben pagar mensualmente: " + cuotas1 + " como cuota fija");
                        }
                        else if (numero2 >= 600001)
                        {
                            Console.WriteLine("Se cancela 30% de cuota inicial. El valor restante queda diferido a 7 años");
                            float ingresoSuperior = Calculo2(numero1);
                            Console.WriteLine("La cuota inicial es: " + ingresoSuperior + " y serán descontados del valor total de la vivienda");
                            Console.WriteLine("\n");
                            float total1 = numero1 - Calculo2(numero1);
                            Console.WriteLine("La vivienda, descontando cuota inicial es: " + total1);
                            float cuotas2 = total1 / 84;
                            Console.WriteLine("\n");
                            Console.WriteLine("Se deben pagar mensualmente: " + cuotas2 + " como cuota fija");
                            Console.WriteLine("\n");
                            Console.Write("Si eres cabeza de familia marca S, de lo contrario coloca N: ");
                            validacion = (Console.ReadLine());
                            validacion = validacion.ToUpper();
                            if (validacion == "S")
                            {
                                float descuento = (cuotas2 * 03) / 100;
                                float descuentoFinal = cuotas2 - descuento;
                                Console.WriteLine("Descuento adicional de 3% por cabeza de familia. Cancelas mensualmente: " + descuentoFinal);
                                Console.WriteLine("\n");
                            }
                            if (validacion == "N")
                            {
                                Console.WriteLine("No tienes otro descuento. Pagas mensual: " + cuotas2);
                                Console.WriteLine("\n");
                            }
                        }
                        Repetir();
                        break;

                    case 2:
                        Console.WriteLine(nombre + " ,gracias por usar nuestros servicios");
                        Console.WriteLine("\n");
                        break;

                    default:
                        Console.WriteLine(nombre + " ,la opción marcada no es válida. Intenta de nuevo");
                        Console.WriteLine("\n");
                        break;

                }
            } while (eleccion != 2);
        }
        static float Calculo1(float dato1)
        {
            return (dato1 * 15 / 100);
        }
        public static float Calculo2(float dato1)
        {
            return (dato1 * 30 / 100);
        }
        public static void Repetir()
        {
            Console.WriteLine("¿Desea volver a ingresar otro comprador?");
            Console.WriteLine("Marca S para agregar otro comprador o N para finalizar");
            string nuevo = (Console.ReadLine());
            nuevo = nuevo.ToUpper();
            if (nuevo == "S")
            {
                Console.Clear();
                Proceso();
            }
            else if (nuevo == "N")
            {
                Console.WriteLine("Finalizas programa");
                System.Environment.Exit(0); 
            }
        }
    }
}
