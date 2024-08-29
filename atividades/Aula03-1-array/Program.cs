//-------------------------------------
// Array unidimensional

// int[] numbers;
// numbers = new int[5]; //recebe 5 posições

// //atribuição de valor direta ao índice do vetor
// numbers[0] = 1;
// numbers[1] = 2;
// numbers[2] = 3;
// numbers[3] = 4;
// numbers[4] = 5;

// //Declaração inicializada
// string[] names = {"Eu", "Tu", "Ele","Nós", "Vós", "Eles"};

// //Exemplo Vetor com os nomes dos meses

//string[] months = new string[12];
// for(int i=1; i<=12; i++){
//     DateTime firstDay = new DateTime(DateTime.Now.Year, i, 1);

//     string name = firstDay.ToString("MMMM");

//     months[i-1] = name;
// }

// foreach(string m in months){
//     Console.WriteLine(m);
// }

//-------------------------------------//-------------------------------------//-------------------------------------//-------------------------------------
//--------Atividade
//Escrever algoritimo que armazene dois vetores separados com os primeiros 100 numeros impares e pares


int[] pares = new int[50];
int[] impares = new int[50];

int contpar = 0;
int contimpar = 0;

for (int i = 1; i <= 100; i++){
    if(i % 2 == 0){
        pares[contpar] = i;
        contpar++;
    }
    else{
        impares[contimpar] = i;
        contimpar++;
    }
}

foreach(int np in pares){
    Console.WriteLine(np);
}

Console.WriteLine("----------------------------");

foreach(int ni in impares){
    Console.WriteLine(ni);
}