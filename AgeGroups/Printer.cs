﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeGroups
{
    abstract class Printer : AddElementToPrinter
    {
        public abstract void Print();
    }
}