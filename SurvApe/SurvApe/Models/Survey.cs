﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace SurvApe.Models
{
    public class Survey
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public virtual Pollster pollster { get; set; }
    }
}