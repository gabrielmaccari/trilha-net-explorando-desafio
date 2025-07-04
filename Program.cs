using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();


bool menu = true;
while (menu)
{
    Console.WriteLine("BEM VINDO AO HOTEL!");
    Console.WriteLine("1 - Começar atendimento");
    Console.WriteLine("2 - Sair");

    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("Digite o primeiro nome do hóspede:");
            string primeiroNomeHospede = Console.ReadLine();
            Console.WriteLine("Digite o segundo nome do hóspede:");
            string segundoNomeHospede = Console.ReadLine();
            Pessoa novoHospede = new Pessoa(nome: primeiroNomeHospede, sobrenome: segundoNomeHospede);
            hospedes.Add(novoHospede);
            Console.WriteLine("Hóspede cadastrado com sucesso!");
            Console.WriteLine("Deseja cadastrar mais algum hóspede? (s/n)");
            string resposta = Console.ReadLine().ToLower();
            while (resposta == "s")
            {
                Console.WriteLine("Digite o primeiro nome do hóspede:");
                primeiroNomeHospede = Console.ReadLine();
                Console.WriteLine("Digite o segundo nome do hóspede:");
                segundoNomeHospede = Console.ReadLine();
                novoHospede = new Pessoa(nome: primeiroNomeHospede, sobrenome: segundoNomeHospede);
                hospedes.Add(novoHospede);
                Console.WriteLine("Hóspede cadastrado com sucesso!");
                Console.WriteLine("Deseja cadastrar mais algum hóspede? (s/n)");
                resposta = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Digite o tipo da suíte:");
            string tipoSuite = Console.ReadLine();
            Console.WriteLine("Digite a capacidade da suíte:");
            int capacidadeSuite = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor da diária:");
            decimal valorDiariaSuite = Convert.ToDecimal(Console.ReadLine());
            Suite novaSuite = new Suite(tipoSuite: tipoSuite, capacidade: capacidadeSuite, valorDiaria: valorDiariaSuite);
            Console.WriteLine("Digite o número de dias reservados:");
            int diasReservados = Convert.ToInt32(Console.ReadLine());
            Reserva novaReserva = new Reserva(diasReservados: diasReservados);
            novaReserva.CadastrarSuite(novaSuite);
            novaReserva.CadastrarHospedes(hospedes);
            Console.WriteLine($"Valor diária: {novaReserva.CalcularValorDiaria()}");
            break;
        case "2":
            menu = false;
            Console.WriteLine("Obrigado por utilizar nosso sistema de reservas!");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

}