﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chen_Xuxian_HW5.Models
{
    public class Language
    {
        public Int32 LanguageID { get; set; }

        public String Name { get; set; }

        public List<Repository> Repositories { get; set; }
    }
}