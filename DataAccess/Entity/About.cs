﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class About
    {
        public int ID { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Title3 { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public bool Status { get; set; }
    }
}
