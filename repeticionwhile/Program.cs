
Console.WriteLine("Hello, World!");
string re = "s";
double suma = 0;
double cant = 0;
while (re =="s") {
    Console.WriteLine("Desea participar (s/n)?");
    re = Console.ReadLine().Trim().ToLower();
    if (re == "s") {
        Console.WriteLine("Ingrese edad");
        int edad = Convert.ToInt32(Console.ReadLine());
        suma = suma + edad;
        cant = cant + 1;
    }
}
if (suma > 0) {
    double prom = suma / cant;
    Console.WriteLine($"El promedio de {cant} edades es {prom}");
}