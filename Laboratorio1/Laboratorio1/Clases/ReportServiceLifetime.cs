using System;
using System.Collections.Generic;
using System.Text;
using Laboratorio1.Interfaces_IoC_DI;

namespace Laboratorio1.Clases
{
    internal sealed class ReportServiceLifetime
    {
        private readonly ITeatro _teatroScoped;

        public ReportServiceLifetime(ITeatro TeatroScoped) => _teatroScoped = TeatroScoped;

        public void ReportServiceLifetimeDetails(string lifetimeDetails)
        {
            Console.WriteLine(lifetimeDetails);

            LogService(_teatroScoped, "Se preseta en Teatro Scoped");
            _teatroScoped.PresentarenTeatro();

        }

        private static void LogService<T>(T service, string message)
            where T : IReportServiceLifetime =>
            Console.WriteLine(
                $"    {typeof(T).Name}: {service.Id} ({message})");

    }
}
