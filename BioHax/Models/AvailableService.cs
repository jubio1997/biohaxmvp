﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BioHax.Models
{
    public class AvailableService : Service
    {
        public virtual string Description { get; set; }
        public string Provider { get; set; }
        public string Type { get; set; }
    }
}
