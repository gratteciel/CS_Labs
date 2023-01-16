using System.Security.Policy;

namespace lab_2.Notification_system;

public class Student
{
    private string _full_name;
    private int _average_grades;
    private int _number_of_courses;

    
    public Student(string fullName, int averageGrades, int numberOfCourses)
    {
        _full_name = fullName;
        _average_grades = averageGrades;
        _number_of_courses = numberOfCourses;
    }

    public Student(Student s)
    {
        this._full_name = s._full_name;
        this._average_grades = s._average_grades;
        this._number_of_courses = s._number_of_courses; 
    }

    public delegate void AvgChanged(double average);

    public void RecordGrade(AvgChanged callback,int grade)
    {
        double avg = (_average_grades * _number_of_courses * grade) / (_number_of_courses + 1);
    }

    public string FullName
    {
        get => _full_name;
        set => _full_name = value;
    }
}