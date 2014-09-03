﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskScheduler
{
    [PetaPoco.TableName("ScheduledWaypoint")]
    public class ScheduledWaypoint
    {
        public string Code {get; set;}
        public bool FullRefresh {get; set;}
        public DateTime DateAdded {get; set;}
    }
}
