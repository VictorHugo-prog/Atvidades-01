using Atv___01;

Livro li1 = new Livro("Dom Casmurro", "Machado de Assis", "Abril", 1899);
Livro li2 = new Livro("O Alquimista", "Paulo Coelho", "Rocco", 1988);
Livro li3 = new Livro("A Menina que Roubava Livros", "Markus Zusak", "Intrínseca", 2005);

Console.WriteLine($"O Titulo do livro é: {li1.Titulo} \nO autor é: {li1.Autor} " +
    $"\nA editora é: {li1.Editora} \nO ano de lancamento é: {li1.Ano}");

Console.WriteLine($"\nO Titulo do livro é: {li2.Titulo} \nO autor é: {li2.Autor} " +
    $"\nA editora é: {li2.Editora} \nO ano de lancamento é: {li2.Ano}");

Console.WriteLine($"\nO Titulo do livro é: {li3.Titulo} \nO autor é: {li3.Autor} " +
    $"\nA editora é: {li3.Editora} \nO ano de lancamento é: {li3.Ano}");


Console.ReadKey();