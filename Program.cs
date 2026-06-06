using SistemaMonitoramentoAmbiental.Models;
using SistemaMonitoramentoAmbiental.Services;
using SistemaMonitoramentoAmbiental.Interfaces;
using SistemaMonitoramentoAmbiental.Enums;
using SistemaMonitoramentoAmbiental.Structs;

class Program
{
    static void Main(string[] args)
    {
        Satelite satelite = new Satelite("Satélite Ambiental");

        satelite.AdicionarSensor(new SensorImagem());
        satelite.AdicionarSensor(new SensorTemperatura());
        satelite.AdicionarSensor(new SensorFumaca());
        satelite.AdicionarSensor(new SensorGarimpo());

        IAnalisadorAmbiental analisador = new AnalisadorAmbiental();
        DistribuicaoAlerta distribuicao = new DistribuicaoAlerta();

        var dados = satelite.ColetarDados();

        foreach (var dado in dados)
        {
            try
            {
                var alerta = analisador.Analisar(dado);

                if (alerta != null)
                {
                    Console.WriteLine("=======================================");
                    Console.WriteLine("ALERTA AMBIENTAL DETECTADO");

                    Console.WriteLine($"Descricao: {alerta.Mensagem}");
                    Console.WriteLine($"Nivel de Risco: {alerta.Nivel}");
                    Console.WriteLine($"Localizacao: {alerta.Localizacao.Latitude:F4}, {alerta.Localizacao.Longitude:F4}");
                    Console.WriteLine($"Data: {alerta.DataGeracao}");

                    Console.WriteLine($"Regiao: {DescobrirRegiao(alerta.Localizacao)}");

                    if (alerta.Nivel == NivelAlerta.Critico)
                        Console.WriteLine("Prioridade: MAXIMA");
                    else if (alerta.Nivel == NivelAlerta.Alto)
                        Console.WriteLine("Prioridade: URGENTE");
                    else if (alerta.Nivel == NivelAlerta.Medio)
                        Console.WriteLine("Prioridade: MODERADA");
                    else
                        Console.WriteLine("Prioridade: BAIXA");

                    distribuicao.Enviar(alerta);

                    Console.WriteLine("=======================================\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }

    static string DescobrirRegiao(Coordenada coord)
    {
        if (coord.Latitude < -5)
            return "Amazonas";

        if (coord.Latitude >= -5 && coord.Latitude < -2)
            return "Mato Grosso";

        if (coord.Latitude >= -2)
            return "Sao Paulo";

        return "Regiao desconhecida";
    }
}