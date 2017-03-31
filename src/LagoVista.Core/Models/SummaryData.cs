﻿using LagoVista.Core.Attributes;
using LagoVista.Core.Interfaces;
using LagoVista.Core.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace LagoVista.Core.Models
{
    public class SummaryData : ISummaryData
    {
        [ListColumn(Visible: false)]
        public String Id { get; set; }

        [ListColumn(HeaderResource: Resources.LagoVistaCommonStrings.Names.Common_IsPublic, ResourceType: typeof(LagoVistaCommonStrings))]
        public bool IsPublic { get; set; }

        [ListColumn(HeaderResource: Resources.LagoVistaCommonStrings.Names.Common_Name, ResourceType: typeof(LagoVistaCommonStrings))]
        public String Name { get; set; }

        [ListColumn(HeaderResource: Resources.LagoVistaCommonStrings.Names.Common_Key, ResourceType: typeof(LagoVistaCommonStrings))]
        public String Key { get; set; }

        [ListColumn(HeaderResource: Resources.LagoVistaCommonStrings.Names.Common_Description, ResourceType: typeof(LagoVistaCommonStrings))]
        public string Description { get; set; }
    }
}
