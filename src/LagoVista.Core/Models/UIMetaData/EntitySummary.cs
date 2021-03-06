﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LagoVista.Core.Models.UIMetaData
{
    public class EntitySummary
    {
        public String Name { get; set; }
        public String DomainKey { get; set; }
        public String ClassName { get; set; }

        public static EntitySummary Create(EntityDescription desc)
        {
            return new EntitySummary()
            {
                ClassName = desc.Name,
                Name = desc.Title,
                DomainKey = desc.DomainName
            };
        }
    }
}
