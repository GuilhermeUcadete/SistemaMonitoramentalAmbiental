using SistemaMonitoramentoAmbiental.Interfaces;
using SistemaMonitoramentoAmbiental.Models;
using SistemaMonitoramentoAmbiental.Enums;
using SistemaMonitoramentoAmbiental.Structs;

namespace SistemaMonitoramentoAmbiental.Services
{
    public class AnalisadorAmbiental : IAnalisadorAmbiental
    {
        public Alerta? Analisar(DadoSensor dado)
        {
            Random rnd = new Random();

            Coordenada coord = new Coordenada(
                rnd.NextDouble() * -10,
                rnd.NextDouble() * -50
            );

            // 🌳 Desmatamento
            if (dado.Conteudo.Contains("desmatamento"))
            {
                return new Alerta("Desmatamento detectado!", NivelAlerta.Alto, coord);
            }

            // 🔥 Temperatura (incêndio)
            if (dado.Conteudo.Contains("Temperatura"))
            {
                return new Alerta("Risco de incendio!", NivelAlerta.Medio, coord);
            }

            // 💨 NOVO ALERTA 1
            if (dado.Conteudo.Contains("fumaça") || dado.Conteudo.Contains("fumaca"))
            {
                return new Alerta("Queimada em andamento!", NivelAlerta.Critico, coord);
            }

            // ⛏️ NOVO ALERTA 2
            if (dado.Conteudo.Contains("garimpo"))
            {
                return new Alerta("Garimpo ilegal detectado!", NivelAlerta.Alto, coord);
            }

            return null;
        }
    }
}