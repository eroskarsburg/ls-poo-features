﻿using ls_poo_features.Entity.Employee;
using ls_poo_features.Repositories;
using System.ComponentModel.DataAnnotations;

namespace ls_poo_features
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Menus menu = new Menus();
            AutomovelRepository _repository = new AutomovelRepository();
            //BookRepository bookRepository = new BookRepository();
            //EditorRepository editorRepository = new EditorRepository();



            //while (opt != 5)
            //{
            //    menu.MenuPrincipal();
            //    Console.WriteLine("Escolha a opção:");
            //    opt = int.Parse(Console.ReadLine()!);
            //    if (opt == 1)
            //        editorRepository.CadastrarEditora();
            //    if (opt == 2)
            //        bookRepository.CadastrarLivro();
            //    if (opt == 3)
            //    {
            //        Console.WriteLine("Insira o nome da editora que desejas buscar:");
            //        string nome = Console.ReadLine()!;
            //        editorRepository.RetornaEditora(nome);
            //    }
            //    if (opt == 4)
            //    {
            //        Console.WriteLine("Insira o nome do livro que desejas buscar:");
            //        string nome = Console.ReadLine()!;
            //        bookRepository.RetornaLivro(nome);
            //    }
            //    if (opt == 5)
            //        return;
            //}
            //int opt = 0;
            //while (opt != 4)
            //{
            //    menu.MenuAutomovel();
            //    opt = int.Parse(Console.ReadLine()!);
            //    if (opt == 1)
            //    {
            //        _repository.CadastrarMontadora();
            //        _repository.CadastrarModelo();
            //        _repository.CadastrarCarro();
            //    }
            //    if (opt == 2)
            //        _repository.MostrarAtributosAutomovel();
            //    if (opt == 3)
            //    {
            //        menu.MenuAtualizarAutomovel();
            //        int opt2 = int.Parse(Console.ReadLine()!);
            //        if (opt2 == 1)
            //        {
            //            Console.WriteLine("Insira o código da montadora que deseja alterar: ");
            //            int codMont = int.Parse(Console.ReadLine()!);

            //            if (!_repository.BuscarMontadora(codMont))
            //            {
            //                Console.WriteLine("\nNão foi encontrado nenhuma Montadora.\n");
            //                return;
            //            }
            //            menu.MenuAtualizarMontadora();
            //            int opt3 = int.Parse(Console.ReadLine()!);
            //            if (opt3 == 1)
            //            {
            //                Console.WriteLine("Insira o novo valor: ");
            //                int novoCodigo = int.Parse(Console.ReadLine()!);
            //                _repository.AtualizarMontadoraCodigo(codMont, novoCodigo);
            //            }
            //            if (opt3 == 2)
            //            {
            //                Console.WriteLine("Insira o novo valor: ");
            //                string novoEstado = Console.ReadLine()!;
            //                _repository.AtualizarMontadoraEstado(codMont, novoEstado);

            //            }
            //            if (opt3 == 3)
            //            {
            //                Console.WriteLine("Insira o novo valor: ");
            //                string novaRazao = Console.ReadLine()!;
            //                _repository.AtualizarMontadoraRazaoSocial(codMont, novaRazao);
            //            }
            //        }
            //        if (opt2 == 2)
            //        {
            //            Console.WriteLine("Insira o código do modelo que deseja alterar: ");
            //            int codModelo = int.Parse(Console.ReadLine()!);

            //            if (!_repository.BuscarModelo(codModelo))
            //            {
            //                Console.WriteLine("\nNão foi encontrado nenhum Modelo.\n");
            //                return;
            //            }

            //            menu.MenuAtualizarModelo();
            //            int opt3 = int.Parse(Console.ReadLine()!);
            //            if (opt3 == 1)
            //            {
            //                Console.WriteLine("Insira o novo valor: ");
            //                int novoCodigo = int.Parse(Console.ReadLine()!);
            //                _repository.AtualizarModeloCodigo(codModelo, novoCodigo);
            //            }
            //            if (opt3 == 2)
            //            {
            //                Console.WriteLine("Insira o novo valor: ");
            //                string novoNome = Console.ReadLine()!;
            //                _repository.AtualizarModeloNome(codModelo, novoNome);
            //            }
            //        }
            //        if (opt2 == 3)
            //        {
            //            Console.WriteLine("Insira a placa do carro que deseja alterar: ");
            //            string placa = Console.ReadLine()!;

            //            if (!_repository.BuscarCarro(placa))
            //            {
            //                Console.WriteLine("\nNão foi encontrado nenhum Carro.\n");
            //                return;
            //            }

            //            menu.MenuAtualizarCarro();
            //            int opt3 = int.Parse(Console.ReadLine()!);
            //            if (opt3 == 1)
            //            {
            //                Console.WriteLine("Insira o novo valor: ");
            //                string novaPlaca = Console.ReadLine()!;
            //                _repository.AtualizarCarroPlaca(placa, novaPlaca);
            //            }
            //            if (opt3 == 2)
            //            {
            //                Console.WriteLine("Insira o novo valor: ");
            //                int novoAnoFabricacao = int.Parse(Console.ReadLine()!);
            //                _repository.AtualizarCarroAnoFabricacao(placa, novoAnoFabricacao);
            //            }
            //        }
            //    }
            //}
            Employee emp = new Employee();
            Seller seller = new Seller();
            Manager man = new Manager();

            int opt = 0;
            while (opt != 9)
            {
                Console.WriteLine("##### MENU #####\n- Escolha uma opção abaixo\n");
                Console.WriteLine("1 > Cadastrar funcionário");
                Console.WriteLine("2 > Cadastrar vendedor");
                Console.WriteLine("3 > Cadastrar gerente");
                Console.WriteLine("4 > Bonificar funcionário");
                Console.WriteLine("5 > Bonificar gerente");
                Console.WriteLine("6 > Autenticar Senha do Gerente");
                Console.WriteLine("7 > Atualizar quantidade vendas");
                Console.WriteLine("8 > Calcular salário vendedor");
                Console.WriteLine("9 > Sair");

                opt = int.Parse(Console.ReadLine()!);

                if (opt == 1)
                {
                    Console.WriteLine("Cadastrando funcionario:\n");
                    Console.WriteLine("Nome:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("CPF:");
                    string CPF = Console.ReadLine();
                    Console.WriteLine("Salario:");
                    double salario = double.Parse(Console.ReadLine()!);
                    Console.WriteLine("Departamento:");
                    string departamento = Console.ReadLine();

                    emp = new Employee(nome, CPF, salario, departamento);

                    Console.WriteLine("Funcionario cadastrado!");
                }
                if (opt == 2)
                {
                    Console.WriteLine("Cadastrando vendedor:\n");
                    Console.WriteLine("Nome:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("CPF:");
                    string CPF = Console.ReadLine();
                    Console.WriteLine("Salario:");
                    double salario = double.Parse(Console.ReadLine()!);
                    Console.WriteLine("Departamento:");
                    string departamento = Console.ReadLine();
                    Console.WriteLine("Quantidade de vendas:");
                    int quantidadeVendas = int.Parse(Console.ReadLine()!);
                    Console.WriteLine("Comissão:");
                    int comissao = int.Parse(Console.ReadLine()!);

                    seller = new Seller(nome, CPF, salario, departamento, quantidadeVendas, comissao);

                    Console.WriteLine("Vendedor cadastrado!");

                }
                if (opt == 3)
                {
                    Console.WriteLine("Cadastrando gerente:\n");
                    Console.WriteLine("Nome:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("CPF:");
                    string CPF = Console.ReadLine();
                    Console.WriteLine("Salario:");
                    double salario = double.Parse(Console.ReadLine()!);
                    Console.WriteLine("Departamento:");
                    string departamento = Console.ReadLine();
                    Console.WriteLine("Senha:");
                    string senha = Console.ReadLine()!;
                    Console.WriteLine("Numero de funcionarios gerenciados:");
                    int numeroFuncionariosGerenciados = int.Parse(Console.ReadLine()!);

                    man = new Manager(nome, CPF, salario, departamento, senha, numeroFuncionariosGerenciados);

                    Console.WriteLine("Gerente cadastrado!");

                }
                if (opt == 4)
                {
                    Console.WriteLine($"-----\nSalário: {emp.Salario}\n");
                    emp.Bonificar();
                    Console.WriteLine($"Salário atualizado: {emp.Salario}\n-----");
                }
                if (opt == 5)
                {
                    Console.WriteLine($"-----\nSalário: {man.Salario}\n");
                    man.Bonificar();
                    Console.WriteLine($"Salário atualizado: {man.Salario}\n-----");
                }
                if (opt == 6)
                {
                    Console.WriteLine("-----\nDigite a senha: ");
                    string senha = Console.ReadLine()!;
                    if (man.AutenticarSenha(senha))
                    {
                        Console.WriteLine("-----\nSenha digitada está correta!");
                        Console.WriteLine($"Senha: {man.Senha}");
                    }
                    else
                        Console.WriteLine("-----\nSenha incorreta! Retornando...\n-----");
                }
                if (opt == 7)
                {
                    Console.WriteLine("-----\nInsira a quantidade de vendas a atualizar: ");
                    int qntdVendas = int.Parse(Console.ReadLine()!);
                    Console.WriteLine($"Quantidade de vendas: {seller.QuantidadeVendas}");
                    seller.AtualizaQuantidadeVendas(qntdVendas);
                    Console.WriteLine($"Quantidade de vendas atualizada: {seller.QuantidadeVendas}\n-----");
                }
                if (opt == 8)
                {
                    Console.WriteLine($"-----\nAtual salário do vendedor: {seller.Salario}");
                    seller.CalcularSalario();
                    Console.WriteLine($"Quantidade de vendas atual: {seller.QuantidadeVendas}");
                    Console.WriteLine($"Salário do vendedor somando as comissões por venda (R${seller.Comissao},00): {seller.Salario}");
                }
                if (opt == 9)
                {
                    Console.WriteLine("Saindo...");
                }
            }
        }
    }
}