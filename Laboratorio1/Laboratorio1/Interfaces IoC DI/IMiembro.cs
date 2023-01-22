using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Laboratorio1.Interfaces_IoC_DI
{
    public interface IMiembro : IReportServiceLifetime
    {
        ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Transient;

        string Nombre { get; }
        string DPI { get; }
        string Personaje { get; }
        void ConocerPersonaje();
    }
}
