using System;

namespace lab_2.Person;

public class Employe : Person
{
    private int salary;

    public Employe(int salary)
    {
        this.salary = salary;
    }

    public Employe(Person p1, int salary) : base(p1)
    {
        this.salary = salary;
    }

    public Employe(string firstName, string lastName, int age, int salary) : base(firstName, lastName, age)
    {
        this.salary = salary;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("I'm an employee");
    }
}