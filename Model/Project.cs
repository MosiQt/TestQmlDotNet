using System;

namespace SkeletonApp.Model
{
    internal sealed class Project
    {
        private static string _loremIpsum = @"Some text, some text, some text, some text, some text.";
        public Project(int id)
        {
            Id = id;
            Title = $"Lorem ipsum {Id}";
            Text = _loremIpsum;
            Summary = $"{Title} "; 
            UpdateTime = new DateTime(2019, 06, 01).AddDays(Id * 3);
            ImagePreview = $"1.png";
            Image = $"1.png";
        }

        public int Id { get; }
        public string Title { get; set;}
        public string Text { get; }
        public string Summary { get; }

        public string ImagePreview { get; }

        public string Image { get; }
        public DateTime UpdateTime { get; set; }
    }
}
