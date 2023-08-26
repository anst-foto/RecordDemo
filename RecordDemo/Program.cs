using RecordDemo;

var person1 = new ClassPerson()
{
    FirstName = "Andrey",
    LastName = "Starinin"
};

var person2 = new ClassPerson()
{
    FirstName = "Andrey",
    LastName = "Starinin"
};

Console.WriteLine($"{person1} == {person2} -> {person1.Equals(person2)}");

var person3 = new RecordPerson("Andrey", "Starinin");
var person4 = new RecordPerson("Andrey", "Starinin");
Console.WriteLine($"{person3} == {person4} -> {person3.Equals(person4)}");