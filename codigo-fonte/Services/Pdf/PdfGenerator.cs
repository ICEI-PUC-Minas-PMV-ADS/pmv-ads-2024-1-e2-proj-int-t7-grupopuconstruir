using iTextSharp.text.pdf;
using iTextSharp.text;
using PUConstruir.Models;
using Microsoft.AspNetCore.Components.Web;


namespace PUConstruir.Services.Pdf
{
    public class PdfGenerator
    {
        private readonly OrcamentoModel _orcamento;

        public PdfGenerator(OrcamentoModel orcamento)
        {
            _orcamento = orcamento;
        }

        public FileStream GerarPdf()
        {
            Document pdf = new Document(PageSize.A4);
            var nomeArquivo = $"Orcamento {DateTime.Now.ToString("yyyy.MM.dd.hh.mm.ss")}.pdf";
            var caminhoReports = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "reports");
            var caminhoArquivo = Path.Combine(caminhoReports, nomeArquivo);
            var arquivo = new FileStream(caminhoArquivo, FileMode.Create);
            var writer = PdfWriter.GetInstance(pdf, arquivo);
            writer.PageEvent = new EventosDePagina(
                titulo:$"Orçamento {_orcamento.Id} - {_orcamento.Nome}",
                subtitulo: $"Criado em: {_orcamento.DataCriacao}"
                );
            pdf.Open();

            //BaseFont fonteBase = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);

            pdf.Close();
            arquivo.Close();

            var pdfStream = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read);

            return pdfStream;

        }

    }   

}
