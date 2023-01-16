using System;

namespace lab_2.Notification_system;

public class Registrar
{
    private string _fullnameRegistrar;

    public Registrar(string fullnameRegistrar)
    {
        _fullnameRegistrar = fullnameRegistrar;
    }

    public string FullnameRegistrar
    {
        get => _fullnameRegistrar;
        set => _fullnameRegistrar = value;
    }

    public delegate void ReportDelegate(string studentName, double average);

    public void Report(string studentName, double average)
    {
        Console.WriteLine("My name is "+ _fullnameRegistrar+"as a Registrar, I received the new average of Student named " + studentName + " successfully." + average);
    }
}