using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkeletonApp.Model
{
    internal sealed class Feed
    {
        private readonly List<Project> projects;
        public Feed()
        {
            projects = Enumerable.Range(0, 10)
                .Select(_ => new Project(_))
                .ToList();

        }

        public IEnumerable<Project> Projects => projects;
    }
}
