using System;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Xml;

namespace EjerciciosIntroductorios
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            Console.WriteLine("Integrantes: \n Espinoza Delgado lisbeth Gabriela \n Mero Antón Michael \n Presione enter para ingresar al menu de ejercicios.");
            Console.ReadKey(); Console.Clear();
            do
            {
                
                Console.WriteLine("**MENU DE EJERCICIOS**" +
                    "\n1. Ingrese opción entre 1 a 49" +
                    "\n0. Cerrar sesion del programa");
                Console.Write("Ingrese su opción: ");
                op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (op)
                {
                    #region PROGRAMA 1
                    case 1:
                        Console.WriteLine("Programa para imprimir 'Hello' en la pantalla\n" +
                            "y luego imprime su nombre en una línea separada.\n");
                        Console.Write("Ingrese su nombre: ");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("\nHola \n{0}", nombre);
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 2
                    case 2:
                        Console.WriteLine("Programa para imprimir la suma de dos números.\n");
                        Console.Write("Ingrese primer numero: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese segundo numero: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        double result = num1 + num2;
                        Console.WriteLine("\nEl resultado de la suma es: {0} ", result);
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 3
                    case 3:
                        Console.WriteLine("Programa para dividir dos números e imprimir en la pantalla, con variables Int\n");
                        Console.Write("Ingrese primer numero: ");
                        int div1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese segundo numero: ");
                        int div2 = Convert.ToInt32(Console.ReadLine());
                        int divR = div1 / div2;
                        Console.WriteLine("\nEl resultado de la division es: {0} ", divR);
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 4
                    case 4:
                        Console.WriteLine("Programa para imprimir el resultado de las siguientes operaciones.\n" +
                            "Datos de prueba y resultados a esperar: \n" +
                            "a. -5 + 8 * 6 = 43 \t *** \tb. (55+9) % 9 = 1\n" +
                            "c. 20 + -3*5 / 8 = 19 \t *** \td. 5 + 15 / 3 * 2 - 8 % 3 = 13\n");

                        double resultA = -5 + 8 * 6;
                        Console.WriteLine("Resultado de -5 + 8 * 6 = {0} ", resultA);
                        double resultB = (55 + 9) % 9;
                        Console.WriteLine("Resultado de (55+9) % 9 = {0}", resultB);
                        double resultC = 20 + -3 * 5 / 8;
                        Console.WriteLine("Resultado de: 20 + -3*5 / 8 = {0}", resultC);
                        double resultD = 5 + 15 / 3 * 2 - 8 % 3;
                        Console.WriteLine("El resultado de: 5 + 15 / 3 * 2 - 8 % 3 = {0}", resultD);
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 5
                    case 5:
                        Console.WriteLine("Programa que toma dos números como entrada y mostra el producto de dos números previamente ingresados.\n");
                        Console.Write("Ingrese primer numero: ");
                        double mult1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese segundo numero: ");
                        double mult2 = Convert.ToDouble(Console.ReadLine());
                        double resultM = mult1 * mult2;
                        Console.WriteLine("\nEl resultado de la multiplicacion es: {0} ", resultM);
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 6
                    case 6:
                        Console.WriteLine("Programa para imprimir la suma (suma),multiplicar, restar, dividir y el resto o residuo\n");
                        Console.Write("Escribe tu primer número: ");
                        double nume1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Escribe tu segundo numero: ");
                        double nume2 = Convert.ToDouble(Console.ReadLine());

                        double resultado;
                        resultado = nume1 + nume2;

                        double resultado2;
                        resultado2 = nume1 - nume2;

                        int resultado3;
                        resultado3 = (int)(nume1 * nume2);

                        int resultado4;
                        resultado4 = (int)(nume1 / nume2);

                        int resultado5;
                        resultado5 = (int)(nume1 % nume2);
                        Console.WriteLine("Suma : {0}" +
                            "\nResta: {1}" +
                            "\nMultiplicacion: {2}" +
                            "\nDivision: {3}" +
                            "\nResiduo: {4}", resultado, resultado2, resultado3, resultado4, resultado5);

                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 7
                    case 7:
                        Console.WriteLine("Programa que toma un número como entrada imprime su tabla de multiplicación hasta 10.\n");
                        Console.Write("Ingrese el número para que imprima la tabla de multiplicar: ");
                        int num7 = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= 10; i++)
                        {
                            resultado = num7 * i;
                            Console.WriteLine("{0} * {1} = {2}", num7, i, resultado);
                        }
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 8
                    case 8:
                        Console.WriteLine("Programa para mostrar el siguiente patrón. El objetivo es utilizar los saltos de línea adecuadamente\n");
                        Console.WriteLine("     J     a    v     v    a    \n  " +
                                          "   J    a a    v   v    a a   \n  " +
                                          "J  J   aaaaa    V V    aaaaa  \n  " +
                                          " JJ   a     a    V    a     a     ");
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 9
                    case 9:
                        Console.WriteLine("Programa para calcular las expresiones especificadas e imprima la salida.");
                        double result9 = ((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5));
                        Console.WriteLine("El valor calculado es: {0}", result9);
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 10
                    case 10:
                        Console.WriteLine("Programa para calcular una fórmula especificada");
                        double result10 = 4.0 * (1 - (1.0 / 3) + (1.0 / 5) - (1.0 / 7) + (1.0 / 9) - (1.0 / 11));
                        Console.WriteLine("El valor calculado es: {0}", result10);
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 11
                    case 11:
                        Console.WriteLine("Programa para imprimir el área y el perímetro de un círculo.\n");
                        Console.Write("Ingrese el radio del circulo: ");
                        double radioCir = Convert.ToDouble(Console.ReadLine());
                        double areaCir = radioCir * radioCir * 3.1415;
                        double perimetroCir = radioCir * 2 * 3.1415;
                        Console.WriteLine("El area de un circulo con radio de {0} es iguala a: {1}" +
                            "\nEl perimetro del circulo es: {2}", radioCir, areaCir, perimetroCir);
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 12
                    case 12:
                        Console.WriteLine("Programa que toma tres números enteros como entrada para calcular e imprimir el promedio de los números\n");
                        Console.Write("Ingrese primer numero: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese segundo numero: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese tercer numero: ");
                        double c = Convert.ToDouble(Console.ReadLine());
                        double prom = (a + b + c) / 3;
                        Console.WriteLine("El promedio de los numeros ingresados es: {0}", prom);
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 13
                    case 13:
                        Console.WriteLine("Programa para imprimir el área y el perímetro de un rectángulo. Preste atención al tipo de dato requerido.\n");
                        Console.Write("Ingrese la base: ");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la altura: ");
                        double height = Convert.ToDouble(Console.ReadLine());
                        double areaRec = width * height;
                        double perimetroRec = 2 * (width + height);
                        Console.WriteLine("El area del rectangulo con base de {0} y altura de {1} es: {2}" +
                            "y su perimetro es igual a: {3}", height, width, areaRec, perimetroRec);
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 14
                    case 14:
                        Console.WriteLine("Programa para imprimir una bandera americana en la pantalla");
                        Console.WriteLine("* * * * * * ==================================");
                        Console.WriteLine(" * * * * *  ==================================");
                        Console.WriteLine("* * * * * * ==================================");
                        Console.WriteLine(" * * * * *  ==================================");
                        Console.WriteLine("* * * * * * ==================================");
                        Console.WriteLine(" * * * * *  ==================================");
                        Console.WriteLine("* * * * * * ==================================");
                        Console.WriteLine(" * * * * *  ==================================");
                        Console.WriteLine("* * * * * * ==================================");
                        Console.WriteLine(" * * * * *  ==================================");
                        Console.WriteLine("==============================================");
                        Console.WriteLine("==============================================");
                        Console.WriteLine("==============================================");
                        Console.WriteLine("==============================================");
                        Console.WriteLine("==============================================");
                        Console.WriteLine("==============================================");
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 15
                    case 15:
                        int z;
                        Console.WriteLine("Programa para intercambiar el contenidos de dos variables.\n");
                        Console.Write("Ingrese el valor de X: ");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese el valor de Y: ");
                        int y = Convert.ToInt32(Console.ReadLine());
                        z = x;
                        x = y;
                        y = z;
                        Console.WriteLine("El nuevo valor de X es: {0}" +
                            "\nEl valor de Y es ahora: {1}", x, y);
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 16
                    case 16:
                        Console.WriteLine("Programa para imprimir una cara");
                        Console.WriteLine("     +''''''''+ \n    [|  O  O  |] \n     |   ^    |  \n     |  '-'   | \n     +--------+");
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 17
                    case 17:
                        Console.WriteLine("Programa para sumar dos números enteros distintos\n" +
                            ", pero si el primero es mayor que el segundo reste el primero menos el segundo.");
                        Console.WriteLine("Ingrese un número:");
                        int num1_17 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número:");
                        int num2_17 = int.Parse(Console.ReadLine());

                        if (num2_17 > num1_17)
                        {
                            int result1_17 = num2_17 + num1_17;
                            Console.WriteLine("la suma es : {0}" + result1_17);
                        }
                        else
                        {
                            int result2_17 = num1_17 - num2_17;
                            Console.WriteLine("la resta es : {0}" + result2_17);

                        }
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 18
                    case 18:
                        Console.WriteLine("Programa que permite calcular el factorial deun número ingresado.");
                        long result18 = 1;
                        Console.Write("Introduce un numero : ");
                        int num18 = Convert.ToInt32(Console.ReadLine());

                        for (int i = 2; i <= num18; i++)
                        {
                            result18 *= i;
                        }
                        Console.WriteLine("El factorial de {0} es {1}", num18, result18);
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 19
                    case 19:
                        Console.WriteLine("Programa que identifiqua sí un número esprimo o no");
                        int cont19 = 0;
                        Console.Write("Ingrese número: ");
                        int num19 = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i < (num19 + 1); i++)
                        {
                            if (num19 % i == 0)
                            {
                                cont19++;
                            }
                        }
                        if (cont19 != 2)
                        {
                            Console.WriteLine("No es primo");
                        }
                        else
                        {
                            Console.WriteLine("Es primo");
                        }
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 20
                    case 20:
                        Console.WriteLine("Programa que identifiqua sí un número es perfecto o no");
                        int cont20 = 0;
                        Console.Write("Digite un numero: ");
                        double num20 = Convert.ToDouble(Console.ReadLine());
                        for (int i = 1; i < num20; i++)
                        {
                            if (num20 % i == 0)
                            {
                                cont20 += i;
                            }
                        }
                        if (cont20 == num20)
                        {
                            Console.WriteLine("El numero {0} es perfecto", num20);
                        }
                        else
                            Console.WriteLine("El numero {0} no es deficiente", num20);
                        //int numPerf = Convert.ToInt32(Console.ReadLine());
                        //int cont20 = 0;

                        //for (int i = 1; i < numPerf; i++)
                        //{
                        //    if (numPerf % i == 0)
                        //    {
                        //        cont20 = +i;
                        //    }
                        //}
                        //if (cont20 == numPerf)
                        //{
                        //    Console.WriteLine("El número que ingresó es perfecto");
                        //}
                        //else
                        //{
                        //    Console.WriteLine("El número que ingresó no es perfecto");
                        //}
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 21
                    case 21:
                        Console.WriteLine("Programa que identifique sí un número es abundante\n");
                        int cont21 = 0;
                        Console.Write("Digite un numero: ");
                        double num21 = Convert.ToDouble(Console.ReadLine());
                        for (int i = 1; i < num21; i++)
                        {
                            if (num21 % i == 0)
                            {
                                cont21 += i;
                            }
                        }
                        if (cont21 > num21)
                        {
                            Console.WriteLine("El numero {0} es abundante", num21);
                        }
                        else
                            Console.WriteLine("El numero {0} no es Abundante", num21);
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 22
                    case 22:
                        Console.WriteLine("Programa que identifique sí un número es deficiente\n");
                        int cont22 = 0;
                        Console.Write("Digite un numero: ");
                        double num22 = Convert.ToDouble(Console.ReadLine());
                        for (int i = 1; i < num22; i++)
                        {
                            if (num22 % i == 0)
                            {
                                cont22 += i;
                            }
                        }
                        if (cont22 < num22)
                        {
                            Console.WriteLine("El numero {0} es deficiente", num22);
                        }
                        else
                            Console.WriteLine("El numero {0} no es deficiente", num22);
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 23
                    case 23:
                        Console.WriteLine("Programa que genera los diez primeros numeros primos");
                        int primo = 0, cont23 = 1;
                        for (int i = 2; i <= 30; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                if (i % j == 0)
                                {
                                    primo += 1;
                                }
                            }

                            if (primo <= 2)
                            {
                                Console.WriteLine("{0} ----> {1}", cont23++, i);
                            }
                            primo = 0;
                        }
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 24
                    case 24:
                        Console.WriteLine("Programa que genera los diez primeros números perfectos");
                        int NumerosPerfectosRequeridos = 5;
                        int ContadorNumerosGenerados = 0;
                        int Numero = 0;
                        int Recorrer = 1;
                        int SumaDivisores = 0;
                        do
                        {
                            Numero++;
                            SumaDivisores = 0;
                            Recorrer = 1;
                            while (Recorrer < Numero)
                            {
                                if ((Numero % Recorrer) == 0)
                                {
                                    SumaDivisores = SumaDivisores + Recorrer;
                                }
                                Recorrer++;
                            };
                            if (SumaDivisores == Numero)
                            {
                                ContadorNumerosGenerados++;
                                System.Console.WriteLine(ContadorNumerosGenerados + ") Perfecto:" + Numero);
                            }
                        } while (ContadorNumerosGenerados <= NumerosPerfectosRequeridos);
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 25
                    case 25:
                        Console.WriteLine("Programa que genera los diez primeros números abundantes.\n");
                        for (int i = 2; i < 55; i++)
                        {
                            int num25 = 0;
                            for (int j = 1; j < i; j++)
                            {
                                if (i % j == 0)
                                {
                                    if (i != j)
                                    {
                                        num25 += j;
                                    }
                                }
                            }
                            if (num25 > i)
                            {
                                Console.WriteLine("El numero {0} es abundante", i);
                            }
                        }
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 26
                    case 26:
                        Console.WriteLine("Programa que genera los diez primeros números deficientes.\n");
                        for (int i = 2; i < 14; i++)
                        {
                            int num26 = 0;
                            for (int j = 1; j < i; j++)
                            {
                                if (i % j == 0)
                                {
                                    if (i != j)
                                    {
                                        num26 += j;
                                    }
                                }
                            }
                            if (num26 < i)
                            {
                                Console.WriteLine("El numero {0} es deficiente", i);
                            }
                        }
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 27
                    case 27:
                        Console.WriteLine("Programa para comparar dos números enteros\n");
                        Console.Write("Ingrese primer número: ");
                        int primero = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese segundo número: ");
                        int segundo = Convert.ToInt32(Console.ReadLine());
                        if (primero == segundo)
                        {
                            Console.WriteLine("\n Números iguales. \n Vuelve a intertar con numeros diferentes. ");
                            segundo = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                        }
                        else if (primero > segundo)
                        {

                            Console.WriteLine(+primero + "!=" + segundo);
                            Console.WriteLine(+primero + ">" + segundo);
                            Console.WriteLine(+primero + "=>" + segundo);
                        }
                        else
                        {
                            Console.WriteLine(+primero + "!=" + segundo);
                            Console.WriteLine(+primero + "<" + segundo);
                            Console.WriteLine(+primero + "<=" + segundo);
                        }
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 28
                    case 28:
                        Console.WriteLine("Programa que calcula la suma de los dígitos de un entero.\n");
                        int digito = 0;
                        Console.Write("Ingrese un valor: ");
                         int num28 = Convert.ToInt32(Console.ReadLine());

                        while (num28 > 0)
                        {
                            digito =+ num28 % 10;
                            num28 /= 10;
                        }

                        Console.WriteLine("La suma de los digitos es: {0}", digito);
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 29
                    case 29:
                        Console.WriteLine("Programa para calcular el área de un hexágono\n");
                        Console.Write("Ingrese la lomgitud del lado del hexágono: ");
                        double longitud = Convert.ToDouble(Console.ReadLine());
                        double A = longitud * longitud;
                        double area = (6 * A) / (4 * Math.Tan(Math.PI / 6));
                        Console.WriteLine("El aréa es: -{0}", area);
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 30
                    case 30:
                        Console.WriteLine("Programa para calcular la distancia entre dospuntos en la superficie de la tierra.\n");
                        double r = 6371.01;
                        Console.Write("Ingrese la latitud de la coordenada1: ");
                        double x1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la longitud de la coordenada1: ");
                        double y1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la latitud de la coordenada2: ");
                        double y2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la longitud de la coordenada2: ");
                        double x2 = Convert.ToDouble(Console.ReadLine());
                        double d = r * Math.Acos(Math.Sin(x1) * Math.Sin(x2) + Math.Cos(x1) * Math.Cos(x2) * Math.Cos(y1 - y2));
                        Console.WriteLine("La distancia de los puntos es {0} km: ", d);
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 31
                    case 31:
                        Console.WriteLine("Programa para invertir una cadena.\n");
                        string invertida = "";
                        Console.Write("Ingrese frase: ");
                        string cadena = Console.ReadLine();
                        for (int i = cadena.Length - 1; i >= 0; i--)
                        {
                            invertida += cadena[i];
                        }
                        Console.Write("Frase Invertida: {0}", invertida);
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 32
                    case 32:
                        Console.WriteLine("Programa para contar las letras, espacios, números y otros caracteres de una cadena de entrada\n");
                        int contEsp = 0, contNum = 0, contOtros = 0, contPal = 0;
                        Console.Write("Ingrese una frase: ");
                        string frase32 = Console.ReadLine();
                        for (int i = 0; i < frase32.Length; i++) // Contara espacios
                        {
                            if (frase32[i] == ' ')
                            {
                                contEsp++;
                            }
                            for (byte numI = 48; numI <= 57; numI++) // Contara numeros
                            {
                                if (frase32[i] == numI)
                                {
                                    contNum++;
                                }
                            }
                            for (byte otrI = 33; otrI <= 47; otrI++) // Contara otros
                            {
                                if (frase32[i] == otrI)
                                {
                                    contOtros++;
                                }
                            }
                        }
                        contPal = frase32.Length - contEsp - contNum - contOtros;
                        int totEsp = contEsp;
                        int totNum = contNum;
                        int totPal = contPal;
                        int totOtr = contOtros;
                        Console.WriteLine("1). La frase tiene {0} espacios" +
                            "\n2). La frase tiene {1} numeros" +
                            "\n3). La frase tiene {2} letras" +
                            "\n4). La frase tiene {3} caracteres", totEsp, totNum, totPal, totOtr);
                        /*int contZ = 33;
                        for (byte abc = 33; abc <= 126; abc++)
                        {
                            Console.WriteLine("{0} ----> {1}", contZ++, (char)abc);
                        }*/
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 33
                    case 33:
                        Console.WriteLine("Programa para crear y mostrar un número único de tres dígitos utilizando 1, 2, 3, 4." +
                            "\nTambién cuente cuántos números de tres dígitos hay\n");
                        int cont33 = 0;

                        for (int i = 1; i <= 4; i++)
                        {
                            for (int j = 1; j <= 4; j++)
                            {
                                for (int k = 1; k <= 4; k++)
                                {
                                    if (k != i && k != j && i != j)
                                    {
                                        cont33++;
                                        Console.WriteLine("{0}{1}{2} ", i, j, k);
                                    }
                                }
                            }
                        }
                        Console.WriteLine("Total de convinaciones: {0}", cont33);
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 34
                    case 34:
                        Console.WriteLine("Programa para visualizar la hora del sistema.\n");
                        DateTime fecha = DateTime.Now;
                        Console.WriteLine(fecha);
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 35
                    case 35:
                        Console.WriteLine("Programa para imprimir los números impares del 1 al 99");
                        for (int i = 0; i <= 100; i++)
                        {
                            if (i % 2 == 1)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 36
                    case 36:
                        Console.WriteLine("Programa para aceptar un número y comprobar que el número es par o no." +
                            "\nImprime 1 si el número es par o 0 si el númeroes impar\n");
                        Console.Write("Ingresa un número: ");
                        int num36 = int.Parse(Console.ReadLine());
                        if (num36 % 2 == 0)
                        {
                            Console.WriteLine("0");
                        }
                        else
                        {
                            Console.WriteLine("1");
                        }
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 37
                    case 37:
                        Console.WriteLine("Programa para imprimir números entre 1 y 100 que son divisibles por 3, 5 y por ambos\n");
                        for (int num = 1; num < 100; num++)
                        {
                            if (num % 3 == 0)
                            {
                                Console.WriteLine("DE TRES: {0}", num);
                            }
                        }
                        for (int num = 1; num < 100; num++)
                        {
                            if (num % 5 == 0)
                            {
                                Console.WriteLine("DE CINCO: {0}", num);
                            }
                        }
                        for (int num = 1; num < 100; num++)
                        {
                            if (num % 5 == 0 && num % 3 == 0)
                            {
                                Console.WriteLine("AMBOS:  {0}", num);
                            }
                        }
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 38
                    case 38:
                        Console.WriteLine("Programa para convertir una cadena en un entero en C#\n");
                        string numeroA = "20";
                        int temporal = int.Parse(numeroA);
                        int sumaA = temporal + 5;
                        Console.WriteLine(sumaA);
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 39
                    case 39:
                        Console.WriteLine("Programa para calcular la suma de dosenteros y devolver" +
                            "\ntrue si la suma es igual a un tercer entero, caso contrario muestre false\n");
                        Console.Write("Introduzca primer número: ");
                        int var39_1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduzca segundo número: ");
                        int var39_2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduzca tercer número: ");
                        int var39_3 = Convert.ToInt32(Console.ReadLine());

                        int sum39 = var39_1 + var39_2;

                        if (sum39 == var39_3)
                            Console.WriteLine("True");
                        else
                            Console.WriteLine("False");
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 40
                    case 40:
                        Console.WriteLine("Programa que acepta tres enteros del usuario y devuelva" +
                            "\n true si el segundo número es mayor que el primer número y " +
                            "\n el tercer número es mayor que el segundo número");
                        bool verdad = true;
                        Console.Write("Ingrese el primer numero: \n");
                        int valo1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese el segundo numero: \n");
                        int valo2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese el tercer numero:\n");
                        int valo3 = Convert.ToInt32(Console.ReadLine());

                        if (valo2 > valo1)
                        {
                            if (valo3 > valo2)
                            {
                                Console.WriteLine(verdad);
                            }
                            else
                                Console.WriteLine("False");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 41
                    case 41:
                        Console.WriteLine("Programa para convertir segundos a horas, minutos y segundos.\n");
                        Console.Write("Ingrese tiempo a convertir: ");
                        int tiempo = Convert.ToInt32(Console.ReadLine());
                        int horas = (tiempo / 3600);
                        int minutos = (tiempo - horas * 3600) / 60;
                        int segundos = tiempo - (horas * 3600 + minutos * 60);
                        Console.WriteLine("{0} : {1} : {2}", horas, minutos, segundos);
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 42
                    case 42:
                        Console.WriteLine("Programa para aceptar un entero y contar los factores del número.");
                        int cont42 = 0;
                        Console.Write("Ingrese un numero para ncontrar su factor: ");
                        int num42 = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= num42; i++)
                        {
                            if (num42 % i == 0)
                                {
                                    cont42++;
                                    Console.WriteLine("factor de {0} ----> {1}", num42, i);
                                }
                        }
                        Console.WriteLine("Total de factores del {0} son : {1}", num42, cont42);
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 43
                    case 43:
                        Console.WriteLine("Programa para poner en mayúscula la primera letra de cada palabra de una oración.\n");
                        Console.Write("Ingrese un frase u oracion en minuscula: ");
                        string frase43 = Console.ReadLine();
                        string cambiar43 = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(frase43);
                        Console.WriteLine("Frase dada: {0}\n" +
                            "Frase obtenida: {1}", frase43, cambiar43);
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 44
                    case 44:
                        Console.WriteLine("Programa en C# para convertir una cadena determinada en minúsculas\n");
                        Console.Write("Ingrese su frase a convertir en minuscula: ");
                        string frase44 = Console.ReadLine(); ;
                        Console.WriteLine("Frase dada: {0}\n" +
                            "Frase convertida: {1}", frase44, frase44.ToLower());
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 45
                    case 45:
                        Console.WriteLine("Programa para encontrar la penúltima palabra de una oración\n");
                        char  limite = ' ';
                        Console.Write("Introducir texto corto: ");
                        string texto45 = Console.ReadLine();

                        string[] penultima = texto45.Split(limite);

                        for (int i = 0; i <= penultima.Length - 1;)
                        {
                            Array.Reverse(penultima);
                            Console.WriteLine("Palabra penultima: {0}", penultima[1]);
                            break;
                        }
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 46
                    case 46:
                        Console.WriteLine("Programa para calcular la raíz cuadrada de un entero determinado");
                        var raiz = Math.Sqrt(25);
                        Console.WriteLine("Resultado de la raiz cuadrada de 25 es: {0}", raiz);
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 47
                    case 47:
                        Console.WriteLine("Programa para calcular la mediana de un vector determinada de enteros no ordenados\n");
                        int cont47 = 0;
                        int[] arreglo47 = new int[7];
                        for (int i = 0; i < 7; i++)
                        {
                            Console.Write("{0} ----> ", cont47++);
                            arreglo47[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("Mediana de los valores: {0}", arreglo47[3]);
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 48
                    case 48:
                        Console.WriteLine("Programa para encontrar un número que aparece sólo una vez en un vector dado de enteros" +
                            "\ntodos los números ocurren dosveces.");
                        int[] num48 = { 10, 20, 10, 20, 30, 40, 40, 30, 50 };
                        for (int i = 0; i < num48.Length; i++)
                        {
                            Console.WriteLine("Numero del vector {0}", num48[i]);
                        }
                        int[] aux = (from item in num48
                                     group item by item into grupo
                                     where grupo.Count() == 1
                                     select grupo.Key).ToArray();

                        Console.WriteLine(string.Join("\n" + ",", aux.ToList()) + " " + "Numero que no se repite");
                        Console.ReadKey(); Console.Clear();
                        break;
                    #endregion

                    #region PROGRAMA 49
                    case 49:
                        Console.WriteLine("Programa para encontrar la nueva longitud de un vector " +
                            "\ndonde cada elemento aparece una sola vez(eliminar los duplicados)\n");
                        int cont49 = 0, cont49_2 = 0;
                        string [] num49 = { "1", "1", "2", "3", "3", "3", "4", "5", "6", "7", "7" };
                        for (int i = 0; i < num49.Length; i++)
                        {
                            Console.WriteLine("Numero repetido {0}", num49[i]);
                            cont49_2++;
                        }
                        Console.WriteLine("Longitud actual del vector: {0}\n\n", cont49_2);
                        for (int i = 0; i < num49.Length; i++)
                        {
                            for (int j = 0; j < num49.Length; j++)
                            {
                                if (i != j)
                                {
                                    if (num49[i] == (num49[j]))
                                    {
                                        num49[i] = "";
                                    }
                                }
                            }
                        }
                        Array.Sort(num49);
                        foreach (var next in num49)
                        {
                            if (next != "")
                            {
                                Console.WriteLine("Numero sin repetir: ---> {0}", next);
                                cont49++;
                            }
                        }
                        Console.WriteLine("La nueva longitud del vector es: {0}", cont49);
                        Console.ReadKey(); Console.Clear();
                        break;
                        #endregion
                }

            } while (op != 0);
            Console.WriteLine("Usted ha salido de programa" +
                "\nTODOS LOS DERECHOS RESERVADOS 2020");
            Console.ReadKey();
        }
    }
}
