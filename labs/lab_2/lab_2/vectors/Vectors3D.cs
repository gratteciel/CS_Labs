using static System.Math;
namespace lab_2;

public class Vectors3D : Vectors2D
{
    private double z;

    public Vectors3D() : base()
    {
        this.z = 0;
    }

    public Vectors3D(double x, double y,double z) : base(x, y)
    {
        this.z = z;
    }

    public Vectors3D(Vectors3D v) : base(v)
    {
        z = v.z;
        y = v.y;
        x = v.x;

    }

    public double Z
    {
        get { return z; }
        set { z = value; }
    }

    public string Vectors3D_ToString()
    {
        string sentence = base.Vectors2D_ToString() + "and the height : " + Z;
        return sentence;
    }

    public bool equals()
    {
        if (Z == base.X  && Z == base.Y && base.X == base.Y)
        {
            return true;

        }
        else
        {
            return false;
        }
    }

    public double Norm3D()
    {
        double temp = Pow(base.X, 2) + Pow(base.Y, 2) + Pow(Z,2);
        temp = Sqrt(temp);
        return temp;
    }
    
    

}