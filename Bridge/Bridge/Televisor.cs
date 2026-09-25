using Bridge;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class Televisor : IDispositivo
    {
        public void Encender() => Console.WriteLine(" Televisor encendido.");
    }
}