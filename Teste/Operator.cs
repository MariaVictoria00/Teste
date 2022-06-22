namespace Teste
{
    public class Operator
    {
        public int IdOperator { get; set; }
        public string Nome { get; set; }
        public decimal Fare { get; set; }
        public DateTime DataCadastroFare { get; set; }


        public Operator(int idOperator, string nome, decimal fare, DateTime DataCadastrofare)
        {
            IdOperator=idOperator;
            Nome=nome;
            Fare=fare;
            DataCadastroFare=DataCadastrofare;
        }
    }
}
