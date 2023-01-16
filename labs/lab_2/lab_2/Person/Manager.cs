using System;

namespace lab_2.Person;

public class Manager : Employe
{
    private string departement;

    public Manager(int salary, string departement) : base(salary)
    {
        this.departement = departement;
    }

    public Manager(Person p1, int salary, string departement) : base(p1, salary)
    {
        this.departement = departement;
    }

    public Manager(string firstName, string lastName, int age, int salary, string departement) : base(firstName, lastName, age, salary)
    {
        this.departement = departement;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("I'm a manager");
    }
}