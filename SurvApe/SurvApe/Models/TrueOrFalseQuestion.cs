﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurvApe.Models
{
    public class TrueOrFalseQuestion
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public QuestionType Type { get; set; }
        public bool Answer { get; set; }
    }
}