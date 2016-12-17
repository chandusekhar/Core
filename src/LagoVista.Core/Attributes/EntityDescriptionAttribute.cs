﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LagoVista.Common.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
    public class EntityDescriptionAttribute : Attribute
    {
        private String _name;
        private String _description;
        private String _domain;

        public EntityDescriptionAttribute(String Name = "", String Description = "", String Domain = null)
        {
            _name = Name;
            _description = Description;
            _domain = Domain;
        }

    //    [DomainDescription()]
        public const string Foo = "FO";

        public String Name { get { return _name; } }
        public String Description { get { return _description; } }
        public String Domain { get { return _domain; } }
    }
}