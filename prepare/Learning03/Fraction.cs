using System;
using System.Security.Cryptography.X509Certificates;

public class Fraction
{
    private int _top;
    private int _bottom;
            
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
        
    }
    public Fraction(int WholeNumber)
    {
        _top = WholeNumber;
        _bottom = 1;
        
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
        
    }
    public double getDecimalValue(){
        
        double fractionDouble = (double)_top/_bottom;
        return fractionDouble;
    }
    public string getFraction(){
        _top.ToString();
        _bottom.ToString();
        string fractionString = _top + "/" + _bottom;
        return fractionString;
    }


}