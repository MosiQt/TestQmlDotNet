using SkeletonApp.Model;
using SkeletonApp.ViewModels;
using System;
namespace SkeletonApp
{
    public class NetAppContext
    {
        private readonly FeedViewModel feedViewModel;
        private readonly ProjectViewModel projectViewModel;

        public NetAppContext()
        {
            feedViewModel = new FeedViewModel(new Feed());
            projectViewModel = new ProjectViewModel(new Project(10));
        }

        public FeedViewModel GetFeedViewModel() => feedViewModel;
        public ProjectViewModel GetProjectViewModel() => projectViewModel;
    }
}
