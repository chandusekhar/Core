﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LagoVista.Core.Interfaces
{
    public interface IKeyedEntity
    {
        String Key { get; set; }
    }
}
