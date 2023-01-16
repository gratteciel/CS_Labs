using System;

namespace lab_2.Person;

public class Director : Manager
{
    private string company;

    public Director(int salary, string departement, string company) : base(salary, departement)
    {
        this.company = company;
    }

    public Director(Person p1, int salary, string departement, string company) : base(p1, salary, departement)
    {
        this.company = company;
    }

    public Director(string firstName, string lastName, int age, int salary, string departement, string company) : base(firstName, lastName, age, salary, departement)
    {
        this.company = company;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("I'm the director");
    }
}