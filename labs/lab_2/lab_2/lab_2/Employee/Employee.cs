using System;

namespace lab_2.Employee;

public abstract class Employee
{

    protected int _matricule;
    protected string _firstname;
    protected string _lastname;
    protected DateTime _dateOfBirth;
    

    protected Employee(int matricule, string firstname, string lastname, DateTime dateOfBirth)
    {
        _matricule = matricule;
        _firstname = firstname;
        _lastname = lastname;
        _dateOfBirth = dateOfBirth;
    }

    // need to create abstract method because we'll use it in derive inheritance class 
    public abstract void ex3_toString();

    public abstract int GetSalary();
}