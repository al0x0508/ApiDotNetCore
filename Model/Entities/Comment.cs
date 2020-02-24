﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entities
{
    public class Comment
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Movie Movie { get; set; }
    }
}
