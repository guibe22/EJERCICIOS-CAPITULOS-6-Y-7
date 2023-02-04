using System.Collections;

ArrayList calificaciones = new ArrayList();
            int numEstudiantes = 0;
            string entrada = "";

Console.WriteLine("¿Cuántos estudiantes hay en el salón?");
entrada = Console.ReadLine();
numEstudiantes = Convert.ToInt32(entrada);

for (int i = 0; i < numEstudiantes; i++)
{
    Console.WriteLine("Ingrese la calificación del estudiante " + (i + 1));
    entrada = Console.ReadLine();
    calificaciones.Add(Convert.ToInt32(entrada));
}

Console.WriteLine("El promedio de las calificaciones es: " + Promedio(calificaciones));
Console.WriteLine("La calificación mínima es: " + CalificacionMinima(calificaciones));
Console.WriteLine("La calificación máxima es: " + CalificacionMaxima(calificaciones));


 static double Promedio(ArrayList calificaciones)
        {
            double suma = 0.0;

            for (int i = 0; i < calificaciones.Count; i++)
            {
                suma += (int)calificaciones[i];
            }

            return suma / calificaciones.Count;
        }

        static int CalificacionMinima(ArrayList calificaciones)
        {
            int min = (int)calificaciones[0];

            for (int i = 1; i < calificaciones.Count; i++)
            {
                if ((int)calificaciones[i] < min)
                {
                    min = (int)calificaciones[i];
                }
            }

            return min;
        }

        static int CalificacionMaxima(ArrayList calificaciones)
        {
            int max = (int)calificaciones[0];

            for (int i = 1; i < calificaciones.Count; i++)
            {
                if ((int)calificaciones[i] > max)
                {
                    max = (int)calificaciones[i];
                }
            }

            return max;
        }
