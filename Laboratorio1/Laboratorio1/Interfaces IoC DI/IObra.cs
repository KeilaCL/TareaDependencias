using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Laboratorio1.Interfaces_IoC_DI
{
    public interface IObra : IReportServiceLifetime
    {
        ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Singleton;
        public string Genero { get; }
        void AgregarObra();
    }
}
