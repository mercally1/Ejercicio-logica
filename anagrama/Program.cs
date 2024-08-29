/*
Escribe una función que reciba dos palabras (String) y retorne
 verdadero o falso (Bool) según sean o no anagramas.
 Un Anagrama consiste en formar una palabra reordenando TODAS
 las letras de otra palabra inicial.
 NO hace falta comprobar que ambas palabras existan.
 Dos palabras exactamente iguales no son anagrama.
 */

 string text1, text2;

 Console.WriteLine("por favor ingrese una palabra");
 text1 = Console.ReadLine();

 Console.WriteLine("por favor ingrese una palabra");
 text2 = Console.ReadLine();

if (text1.Split().OrderDescending() == text2.Split().OrderDescending()){
    Console.WriteLine("son un anagrama");
} else {
    Console.WriteLine("No es un anagrama");
}