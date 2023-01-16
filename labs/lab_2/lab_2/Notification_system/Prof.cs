using System;

namespace lab_2.Notification_system;

public class Prof
{
    private string _fullnameProf;

    public Prof(string fullnameProf)
    {
        _fullnameProf = fullnameProf;
    }
    public string FullnameProf
    {
        get => _fullnameProf;
        set => _fullnameProf = value;
    }
    

    public delegate void ReportDelegate(string studentName, double average);

    public void Report(string studentName, double average)
    {
        Console.WriteLine("My name is"+_fullnameProf+"as a prof, I received the new average of Student named"+studentName +
                          "successfully with the average : "+average);
    }
}