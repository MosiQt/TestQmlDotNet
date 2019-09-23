using System;

namespace SkeletonApp.Model
{
    internal sealed class Project
    {
        public Project(int id)
        {
            Id = id;
            Title = $"Lorem ipsum {Id}";
            Summary = "Summary"; 
            UpdateTime = "1/1/2000";
        }

        public int Id {get; set;}
        public string Title { get; set;}
        public string Summary { get; set;}
        public string UpdateTime { get; set; }
    }
}
