﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance
{
    public class GenericList<T>
    {

        public void Add(T value)
        {

        }

        public T this[int index]
        {
            get { throw new NotFiniteNumberException(); }
        }
    }
}
