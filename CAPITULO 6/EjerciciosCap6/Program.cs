int[][] calificaciones = new int[3][];
            int i, j;
            // Pedimos las calificaciones
            for (i = 0; i < 3; i++)
            {
                Console.Write("Cuantos alumnos hay en la clase " + (i + 1) + ": ");
                int numAlumnos = int.Parse(Console.ReadLine());
                calificaciones[i] = new int[numAlumnos];
                for (j = 0; j < numAlumnos; j++)
                {
                    Console.Write("Dame la calificacion del alumno " + (j + 1) + ": ");
                    calificaciones[i][j] = int.Parse(Console.ReadLine());
                }
            }
            // Invocamos a las funciones
            Imprime(calificaciones);
            Console.WriteLine("El promedio de todas las clases es: " + Promedio(calificaciones));
            Console.WriteLine("La calificacion menor es: " + Menor(calificaciones));
            
        

 static void Imprime(int[][] arreglo)
        {
            int i, j;
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Clase " + (i + 1));
                for (j = 0; j < arreglo[i].Length; j++)
                {
                    Console.WriteLine("El alumno " + (j + 1) + " tiene una calificacion de " + arreglo[i][j]);
                }
            }
        }

        // Esta es la función de promedio
        static double Promedio(int[][] arreglo)
        {
            int i, j;
            double suma = 0.0;
            int total = 0;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < arreglo[i].Length; j++)
                {
                    suma += arreglo[i][j];
                    total++;
                }
            }
            return suma / total;
        }
static int Menor(int[][] arreglo)
{
    int menor = int.MaxValue;
    for (int i = 0; i < arreglo.Length; i++)
    {
        for (int j = 0; j < arreglo[i].Length; j++)
        {
            if (arreglo[i][j] < menor)
                menor = arreglo[i][j];
        }
    }
    return menor;
}

