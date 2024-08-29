using Aula02;
//Tad se refere a tipo abstrato de dados

Person person = new Person();
Console.WriteLine(person.Name);

Person person1 = new Person("Mauricio Gonzatto", 40);
Console.WriteLine(person1.Name);

Person person2 = new Person();
person2.Name = "Vladimir Motoboy";
person2.Age = 70;
Console.WriteLine(person2.Name);


Person person3 = new Person(){
    Name = "Leonel Brizola",
    Age = 80
};
Console.WriteLine(person3.Name);