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
                if (project.Title == value)
                {
                    return;
                }
                project.Title = value;
                this.ActivateSignal("titleChanged");
            }
        }

        [NotifySignal]
        public string Summary {
            get {
                return project.Summary;
            }
            set {
                project.Summary = value;
                this.ActivateSignal("summaryChanged");
            }
        }

        static int updateCounter = 0;
        public void ChangeProperties()
        {
            updateCounter++;
            UpdateTime = "new datetime (" + updateCounter.ToString() + ")";
            Summary = "new summary (" + updateCounter.ToString() + ")";
            Title = "new title (" + updateCounter.ToString() + ")";
            
            Console.WriteLine("UpdateTime, Summary and Title are changed");
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
                if (project.UpdateTime == value)
                {
                    return;
                }

                project.UpdateTime = value;
                this.ActivateSignal("updateTimeChanged");
            }
        }
    }
}
