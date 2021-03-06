﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance
{

    // where T : IComparable  - // Interface
    // where T : Product - //Type of class - where product is class or sub  classes
    // Where T : Struct - Type is value Type 
    // Where T : Class - Reference type
    // Where T : new() - Default constructor

    public class Utilities<T> where T : IComparable, new()
    {

        public int Max(int a, int b)
        {
            return a > b ? a : b;

        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;

        }

    }
    //public class Utilities
    //{

    //    public int Max(int a, int b)
    //    {
    //        return a > b ? a : b;

    //    }

    //    public T Max<T>(T a , T  b) where T : IComparable
    //    {
    //        return a.CompareTo(b) > 0 ? a : b;

    //    }

    //}
}
