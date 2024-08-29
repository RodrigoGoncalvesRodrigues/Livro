class Livro
{
   public string  titulo;
   public string autor;
   public int paginas;
   public int ano;

   public void ExibirInformacoes()
   {
    Console.WriteLine($"Titulo: {titulo}, Autor{autor}, Paginas:{paginas}, Ano:{ano}");
   }
    
    public bool VerificarTrezentos()
    {
        // if(paginas > 300)
        // {
        //     return true;
        // }
        // else
        // {
        //     return false;
        // }
        return(paginas > 300);
    }

}