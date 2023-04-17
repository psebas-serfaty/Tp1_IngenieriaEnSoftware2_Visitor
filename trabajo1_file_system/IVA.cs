using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class IVA : IVisitor
{
    private double impuestoClase1 = 1.21d;
    private double impuestoClase2 = 1.105d;

    public double Visitar(ProductoClase2 p)
    {
        return p.Precio * impuestoClase2;

    }

    public double Visitar(ProductoClase1 p)
    {
        return p.Precio * impuestoClase1;
    }
}