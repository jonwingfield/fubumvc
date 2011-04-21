﻿using System;

namespace Bottles.Deployment.Diagnostics
{
    public interface IDeploymentDiagnostics
    {
        void LogHost(HostManifest hostManifest);

        void LogInitializer(IInitializer initializer, HostManifest host, Action<IInitializer> action);
        void LogDeployer(IDeployer deployer, HostManifest host, Action<IDeployer> action);
        void LogFinalizer(IFinalizer finalizer, HostManifest host, Action<IFinalizer> action);
        

        void LogDirective(IDirective directive, HostManifest host);
        void LogDeployment(IDeployer deployer, IDirective directive);

        void LogExecution(object target, string description, Action continuation);
    }
}