﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZList.Domain.Core
{
    public class DJList
    {
        public int ListId { get; set; }
        public string ListName { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Owner { get; set; }
    }
}
