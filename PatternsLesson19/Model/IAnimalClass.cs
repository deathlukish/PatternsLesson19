﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLesson19.Model
{
    internal interface IAnimalClass
    {
        string Name { get; set; }
        string Description { get; set; }
        string Location { get; set; }
    }
}
