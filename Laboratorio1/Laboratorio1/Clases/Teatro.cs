using System;
using System.Collections.Generic;
using System.Text;
using Laboratorio1.Interfaces_IoC_DI;

namespace Laboratorio1.Clases
{
    internal sealed class Teatro : ITeatro
    {
        Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
        private readonly IEnumerable<IObra> _obraSingleton;

        public string Nombre => $"Teatro Lux {Guid.NewGuid().ToString()[..4]}";
        public Teatro(IEnumerable<IObra> obraSingleton)
        {
            _obraSingleton = obraSingleton;
        }
        public void PresentarenTeatro()
        {
            foreach (var obra in _obraSingleton)
            {
                LogService(obra, "Obra Singleton");
                obra.AgregarObra();
            }
        }

        private static void LogService<T>(T service, string message)
           where T : IReportServiceLifetime =>
           Console.WriteLine(
               $"    {typeof(T).Name}: {service.Id} ({message})");

    }
}
