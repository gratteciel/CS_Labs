using System;

namespace lab_2.Person;

public class Person
{
    private string first_name;
    private string last_name;
    private int age;

    public Person()
    {
        this.first_name = "";
        this.last_name = "";
        this.age = 0;
    }

    public Person(Person p1)
    {
        first_name = p1.first_name;
        last_name = p1.last_name;
        age = p1.age;

    }

    public Person(string firstName, string lastName, int age)
    {
        this.first_name = firstName;
        this.last_name = lastName;
        this.age = age;
    }

    public virtual void Display()
    {
        Console.WriteLine("First name :" + first_name +" last name : "+ last_name + " and his age " + age);
    }
}