﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurvApe.Models
{
    public class Respondant
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Zipcode { get; set; }
        public string Citizenship { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Company { get; set; }
        public int Salary { get; set; }
        public string Ethnicity { get; set; }
        public string Religion { get; set; }
        public string Education { get; set; }
        public bool Employed { get; set; }
        public int PoliticalLeaning { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual string UserID { get; set; }










}
}