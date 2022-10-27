//declaració  de variables
int a, b, x;

//valors d'entrada
Console.WriteLine("Escriu el valor de a");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Escriu el valor de b");
b = Convert.ToInt32(Console.ReadLine());
// algoritme
if (a == 0)
    Console.WriteLine("Aquesta operacio no es pot fer, Escull un altre numero que no sigui 0");
else
{
    x = -b / a;
    // valors de sortida
    Console.WriteLine($"x ={x}");
}
Console.ReadKey();
