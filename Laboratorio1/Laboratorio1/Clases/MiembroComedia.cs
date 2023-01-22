using System;
using System.Collections.Generic;
using System.Text;
using Laboratorio1.Interfaces_IoC_DI;

namespace Laboratorio1.Clases
{
    internal class MiembroComedia : IMiembro
    {
        public string Nombre => $"Keila {Guid.NewGuid().ToString()[..4]}";

        public string DPI => $"3032194400108 {Guid.NewGuid().ToString()[..4]}";

        public string Personaje => $"Encaje Antiguo {Guid.NewGuid().ToString()[..4]}";

        Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();

        public void ConocerPersonaje()
        {
            Console.WriteLine($"{Nombre} forma parte de una obra de comedia como: {Personaje}");
        }
    }
}
