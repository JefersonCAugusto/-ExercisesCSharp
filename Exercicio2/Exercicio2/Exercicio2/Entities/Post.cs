using System;
using System.Collections.Generic;
using System.Text;
using Exercicio2.Entities;

namespace Exercicio2.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public int Likes { get; set; }
        public string Content { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post(DateTime moment, string title)
        {
            Moment = moment;
            Title = title;
        }


        public void AddComent(Comment comment)
        {
            Comments.Add(comment);
        }


        public void RemovComment(Comment comment)
        {
            Comments.Remove(comment);
        }

    }
}
