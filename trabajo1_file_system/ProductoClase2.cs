﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ProductoClase2 : Producto
{
    public override double Aceptar(IVisitor v)
    {
        return v.Visitar(this);
    }
}
