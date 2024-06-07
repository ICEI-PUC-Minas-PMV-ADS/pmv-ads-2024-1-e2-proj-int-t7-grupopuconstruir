using iTextSharp.text.pdf;
using iTextSharp.text;
using PUConstruir.Models;

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
            pdf.Open();

            BaseFont fonteBase = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);

            //adiciona um título
            var fonteParagrafo = new iTextSharp.text.Font(fonteBase, 32, iTextSharp.text.Font.NORMAL, BaseColor.Black);
            var titulo = new Paragraph($"Orçamento {_orcamento.Id} - {_orcamento.Nome}\n\n", fonteParagrafo);
            titulo.Alignment = Element.ALIGN_LEFT;
            titulo.SpacingAfter = 4;
            pdf.Add(titulo);

            // Converte o conteúdo do arquivo em um array de bytes
            //var pdfBytes = LerFileStreamParaArrayComMemoryStream(arquivo);

            pdf.Close();
            arquivo.Close();

            var pdfStream = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read);

            return pdfStream;

        }

        public byte[] LerFileStreamParaArrayComMemoryStream(FileStream fileStream)
        {
            // Cria um MemoryStream vazio
            using var memoryStream = new MemoryStream();

            // Copia o conteúdo do FileStream para o MemoryStream
            fileStream.CopyTo(memoryStream);

            // Retorna o array de bytes do MemoryStream
            return memoryStream.ToArray();
        }

    }

}
