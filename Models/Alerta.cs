using SistemaMonitoramentoAmbiental.Enums;
using SistemaMonitoramentoAmbiental.Structs;

namespace SistemaMonitoramentoAmbiental.Models
{
    public class Alerta
    {
        public string Mensagem { get; private set; }
        public NivelAlerta Nivel { get; private set; }
        public Coordenada Localizacao { get; private set; }
        public DateTime DataGeracao { get; private set; }

        public Alerta(string mensagem, NivelAlerta nivel, Coordenada localizacao)
        {
            Mensagem = mensagem;
            Nivel = nivel;
            Localizacao = localizacao;
            DataGeracao = DateTime.UtcNow;
        }
    }
}