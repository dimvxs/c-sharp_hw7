using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Задание 6 Реализуйте класс «Самолёт». Необходимо хранить в полях класса: 
// название самолёта, название производителя, год выпуска, тип самолёта. 
// Реализуйте конструкторы и методы класса для ввода данных, вывода данных, реа-
// лизуйте доступ к отдельным полям через методы класса.
// Используйте механизм перегрузки методов.

namespace hw2
{
    public class Airplane
    {
        private StringBuilder name;
        private StringBuilder producer;
        private int year;
        private StringBuilder type;



public Airplane(){
    name = new StringBuilder();
    producer = new StringBuilder();
    year = 0;
    type = new StringBuilder();
}


public Airplane(StringBuilder name, StringBuilder producer, int year, StringBuilder type){
    this.name = name;
    this.producer = producer;
    this.year = year;
    this.type = type;
}


        public string Name { get => name.ToString(); set => name.Clear().Append(value); }
        public string Producer { get => producer.ToString(); set => producer.Clear().Append(value); }
        public int Year { get => year; set => year = value; }
        public string Type { get => type.ToString(); set => type.Clear().Append(value); }

public void input(){
    Console.WriteLine("enter name: ");
     Name = Console.ReadLine();

       Console.WriteLine("enter producer: ");
     Producer = Console.ReadLine();

       Console.WriteLine("enter year: ");
       string year = Console.ReadLine();
       int res = int.Parse(year);
       Year = res;

       Console.WriteLine("enter type: ");
       Type = Console.ReadLine();
}

public void output(){
    Console.WriteLine("\nname: " + Name + "\nproducer: " + Producer + "\nyear: " + Year + "\ntype: " + Type + "\n");
}

         
    }
}