using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;


// Задание 5 Реализуйте класс «Сотрудник». Необходимо хранить в полях класса:
//  ФИО, дату рождения, контактный телефон, рабочий email, должность, описание 
//  служебных обязан- ностей. Реализуйте методы класса для ввода данных, вывода данных, 
//  реализуйте доступ к отдельным полям через
// методы класса.
namespace hw2
{
     class Worker
    {
        
        private StringBuilder name;
        private StringBuilder patronymic;
        private StringBuilder surname;
        private StringBuilder birthday;
        private StringBuilder phone;
        private StringBuilder email;
        private StringBuilder jobTitle;
        private StringBuilder requirements;

 public Worker(){
     name = new StringBuilder();
            patronymic = new StringBuilder();
            surname = new StringBuilder();
            birthday = new StringBuilder();
            phone = new StringBuilder();
            email = new StringBuilder();
            jobTitle = new StringBuilder();
            requirements = new StringBuilder();
 }

 public Worker(StringBuilder name, StringBuilder patronymic, StringBuilder surname, StringBuilder birthday, StringBuilder phone, StringBuilder email, StringBuilder jobTitle, StringBuilder requirements){

this.name = name;
this.patronymic = patronymic;
this.surname = surname;
this.birthday = birthday;
this.phone = phone;
this.email = email;
this.jobTitle = jobTitle;
this.requirements = requirements;

 }
 public string Name { get => name.ToString(); set => name.Clear().Append(value); }
        public string Patronymic { get => patronymic.ToString(); set => patronymic.Clear().Append(value); }
        public string Surname { get => surname.ToString(); set => surname.Clear().Append(value); }
        public string Birthday { get => birthday.ToString(); set => birthday.Clear().Append(value); }
        public string Phone { get => phone.ToString(); set => phone.Clear().Append(value); }
        public string Email { get => email.ToString(); set => email.Clear().Append(value); }
        public string JobTitle { get => jobTitle.ToString(); set => jobTitle.Clear().Append(value); }
        public string Requirements { get => requirements.ToString(); set => requirements.Clear().Append(value); }


public void input(){
    Console.WriteLine("enter name: ");
     Name = Console.ReadLine();

    Console.WriteLine("enter patronymic: ");
      Patronymic = Console.ReadLine();

    Console.WriteLine("enter surname: ");
       Surname = Console.ReadLine();

    Console.WriteLine("enter birthday: ");
           Birthday = Console.ReadLine();

    Console.WriteLine("enter phone: ");
       Phone = Console.ReadLine();

    Console.WriteLine("enter email: ");
       Email = Console.ReadLine();

    Console.WriteLine("enter job title: ");
       JobTitle = Console.ReadLine();

    Console.WriteLine("enter requirements: ");
       Requirements = Console.ReadLine();
}

public void print(){
  Console.Write("name: " + Name + "\npatronymic: " + Patronymic + "\nsurname: " + Surname + "\nbirthday: " + Birthday + "\nphone: " + Phone + "\nemail: " + Email + "\njob title:" + JobTitle + "\nrequirements: " + Requirements + "\n");
}


    }
}

