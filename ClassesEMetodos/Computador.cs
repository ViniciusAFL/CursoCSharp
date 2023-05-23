using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Computador
    {
        public string Fonte;
        public string MemoriaRam;
        public string Processador;
        public string PlacaDeVideo;
        public string HD;
    
        public string Configuracoes()
        {
            return string.Format($"Configurações Do Computador: {Processador}, {MemoriaRam}, {PlacaDeVideo}, {HD}");
        }

        public void MostrarConfigs()
        {
            Console.WriteLine(Configuracoes());
        }
    }
}
