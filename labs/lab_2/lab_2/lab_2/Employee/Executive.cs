using System;

namespace lab_2.Employee;

public class Executive : Employee
{
    private int _index;
    public Executive(int matricule, string firstname, string lastname, DateTime dateOfBirth, int index) : base(matricule, firstname, lastname, dateOfBirth)
    {
        _index = index;
    }

    public override void ex3_toString()
    {
        Console.WriteLine("The executive with the matricule " + _matricule + ", with the first name : " + _firstname + " and the last name : "+ _lastname+ " and his date of birth is : "+ _dateOfBirth + " with the index: "+ _index);
        Console.WriteLine("His salary is equal : "+ GetSalary() +" DH/month");
        
    }

    public override int GetSalary()
    {
        int salary;
        switch (_index)
        {
            case 1:
                salary = 13000;
                break;
            case 2:
                salary = 15000;
                break;
            case 3:
                salary = 17000;
                break;
            case 4:
                salary = 20000;
                break;
            default:
                Console.WriteLine("error salary sets to 0");
                salary = 0;
                break;
        }

        return salary;
    }
}