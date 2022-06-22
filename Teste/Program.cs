// See https://aka.ms/new-console-template for more information
using Teste;
Console.WriteLine("OLÁ SEJA BEM-VINDO(A)");
var fare = new Fare();
fare.IdFare = Guid.NewGuid();

Console.WriteLine("Informe o código da operadora para a tarifa:");
Console.WriteLine("Exemplos: OP01, OP02, OP03...");
var operatorCodeInput = Console.ReadLine();


Console.WriteLine("Informe o valor da tarifa a ser cadastrada:");
var fareValueInput = Console.ReadLine();
fare.Valor = decimal.Parse(fareValueInput);

Console.WriteLine(fare.VerificaCadastro(operatorCodeInput.ToUpper(), decimal.Parse(fareValueInput)));
Console.Read();