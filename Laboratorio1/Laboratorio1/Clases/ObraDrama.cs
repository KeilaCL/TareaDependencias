using System;
using System.Collections.Generic;
using System.Text;
using Laboratorio1.Interfaces_IoC_DI;

namespace Laboratorio1.Clases
{
    internal sealed class ObraDrama : IObra
    {
        private readonly IEnumerable<IMiembro> _obraTransient;

        public ObraDrama(IEnumerable<IMiembro> ObraTransient)
        {
            _obraTransient = ObraTransient;
        }

        Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();

        string IObra.Genero => "Drama";

        public void AgregarObra()
        {
            foreach (var miembro in _obraTransient)
            {
                LogService(miembro, "obra Transient");
                miembro.ConocerPersonaje();

            }
        }
        private static void LogService<T>(T service, string message)
           where T : IReportServiceLifetime =>
           Console.WriteLine(
               $"    {typeof(T).Name}: {service.Id} ({message})");

    }
}
