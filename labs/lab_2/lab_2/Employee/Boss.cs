using System;

namespace lab_2.Employee;

public class Boss : Employee
{
    private int _turnover;
    private int _percentage;
    public Boss(int matricule, string firstname, string lastname, DateTime dateOfBirth, int turnover, int percentage) : base(matricule, firstname, lastname, dateOfBirth)
    {
        _turnover = turnover;
        _percentage = percentage;

    }

    public override void ex3_toString()
    {
        Console.WriteLine("The boss with the matricule " + _matricule + ", with the first name : " + _firstname + " and the last name : "+ _lastname+ " and his date of birth is : "+ _dateOfBirth );
        Console.WriteLine("His salary is equal : "+ GetSalary() +" DH/month");
    }

    public override int GetSalary()
    {
        int salary = 0;

        salary = _turnover * _percentage / 100;
        salary = salary / 12; // salary is per month
        return salary;
    }
}