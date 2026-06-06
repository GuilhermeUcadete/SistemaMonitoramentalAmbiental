using SistemaMonitoramentoAmbiental.Models;

namespace SistemaMonitoramentoAmbiental.Services
{
    public class DistribuicaoAlerta
    {
        public void Enviar(Alerta alerta)
        {
            try
            {
                if (alerta == null)
                    throw new ArgumentNullException();

                if (alerta.Nivel == Enums.NivelAlerta.Alto || alerta.Nivel == Enums.NivelAlerta.Critico)
                {
                    Console.WriteLine("Enviando para AUTORIDADES...");
                }
                else
                {
                    Console.WriteLine("Enviando para PORTAIS DE NOTÍCIA...");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao enviar alerta: {ex.Message}");
            }
        }
    }
}