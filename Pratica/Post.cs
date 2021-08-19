
using System;
using System.Text;
using System.Collections.Generic;

namespace SBuilder
{
    class Post
    {
        public DateTime moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post(DateTime moment, string title, string content, int likes)
        {
            this.moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }


        public void addComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void Removecomment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append("Likes - ");
            sb.AppendLine(moment.ToString("dd/MM/yyyy HH:mm:s"));
            sb.AppendLine(Content);

            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();
        }

    }
}
