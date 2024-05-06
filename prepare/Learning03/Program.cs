using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        frac1.Fraction1();

        int wholeNumber = 5;
        frac1.Fraction1(wholeNumber);

        frac1.SetTop(3);
        frac1.SetBottom(4);
        int top = frac1.GetTop();
        int bottom = frac1.GetBottom();
        frac1.Fraction1(top, bottom);

        frac1.SetTop(1);
        frac1.SetBottom(3);
        top = frac1.GetTop();
        bottom = frac1.GetBottom();
        frac1.Fraction1(top, bottom);
    }
}