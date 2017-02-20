﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstMVCApplication.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }

    }
}