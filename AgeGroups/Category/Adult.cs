﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeGroups.Category
{
    class Adult : Human
    {
        public override void Show()
        {
            base.Show();
            Console.WriteLine();
        }
    }
}