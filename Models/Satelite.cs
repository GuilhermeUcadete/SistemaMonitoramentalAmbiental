using System.Collections.Generic;

namespace SistemaMonitoramentoAmbiental.Models
{
    public class Satelite : EntidadeBase
    {
        public string Nome { get; private set; }
        private List<Sensor> sensores = new();

        public Satelite(string nome)
        {
            Nome = nome;
        }

        public void AdicionarSensor(Sensor sensor)
        {
            sensores.Add(sensor);
        }

        public List<DadoSensor> ColetarDados()
        {
            List<DadoSensor> dados = new();

            foreach (var sensor in sensores)
            {
                dados.Add(sensor.Coletar());
            }

            return dados;
        }
    }
}