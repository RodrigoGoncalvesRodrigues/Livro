Livro l1 = new Livro();
l1.titulo = "Oloko Bixo";
l1.autor = "Faustão";
l1.ano= 2007;
l1.paginas = 315;
l1.ExibirInformacoes();
// bool verifica = l1.VerificarTrezentos();
Console.WriteLine($"Esse livro tem mais de 300 paginas ?{l1.verificarTrezentos()}");
