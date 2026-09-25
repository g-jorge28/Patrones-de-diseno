using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class Control_Remoto_Avanzado : Control_Remoto
    {
        public IDispositivo _dispositivo { get; set; }
        public Control_Remoto_Avanzado(IDispositivo dispositivo) : base(dispositivo) { }
        public void SilenciarDispositivo()
        {
            Console.WriteLine(" Botón de silencio presionado.");
        }
    }
}
