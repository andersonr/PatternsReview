﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Adapter
{
    internal interface ILion
    {
        string Name { get; }
        public void Roar();
    }
}
