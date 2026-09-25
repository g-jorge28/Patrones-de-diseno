using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class Radio : IDispositivo
    {
        public void Encender() => Console.WriteLine(" Radio encendido.");
    }
}
