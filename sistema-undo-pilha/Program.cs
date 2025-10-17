using sistema_undo_pilha;

EditorTexto editorTexto = new EditorTexto();

void Menu()
{
    Console.WriteLine("1 - Digitar novo texto");
    Console.WriteLine("2 - Desfazer última ação");
    Console.WriteLine("3 - Mostrar histórico");
    Console.WriteLine("4 - Sair");
    Console.WriteLine("");
    Console.Write("Escolha uma opção: ");
    int opcao = int.Parse(Console.ReadLine());

    while (opcao != 4)
    {
        switch (opcao)
        {
            case 1:
                Console.Write("Digite o texto: ");
                string texto = Console.ReadLine();
                EditorTexto mensagem = new EditorTexto();
                mensagem.texto = texto;
                editorTexto.Digitar(mensagem);
                break;
            case 2:
                EditorTexto textoDesfeito = editorTexto.Desfazer();
                if (textoDesfeito != null)
                {
                    Console.WriteLine($"Texto desfeito: {textoDesfeito.texto}");
                }
                break;
            case 3:
                editorTexto.MostrarHistorico();
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
        Console.WriteLine("");
        Console.WriteLine("1 - Digitar novo texto");
        Console.WriteLine("2 - Desfazer última ação");
        Console.WriteLine("3 - Mostrar histórico");
        Console.WriteLine("4 - Sair");
        Console.WriteLine("");
        Console.Write("Escolha uma opção: ");
        opcao = int.Parse(Console.ReadLine());
    }
}

Menu();