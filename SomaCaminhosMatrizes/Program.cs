double[,] table = new double[5, 5];
double[] vetorAux = new double[5];
double[] vetorAux2 = new double[5];
double[] vetorAux3 = new double[1];
double[] vetorAux4 = new double[1];

Random rnd = new Random();

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        int num = rnd.Next(100);
        table[i, j] = num;
        Console.Write(table[i, j] + " ");
    }
    Console.WriteLine("\n");
}

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        vetorAux[i] += table[i, j];
    }
    Console.WriteLine(vetorAux[i] + " ");
}

Console.WriteLine("\n");

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        vetorAux2[i] += table[j, i];
    }
    Console.Write(vetorAux2[i] + " ");
}

Console.WriteLine("\n");

for (int i = 0;i < 5; i++)
{
    vetorAux3[0] += table[i, i];
    vetorAux4[0] += table[4 - i, i];
}
Console.Write(vetorAux3[0] + " ");
Console.Write(vetorAux4[0] + " ");