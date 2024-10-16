﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
   public interface IShape
    {    
        double CalculateArea();        
    }
    public class ShapeCalculator
    {
        public static double GetArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
