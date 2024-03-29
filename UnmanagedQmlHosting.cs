﻿using Qml.Net;
using Qml.Net.Runtimes;

namespace SkeletonApp
{
    internal class UnmanagedQmlHosting : BaseQmlHosting
    {
        public UnmanagedQmlHosting()
        {
            RuntimeManager.DiscoverOrDownloadSuitableQtRuntime();
        }

        override protected int RunHostOverride(string[] _)
        {
            return Host.Run(_, (args, app, engine, runCallback) =>
            {
                RegisterTypes();

                return runCallback();
            });
        }
    }
}
