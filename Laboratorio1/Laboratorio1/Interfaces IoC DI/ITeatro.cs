using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;


namespace Laboratorio1.Interfaces_IoC_DI
{
    public interface ITeatro : IReportServiceLifetime
    {
        string Nombre { get; }
        ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Scoped;
        void PresentarenTeatro();
    }
}
