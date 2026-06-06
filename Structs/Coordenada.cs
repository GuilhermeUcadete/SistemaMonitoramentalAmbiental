namespace SistemaMonitoramentoAmbiental.Structs
{
    public struct Coordenada
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Coordenada(double lat, double lon)
        {
            Latitude = lat;
            Longitude = lon;
        }
    }
}