using System;
using System.Collections.Generic;
using System.Text;
using Laboratorio1.Interfaces_IoC_DI;

namespace Laboratorio1.Clases
{
    internal class MiembroDrama : IMiembro
    {
        public string Nombre => $"Javier {Guid.NewGuid().ToString()[..4]}";

        public string DPI => $"1029183730101 {Guid.NewGuid().ToString()[..4]}";

        public string Personaje => $"Pedro Antonio Federico {Guid.NewGuid().ToString()[..4]}";

        Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();

        public void ConocerPersonaje()
        {
            Console.WriteLine($"{Nombre} forma parte de una obra de drama como: {Personaje}");
        }
    }
}
