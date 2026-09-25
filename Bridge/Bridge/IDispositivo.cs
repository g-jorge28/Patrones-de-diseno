using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    // Define las operaciones primitivas que todos los dispositivos deben implementar
    public interface IDispositivo
    {
        void Encender();
    }
}
