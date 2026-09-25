using Bridge;

class Program
{
    static void Main()
    {
        IDispositivo miTv = new Televisor();
        Control_Remoto controlTv = new Control_Remoto(miTv);

        controlTv.PresionarBotonEncendido(); 


        IDispositivo miRadio = new Radio();
        Control_Remoto_Avanzado controlRadio = new Control_Remoto_Avanzado(miRadio);

        controlRadio.PresionarBotonEncendido(); 
        controlRadio.SilenciarDispositivo();   
    }
}
