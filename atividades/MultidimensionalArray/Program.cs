// Criando um vetir multidimensional
// Com 5 linhas e 2 colunas

int[,] numbers = new int [5,2];

// Criando um vetor Tridimensional

int[,,] trinumbers = new int [5,4,3];

// Podemos inicializar os valores do vetor
// no momento de sua declaração

int[,] ininumbers = new int[,]{
    {9,5,9},
    {19,15,90},
    {29,255,239},
    {3,35,39},
    {49,45,93},
};

// Para acessar os valores contidos neste tipo de variavel
int valor = ininumbers[0,1]; // neste caso = ao valor *5* da matriz acima


//Console.WriteLine($"iniNumbers[0,1] = {valor}");


int menorvalor = ininumbers[0,0];
int maiorvalor = ininumbers[0,0];

for(int i = 0; i < 5; i++){
    for(int j = 0;j < 3; j++){
        if(ininumbers[i,j] > maiorvalor){
            maiorvalor = ininumbers[i,j];
        }
        else if (ininumbers[i,j] < menorvalor){
            menorvalor = ininumbers[i,j];
        
        }
    }
}

Console.WriteLine($"O maior valor é: {maiorvalor}");
Console.WriteLine($"O menor valor é: {menorvalor}");
