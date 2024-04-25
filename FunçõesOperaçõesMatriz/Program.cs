int qlinhas = 0, qcolunas = 0, operacao = 0;
float[,] matrizInicial = new float[qlinhas, qcolunas];
float[,] matrizFinal = new float[qlinhas, qcolunas];
float[,] matrizResultado = new float[qlinhas, qcolunas];
float[,] matrizBase = new float[qlinhas, qcolunas];
float[,] matrizRandom = new float[qlinhas, qcolunas];

void incluirMatrizBase(float[,] matriz);
{
    for (int linha = 0; linha < qlinhas; linha++)//percorrer a linha
    {
        for (int coluna = 0; coluna < qcolunas; coluna++)//percorrer a coluna
        {
            Console.WriteLine(matrizBase[linha, coluna] + " ");
        }
    }
}
void incluirMatrizRandom(float[,] matrizRandom);
{
    for (int linha = 0; linha < qlinhas; linha++)
    {
        for (int coluna = 0; coluna < qcolunas; coluna++)
        {
            matrizRandom[linha, coluna] = new Random().Next(0, 10);
        }
    }
}
void RecebeTamanho(int tamanho);
{
    Console.WriteLine("Digite a quantidade de linhas desejadas: ");
    qlinhas = Console.ReadLine();

    Console.WriteLine("Digite a quantidade de colunas desejadas: ");
    qcolunas = Console.ReadLine();
    //Como incluir os valores na matrizBase?
}

Console.WriteLine("Escolha a operação desejada: \n1-Soma\n2-Subtracao\n3-Multiplicacao\n4-Divisao");
operacao = int.Parse(Console.ReadLine());

switch (operacao)
{
    case (operacao == 1)://Soma
        incluirMatrizBase();
        matrizResultado[qlinhas, qcolunas] = matrizInicial[qlinhas, qcolunas] + matrizFinal[qlinhas, qcolunas];
        Console.WriteLine("A soma é igual a " + matrizResultado);
        break;
    case (operacao == 2)://Subtração
        incluirMatrizBase();
        matrizResultado[qlinhas, qcolunas] = matrizInicial[qlinhas, qcolunas] - matrizFinal[qlinhas, qcolunas];
        Console.WriteLine("A subtração é igual a " + matrizResultado);
        break;
    case (operacao == 3)://multiplicação
        incluirMatrizBase();
        matrizResultado[qlinhas, qcolunas] = matrizInicial[qlinhas, qcolunas] * matrizFinal[qlinhas, qcolunas];
        Console.WriteLine("A multiplicação é igual a " + matrizResultado);
        break;
    default://divisão
        incluirMatrizBase();
        do
        {
            (matrizFinal[qlinhas, qcolunas] != 0)
            matrizResultado[qlinhas, qcolunas] = matrizInicial[qlinhas, qcolunas] / matrizFinal[qlinhas, qcolunas];
        }
        while (matrizResultado[qlinhas, qcolunas] = float.NaN;)
        
    Console.WriteLine("A divisão é igual a " + matrizResultado);
        break;
}
