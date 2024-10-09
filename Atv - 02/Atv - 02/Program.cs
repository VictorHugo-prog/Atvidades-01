using Atv___02;

Aluno alu1 = new Aluno("Caua Leite Ferreira", 1796, "caua.ferreira@portalsesisp.org.br", new DateTime(2006, 9, 7));
Aluno alu2 = new Aluno("Thiago José de Oliveira Alves", 2468, "thiago.alves07@portalsesisp.org.br", new DateTime(2007, 9, 10));
Aluno alu3 = new Aluno("Thomas Correa", 1943, "thomas.correa@portalsesisp.org.br", new DateTime(2007, 9, 18));

Console.WriteLine($"O nome do aluno é: {alu1.Nome} \nO RM do aluno é: {alu1.Rm} " +
    $"\nO E-mail do aluno é: {alu1.Email} \nO ano de nascimento é: {alu1.Ano}");

Console.WriteLine($"\nO nome do aluno é: {alu2.Nome} \nO RM do aluno é: {alu2.Rm} " +
    $"\nO E-mail do aluno é: {alu2.Email} \nO ano de nascimento é: {alu2.Ano}");

Console.WriteLine($"\nO nome do aluno é: {alu3.Nome} \nO RM do aluno é: {alu3.Rm} " +
    $"\nO E-mail do aluno é: {alu3.Email} \nO ano de nascimento é: {alu3.Ano}");

Console.ReadKey();
