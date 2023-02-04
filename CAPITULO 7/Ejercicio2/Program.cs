
using System.Collections;

Hashtable dictionary = new Hashtable();
dictionary.Add("Casa", "La vivienda donde una persona reside");
dictionary.Add("Perro", "Animal doméstico");
dictionary.Add("Computadora", "Dispositivo electrónico utilizado para procesar información");
dictionary.Add("Auto", "Vehículo de cuatro ruedas");

Console.WriteLine("Introduzca una palabra para buscar su definición:");
string word = Console.ReadLine();
if (dictionary.ContainsKey(word))
{
    Console.WriteLine("Definición de " + word + ": " + dictionary[word]);
}
else
{
    Console.WriteLine("Lo siento, la palabra no se encuentra en el diccionario");
}

