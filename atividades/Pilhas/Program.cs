// Basicamente as piilhas trabalham com uma estrutura LIFO -> Last In First Out
// Três métodos importantes: 
// Push() -> Insere um elemento no topo da pilha
// Pop() -> Remove um elemento do topo e o retorna
// Peek() -> Retorna o elemento do topo sem remove-lo

//Invertendo as bolas

using System.Runtime.CompilerServices;

Stack<char> caracteres = new Stack<char>();

foreach(char c in "DARCY DA MONTANHA"){
    caracteres.Push(c);
}

//Desempilhando
string invertido = string.Empty;
while(caracteres.Count > 0){
    invertido += caracteres.Pop();
}

Console.WriteLine(invertido);

//utilizando o conceito de pliha esreva um programa que leia uma entrada do usupário e identifique se a palavra informada
// é ou não um palindromos




Stack<char> letras = new Stack<char>();

Console.WriteLine("Digite uma palavra para ser conferida se é um palindromo");
string? colocador = Console.ReadLine();

foreach(char c in colocador){
    letras.Push(c);
}

string palavra = string.Empty;
while(letras.Count > 0){
    palavra += letras.Pop();
}

if(palavra == colocador){
    Console.WriteLine("É um palindromo");
}
else{
    Console.WriteLine("Não é um palindromo");
}