using System;
using System.Collections.Generic;
using System.Text;


namespace Exercicio2.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public int Likes { get; set; }
        public Comment Comments { get; set; }

        public Post(DateTime moment, string title)
        {
            Moment = moment;
            Title = title;
        }
    }
}
