﻿using System;
using Autofac;
using Common.Log;

namespace Lykke.Service.Dash.Sign.Client
{
    public static class AutofacExtension
    {
        public static void RegisterDashSignClient(this ContainerBuilder builder, string serviceUrl, ILog log)
        {
            if (builder == null) throw new ArgumentNullException(nameof(builder));
            if (serviceUrl == null) throw new ArgumentNullException(nameof(serviceUrl));
            if (log == null) throw new ArgumentNullException(nameof(log));
            if (string.IsNullOrWhiteSpace(serviceUrl))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(serviceUrl));

            builder.RegisterType<DashSignClient>()
                .WithParameter("serviceUrl", serviceUrl)
                .As<IDashSignClient>()
                .SingleInstance();
        }

        public static void RegisterDashSignClient(this ContainerBuilder builder, DashSignServiceClientSettings settings, ILog log)
        {
            builder.RegisterDashSignClient(settings?.ServiceUrl, log);
        }
    }
}
