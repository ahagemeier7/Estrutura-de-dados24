using ListaGenerica;

//Diferença entre ArrayList e List é que o primeiro não é fortemente tipado
//  "<>"   Especifica um tipo

List<double> numbers = new List<double>();

do{
    Console.WriteLine("Informe um número:");
    string? numberStr = Console.ReadLine();
    //Validando a entrada do usuário
    if(!double.TryParse(numberStr,out double number)){
        break;
    }

    numbers.Add(number);
    Console.WriteLine($"A média dos valores é: {numbers.Average()}");
}
while(true);

/*

 int a = 10;
 int teste(int x){
  x = 5;
  Console.WriteLine(X) Por valor = 5 Por referencia = 5
  Console.WriteLine(a) Por valor = 10  Por referencia = 5 (Por referencia x vira um ponteiro pro a)
    }
    teste(a)

*/


// -- Lista de Pessoas
List<Person> people = new List<Person>();

Person p1 = new Person();
p1.Name = "Joaquim";
p1.Age = 15;
p1.Country = CountryEnum.PY;
people.Add(p1);

people.Add(
    new Person()
    {
    Name = "Joao",
    Age = 60,
    Country = CountryEnum.PY
}
);

Person p3 = new Person(){
    Name = "Arnold",
    Age = 60,
    Country = CountryEnum.BR
};
people.Add(p3);


//Formas de percorrer a Lista Genérica

foreach(Person p in people){
    Console.WriteLine(p.Name);
}

//For tradicional

for(int i = 0; i<people.Count; i++){
    Console.WriteLine(people[i].Name);
}



