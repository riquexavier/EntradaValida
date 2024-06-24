Console.Clear();
Console.WriteLine("--- Entrada Válida ---");

int opcao = -1;
while (opcao < 0 || opcao > 9)
{
    Console.Write("Digite um número entre 1 e 9 (ou 0 para cancelar):");
    opcao = Convert.ToInt32(Console.ReadLine());
}

if (opcao == 0)
{
    Console.WriteLine("\nOperação cancelada.\n");
}
else
{
    Console.WriteLine($"\nNúmero selecionado = {opcao}\n");
}
Console.WriteLine("\nVolte sempre!\n");