Console.WriteLine("ELECCIONES");
int voto = 5; 
int c1=0, c2=0, c3=0, c4=0;
while (voto != 0) {
    Console.WriteLine("Ingrese su voto: 1,2,3,4 o 0 para fin");
    voto = Convert.ToInt32(Console.ReadLine());
    if (voto == 1) {
        c1++;
    } else if (voto == 2) { 
        c2++; 
    } else if (voto == 3) {
        c3++;
    } else if (voto == 4) {
        c4++;
    }
}
int total = c1 + c2 + c3 + c4;
Console.WriteLine($"Candidato 1: {c1} votos ({c1 * 100 / total}%)");
Console.WriteLine($"Candidato 1: {c2} votos ({c2 * 100 / total}%)");
Console.WriteLine($"Candidato 1: {c3} votos ({c3 * 100 / total}%)");
Console.WriteLine($"Candidato 1: {c4} votos ({c4 * 100 / total}%)");