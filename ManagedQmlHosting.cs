using Qml.Net;
using Qml.Net.Runtimes;

namespace SkeletonApp
{
    internal class ManagedQmlHosting : BaseQmlHosting
    {
        public ManagedQmlHosting()
        {
            RuntimeManager.DiscoverOrDownloadSuitableQtRuntime();
            QQuickStyle.SetStyle("Universal");
        }
        override protected int RunHostOverride(string[] _)
        {
            using (var app = new QGuiApplication(_))
            {
                using (var engine = new QQmlApplicationEngine())
                {
                    RegisterTypes();

                    LoadViews(engine);

                    return app.Exec();
                }
            }
        }

        private void LoadViews(QQmlApplicationEngine engine)
        {
            engine.Load("Views/Main.qml");
        }
    }
}
