namespace Alura.ListaLeitura.App
{
    public class Startup
    {
        public void Configure()
        {

        }

        public void LivrosParaLer()
        {
            var _repo = new LivroRepositorioCSV();
            _repo.ParaLer.ToString();
        }
    }
}