using System;

namespace lab_2.Employee;

public class Worker : Employee
{

    private int _seniority;
    public Worker(int matricule, string firstname, string lastname, DateTime dateOfBirth,int seniority) : base(matricule, firstname, lastname, dateOfBirth)
    {
        _seniority = seniority;
    }


    public override void ex3_toString()
    {
        Console.WriteLine("The worker with the matricule " + _matricule + ", with the first name : " + _firstname + " and the last name : "+ _lastname+ " and his date of birth is : "+ _dateOfBirth + " with a seniority of : " + " years");
        Console.WriteLine("His salary is equal : "+ GetSalary() +" DH/month");

    }

    public override int GetSalary()
    {
        const int SMIG = 2500;
        int salary = 0;
        salary = SMIG + (_seniority * 100);
        if (salary > SMIG * 2)
        {
            Console.WriteLine("Salary is gapped");
            return SMIG * 2;
        }
        else
        {
            return salary;
        }
            
        
        

    }
}