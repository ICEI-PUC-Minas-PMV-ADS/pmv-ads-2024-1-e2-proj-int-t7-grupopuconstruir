using PUConstruir.Repositorio;
using PUConstruir.Services.Pdf;

namespace PUConstruir.Services
{
    public class OrcamentoService : IOrcamentoService
    {
        private readonly IOrcamentoRepositorio _orcamentoRepositorio;

        public OrcamentoService(IOrcamentoRepositorio orcamentoRepositorio)
        {
            _orcamentoRepositorio = orcamentoRepositorio;
        }

        public byte[] GerarPdf(int orcamentoId)
        {
            var orcamento = _orcamentoRepositorio.BuscarPorId(orcamentoId);
            var pdfGenerator = new PdfGenerator(orcamento);
            return pdfGenerator.GerarPdf();
        }
    }

}
