namespace SistemaMonitoramentoAmbiental.Models
{
    public abstract class Sensor
    {
        public string Tipo { get; protected set; }

        public abstract DadoSensor Coletar();
    }
}