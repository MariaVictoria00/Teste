namespace Teste
{
    public class Fare
    {
        public Guid IdFare { get; set; }
        public decimal Valor { get; set; }

        public Fare(){

        }


        public static List<Operator> GetOperators()
        {
            var operators = new List<Operator>();

            var operator1 = new Operator(1, "OP01", 1, new DateTime(DateTime.Today.Year, 1, 1));
            operators.Add(operator1);


            var operator2 = new Operator(1, "OP02", 2, new DateTime(DateTime.Today.Year, 2, 25));
            operators.Add(operator1);

            var operator3 = new Operator(1, "OP03", 3, new DateTime(DateTime.Today.Year, 3, 22));
            operators.Add(operator3);

            return operators;

        }

        public string VerificaCadastro(string nome, decimal a)
        {
            var listaOperator = GetOperators();

            foreach (var item in listaOperator)
            {
                var verificaPeriodo = Verificadata(item.DataCadastroFare);

                if (!item.Nome.Equals(nome)) return "Nome do código da operadora não encotrado :(";

                if (a == item.Fare && (verificaPeriodo.Month >= 6)) return "Erro, já existe tarefica cadastrada com o mesmo valor nos ultimos 6 meses!";
                return "Tarifa cadastrada com sucesso!";
            }

            return null;
        }

        static DateTime Verificadata(DateTime d)
        {
            var diaAtual = DateTime.Now;
            TimeSpan calculaPeriodo = diaAtual.Subtract(d);
            DateTime periodo = new DateTime(calculaPeriodo.Ticks);
            return periodo;
        }
    }
}
