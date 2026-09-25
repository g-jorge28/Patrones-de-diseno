using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class Control_Remoto
    {
        public IDispositivo _dispositivo { get; set; }
        public Control_Remoto(IDispositivo dispositivo)
        {
            _dispositivo = dispositivo;
        }
        public void PresionarBotonEncendido()
        {
            Console.WriteLine(" Botón de encendido presionado.");
            _dispositivo.Encender();
        }
    }
}
