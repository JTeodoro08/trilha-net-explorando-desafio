namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Verificar se a capacidade da suíte é suficiente para a quantidade de hóspedes
            if (Suite != null && hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Lança exceção se a quantidade de hóspedes for maior que a capacidade
                throw new Exception("A capacidade da suíte é menor do que o número de hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Retorna a quantidade de hóspedes cadastrados
            return Hospedes != null ? Hospedes.Count : 0;
        }

        public decimal CalcularValorDiaria()
        {
            // Cálculo base do valor da diária
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Se a reserva for por 10 dias ou mais, aplicar 10% de desconto
            if (DiasReservados >= 10)
            {
                valor *= 0.90M; // Aplica 10% de desconto
            }

            return valor;
        }
    }
}
