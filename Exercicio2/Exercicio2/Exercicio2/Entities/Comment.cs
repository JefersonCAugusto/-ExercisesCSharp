﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2.Entities
{
    class Comment
    {
        public string  Text { get; set; }

        public Comment(string text)
        {
            Text = text;
        }

        public Comment()
        {
        }

    }
}
