using System.Collections;

// Utilizando a lista simples
ArrayList arrlist = new ArrayList();
arrlist.Add(5);
arrlist.Add("Mauricio");
//É possivel adicionar um conjunto de valores de uma só vez
arrlist.AddRange(new int[]{1,2,3});
// O método .Add() Insere o valor ao final do vetor

arrlist.Insert(0,15);
//Já o Método .Insert() me permite incluir o valor desejado na posição especificada
//no primeiro parâmetro

//Lendo valores da lista
object primeiro = arrlist[0]!;
int quarto = (int)arrlist[3]!;

//Percorrendo a lista com foreach
foreach(object obj in arrlist){
    Console.WriteLine(obj);
}

// Obtendo o tamanho total da lista
int tamanho = arrlist.Count;
Console.WriteLine(tamanho);
//Obter a capacidade
int capacidade = arrlist.Capacity;
Console.WriteLine(capacidade);

//Percorrendo no modo clássico
for(int i = 0;i> arrlist.Count;i++){
    Console.WriteLine(arrlist[i]);
}

//recursos importantes da lista
// verificar se um valor é contido na lista
bool contemNome = arrlist.Contains("Mauricio");
if(!contemNome){
    Console.WriteLine("Nome não encontrado");
}

//Para saber indice que contem o valor buscado
//Neste caso se o valor existir na lista
//ele retorna o índice (número inteiro)
//caso o valor não exista na lista, retorna -1
int indiceDoValor = arrlist.IndexOf("Mauricio");
if(indiceDoValor >= 0){
    Console.WriteLine(indiceDoValor);
}
else
 Console.WriteLine("Realmente n tem");

//É possivel também remover itens da lista
arrlist.Remove("Mauricio");//remove pelo valor 
arrlist.RemoveAt(1); //remove no indice 
arrlist.RemoveRange(0,2); // o primeiro parametro é o indice e o segundo é quantas casas após o indice