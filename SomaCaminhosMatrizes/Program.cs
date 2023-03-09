double[,] table = new double[5, 5];
double[] vetorAux = new double[5];
double[] vetorAux2 = new double[5];
double[] vetorAux3 = new double[1];
double[] vetorAux4 = new double[1];

Random rnd = new Random();

for (int row = 0; row < 5; row++)
{
    for (int col = 0; col < 5; col++)
    {
        int num = rnd.Next(10);
        table[row, col] = num;
        Console.Write(" | " + table[row, col] + " | ");
    }
    Console.WriteLine("\n");
}

for (int row = 0; row < 5; row++)
{
    for (int col = 0; col < 5; col++)
    {
        vetorAux[row] += table[row, col];
    }
    Console.WriteLine($"Soma da linha {row + 1}: {vetorAux[row]} ");
}

Console.WriteLine("\n");

for (int col = 0; col < 5; col++)
{
    for (int row = 0; row < 5; row++)
    {
        vetorAux2[col] += table[row, col];
    }
    Console.WriteLine($"Soma da coluna {col + 1}: {vetorAux2[col]} ");
}

Console.WriteLine("\n");

for (int i = 0;i < 5; i++)
{
    vetorAux3[0] += table[i, i];
    vetorAux4[0] += table[4 - i, i];
}
Console.WriteLine($"Soma da diagonal principal: {vetorAux3[0]} ");
Console.WriteLine($"Soma da diagonal principal: {vetorAux4[0]} ");