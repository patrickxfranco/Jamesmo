using System;
using Jamesmo.VeiculoNS;

namespace Jamesmo.Main
{
    public static class Principal
    {
        public static void Main()
        {
            char opcao;
            do
            {
                ImprimirCabecalho(" MENU PRINCIPAL ");
                Console.WriteLine("Selecione uma das opções abaixo para prosseguir:\n");
                Console.Write("[1]Cadastrar um novo veículo\n" +
                              "[2]Deletar um veículo cadastrado\n" +
                              "[3]Visualizar todos os veículos cadastrados\n" +
                              "[4]Sair da aplicação\nOpção: ");
                opcao = Console.ReadKey().KeyChar;
                switch (char.GetNumericValue(opcao))
                {
                    case 1:
                        CadastrarVeiculo();
                        break;
                    case 2:
                        DeletarVeiculo();
                        break;
                    case 3:
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write("\n\nDigite uma opção válida entre 1 e 4.\nPressione ENTER para prosseguir");
                        Console.ReadLine();
                        break;
                }
            } while (char.GetNumericValue(opcao) < 1 || char.GetNumericValue(opcao) > 4);
        }

        private static void ImprimirCabecalho(string pTitulo)
        {
            Console.Clear();
            string[] vTitulo = { "JAMESMO  VEÍCULOS", pTitulo };
            for (int i = 0; i < 2; i++)
            {
                for (int c = 0; c < 10; c++)
                {
                    Console.Write("#");
                }
                Console.Write("     " + vTitulo[i] + "     ");
                for (int c = 0; c < 10; c++)
                {
                    Console.Write("#");
                }
                Console.Write("\n");
            }
            Console.Write("\n\n");
        }

        private static void CadastrarVeiculo()
        {
            char opcao;
            string? vMarca = null, vModelo = null, vAno = null;
            do
            {
                do
                {
                    ImprimirCabecalho("CADASTRAR VEÍCULO");
                    Console.WriteLine("Selecione uma das opções abaixo referente a MARCA do veículo");
                    Console.Write("[1]Chevrolet;\n" +
                                  "[2]Fiat;\n" +
                                  "[3]Ford;\n" +
                                  "[4]Honda;\n" +
                                  "[5]Mercedes;\n" +
                                  "[6]Nissan;\n" +
                                  "[7]Volkswagen;\n" +
                                  "Opção: ");
                    opcao = Console.ReadKey().KeyChar;
                    switch (char.GetNumericValue(opcao))
                    {
                        case 1:
                            vMarca = ("CHEVROLET");
                            break;
                        case 2:
                            vMarca = ("FIAT");
                            break;
                        case 3:
                            vMarca = ("FORD");
                            break;
                        case 4:
                            vMarca = ("HONDA");
                            break;
                        case 5:
                            vMarca = ("MERCEDES");
                            break;
                        case 6:
                            vMarca = ("NISSAN");
                            break;
                        case 7:
                            vMarca = ("VOLKSWAGEN");
                            break;
                        default:
                            Console.Write("\n\nDigite uma opção válida entre 1 e 7.\nPressione ENTER para prosseguir");
                            Console.ReadLine();
                            break;
                    }
                } while (char.GetNumericValue(opcao) < 1 || char.GetNumericValue(opcao) > 7);
                do
                {
                    Console.Clear();
                    ImprimirCabecalho("CADASTRAR VEÍCULO");
                    Console.Write("Digite aqui o MODELO do veículo na qual deseja cadastrar: ");
                    vModelo = Console.ReadLine();
                    vModelo = vModelo.ToUpper();
                    if (vModelo == null || vModelo == "")
                    {
                        Console.Write("\n\nDigite um nome válido.\nPressione ENTER para prosseguir");
                        Console.ReadLine();
                    }
                } while (vModelo == null || vModelo == "");
                do
                {
                    Console.Clear();
                    ImprimirCabecalho("CADASTRAR VEÍCULO");
                    Console.Write("Digite aqui o ANO do veículo na qual deseja cadastrar: ");
                    vAno = Console.ReadLine();
                    if (vAno.Length < 4 || vAno.Length > 4)
                    {
                        Console.Write("\n\nDigite um número válido com 4 dígitos.\nPressione ENTER para prosseguir");
                        Console.ReadLine();
                    }
                } while (vAno.Length < 4 || vAno.Length > 4);
                Console.Clear();
                ImprimirCabecalho("CADASTRAR VEÍCULO");
                Console.WriteLine("Verifique se esses dados estão corretos\n");
                Console.WriteLine($"Marca do veículo: {vMarca}\n" +
                                  $"Modelo do veículo: {vModelo}\n" +
                                  $"Ano do veículo: {vAno}\n");
                Console.Write("Essas informações estão todas corretas? [1]Sim [2]Não\nOpção: ");
                opcao = Console.ReadKey().KeyChar;
            } while (char.GetNumericValue(opcao) != 1);
            Veiculo veiculo = new Veiculo(vMarca, vModelo, vAno);
            veiculo.Cadastrar();
            Console.Write("\n\nVeículo cadastrado com sucesso.\nPressione ENTER para continuar");
            Console.ReadLine();
            Main();
        }

        public static void DeletarVeiculo()
        {
            string vModelo;
            do
            {
                Console.Clear();
                ImprimirCabecalho("DELETAR VEÍCULO");
                Console.Write("Digite aqui o MODELO do veículo na qual deseja deletar: ");
                vModelo = Console.ReadLine();
                vModelo = vModelo.ToUpper();
                if (vModelo == null || vModelo == "")
                {
                    Console.Write("\n\nDigite um nome válido.\nPressione ENTER para prosseguir");
                    Console.ReadLine();
                }
            } while (vModelo == null || vModelo == "");
            Veiculo veiculo = new Veiculo(vModelo);
            veiculo.Excluir();
            Console.Write("\n\nVeículo deletado com sucesso. Pressione ENTER para continuar");
            Console.ReadLine();
            Main();
        }
    }
}