namespace PUConstruir.Services
{
    public interface IOrcamentoService
    {
        FileStream GerarPdf(int orcamentoId);
    }
}