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

            if (Suite.Capacidade >= hospedes.Count())
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception($"A quantidade de hóspedes ({hospedes.Count()}) é maior que a capacidade ({Suite.Capacidade}) da acomodação escolhida.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor =  0;
            decimal desconto = 0.9M;

            valor = Suite.ValorDiaria * DiasReservados;

            if (DiasReservados >= 10)
            {
                valor = valor * desconto;
            }

            return valor;
        }
    }
}