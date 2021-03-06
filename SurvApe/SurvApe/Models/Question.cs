﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SurvApe.Models
{
    public class Question
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public virtual Pollster pollster { get; set; }
        public virtual List<Answer> Answers { set; get; }
        
        public string QuestionText { get; set; }
        public string AnswerOptionString { get; set; }
        public bool? AnswerOptionBool { get; set; }
        public QuestionType Type { get; set; }
        public string UserID { get; set; }
        public IEnumerable<int> AvailableAnswer => Enumerable.Range(1, 10);
        public string RespondantID { get; set; }
        public string PollsterID { get; set; }
        public int SurveyID { get; set; }

        public Question()
        {
            Answers = new List<Answer>();
        }
    }
}