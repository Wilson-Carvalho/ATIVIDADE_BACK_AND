using Atividade_back_and.Classes;

Console.Clear();

Console.WriteLine(@"Selecione uma opcao
    1 - Inserir
    2 - Ler
    0 - Sair
");

PesoaJuridica funcoesPJ = new PesoaJuridica();

switch(Console.ReadLine()) 
{
    case "1": // ele vai impedir que fique rodando sem para. 
        PesoaJuridica pj = new PesoaJuridica();

        Console.WriteLine("Informe o nome da pessoa juridica");
        pj.nome = Console.ReadLine();

        Console.WriteLine("Informe o rendimento da pessoa juridica");
        pj.Rendimento = float.Parse(Console.ReadLine()!);

        Console.WriteLine("Informe o cnpj da pessoa juridica");
        pj.CNPJ = Console.ReadLine();

        funcoesPJ.Inserir(pj);
        break;
    case "2":
        Console.WriteLine("Insira o nome da pessoa juridica");
        string nome = Console.ReadLine()!;

        PesoaJuridica pjBuscado = funcoesPJ.Ler(nome);

        Console.WriteLine(@$"
Informacoes da pessoa juridica:
    Nome: {pjBuscado.nome}
    Rendimento: {pjBuscado.Rendimento}
    CNPJ: {pjBuscado.CNPJ}
        ");

        break;
    case "0":
        break;
}
