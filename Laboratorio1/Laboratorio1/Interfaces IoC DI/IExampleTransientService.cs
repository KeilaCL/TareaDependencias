using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;


namespace Laboratorio1.Interfaces_IoC_DI
{
    public interface IExampleTransientService : IReportServiceLifetime
    {
        ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Transient;
    }
}
