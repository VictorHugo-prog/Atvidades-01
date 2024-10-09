using Atv___03;

Produto prod1 = new Produto(2662, "Borracha", 2.01, 500);
Produto prod2 = new Produto(4465, "Relogio", 240.99, 50);
Produto prod3 = new Produto(7796, "Vara de pesca", 315.15, 2000);


Console.WriteLine($"O produto: {prod1.Nome} tem o codigo: {prod1.Codigo}, custando: {prod1.Preco}");
Console.WriteLine($"O produto: {prod2.Nome} tem o codigo: {prod2.Codigo}, custando: {prod2.Preco}");
Console.WriteLine($"O produto: {prod3.Nome} tem o codigo: {prod3.Codigo}, custando: {prod3.Preco}\n");


prod1.valorEstoque();
prod2.valorEstoque();
prod3.valorEstoque();

Console.ReadKey();