using static System.Math;

namespace lab_2;

public class Vectors2D
{
    protected double x;
    protected double y;
    private  static int counter = 0;

    public int Counter
    {
        get => counter;
        set => counter = value;
    }


    public Vectors2D()
    {
        this.x = 0;
        this.y = 0;
        counter++;
    }

    public Vectors2D(double x, double y)
    {
        this.x = x;
        this.y = y;
        counter++;
    }

    public Vectors2D(Vectors2D v)
    {
        x = v.x;
        y = v.y;
        counter++;
    }
    public double X
    {
        get { return x;}
        set { x = value;}
    }
    public double Y
    {
        get { return y;}
        set { y = value;}
    }

    

    public string Vectors2D_ToString()
    {
        string sentence = "The value of the abscissa: " + X + " and the ordinate : " + Y ;
        return sentence; 
    }

    public bool Vectors2D_equals()
    {
        if (X == Y)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public double Norm()
    {
        double temp = Pow(X, 2) + Pow(Y, 2);
        temp = Sqrt(temp);
        return temp;


    }
}