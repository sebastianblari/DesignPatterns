﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Gradebook
{
    public class NamedObject
    {
        public NamedObject(string name)
        {
            Name = name;
        }

        public string Name
        {
            get;
            set;
        }
    }
}
