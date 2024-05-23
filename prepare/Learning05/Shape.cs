using System;
using System.Collections.Generic;
using System.Formats.Asn1;

public abstract class Shape
{
    private string _color;

    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }

    public abstract double GetArea();
    
}