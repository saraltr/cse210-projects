using System;
class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        f1.GetFractionString();
        f1.GetDecimalValue();

        Fraction f2 = new Fraction(5);
        f2.GetFractionString();
        f2.GetDecimalValue();

        Fraction f3 = new Fraction(3, 4);
        f3.GetFractionString();
        f3.GetDecimalValue();

        Fraction f4 = new Fraction(1, 3);
        f4.GetFractionString();
        f4.GetDecimalValue();
    }
}