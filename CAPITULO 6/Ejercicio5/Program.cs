int[][] calificaciones = new int[3][];
    calificaciones[0] = new int[2] { 90, 95 };
    calificaciones[1] = new int[3] { 85, 90, 95 };
    calificaciones[2] = new int[2] { 80, 85 };

   
Imprime(calificaciones);

static void Imprime(int[][] arreglo)
{
    for (int i = 0; i < arreglo.Length; i++)
    {
        Console.WriteLine("Calificaciones del estudiante {0}:", i + 1);
        for (int j = 0; j < arreglo[i].Length; j++)
        {
            Console.WriteLine("Calificación {0}: {1}", j + 1, arreglo[i][j]);
        }
    }
}