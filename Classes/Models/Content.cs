﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileworxNews.Shared.Models
{
    public class Content : FileWorxEntity
    {
        public string Description { get; set; }

        public string Body { get; set; }
    }
}
