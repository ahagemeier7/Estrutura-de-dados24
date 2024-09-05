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