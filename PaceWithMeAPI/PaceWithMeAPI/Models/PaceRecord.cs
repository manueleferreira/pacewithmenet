﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaceWithMeAPI.Models
{
    public class PaceRecord
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Text { get; set; }
    }
}