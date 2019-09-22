using SkeletonApp.Model;
using System;
using System.Threading.Tasks;
using Qml.Net;

namespace SkeletonApp.ViewModels
{
    public sealed class ProjectViewModel
    {
        readonly private Project project;

        internal ProjectViewModel(Project project)
        {
            this.project = project;
        }

        public int ProjectId => project.Id;


        [NotifySignal]
        public string Title {
            get {
                return project.Title;
            }
            set {
                project.Title = value;
                this.ActivateSignal("titleChanged");
            }
        }

        public string Summary => project.Summary;

        public string Text => project.Text;

        [NotifySignal]
        public string Image => project.Image;

        [NotifySignal]
        public string ImagePreview => project.ImagePreview;

        public void ChangeTitle()
        {
            Console.WriteLine("Title about to change");
            Title = "Hello!";
        }

        [NotifySignal]
        public string UpdateTime
        {
            get
            {
                return project.UpdateTime.ToString();
            }

            set
            {
                var newTime = Convert.ToDateTime(value);
                if (project.UpdateTime == newTime)
                {
                    return;
                }

                project.UpdateTime = newTime;
            }
        }

        public async Task<string> PublishAsync()
        {
            await Task.Delay(10000);
            UpdateTime = DateTime.Now.ToString();
            return UpdateTime;
        }
    }
}
