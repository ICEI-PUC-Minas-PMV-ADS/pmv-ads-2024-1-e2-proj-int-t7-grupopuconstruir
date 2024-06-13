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
            pdf.AddAuthor("PUConstruir");
            pdf.AddTitle(nomeArquivo);
            pdf.AddSubject(nomeArquivo);

            var writer = PdfWriter.GetInstance(pdf, arquivo);
            writer.PageEvent = new EventosDePagina(
                titulo: $"Orçamento {_orcamento.Id} - {_orcamento.Nome}",
                subtitulo: $"Criado em: {_orcamento.DataCriacao}"
                );
            
            pdf.Open();

            //PdfPTable table = GerarTabelaDeProjetos();
            #region Cabeçalho da Tabela
            PdfPTable table = new PdfPTable(5);
            BaseColor preto = new BaseColor(0, 0, 0);
            BaseColor fundo = new BaseColor(200, 200, 200);
            BaseColor branco = new BaseColor(255, 255, 255);
            Font font = FontFactory.GetFont("Verdana", 10, Font.NORMAL, preto);
            Font titulo = FontFactory.GetFont("Verdana", 10, Font.BOLD, preto);

            float[] colsW = { 20, 10, 10, 10, 10 };
            table.SetWidths(colsW);
            table.HeaderRows = 1;


            table.DefaultCell.Border = PdfPCell.BOTTOM_BORDER;
            table.DefaultCell.BorderColor = preto;
            table.DefaultCell.BorderColorBottom = new BaseColor(255, 255, 255);
            table.DefaultCell.Padding = 10;

            table.AddCell(getNewCell("Projeto", titulo, Element.ALIGN_LEFT, 10, PdfPCell.BOTTOM_BORDER, preto, fundo));
            table.AddCell(getNewCell("Dt Criacao", titulo, Element.ALIGN_LEFT, 10, PdfPCell.BOTTOM_BORDER, preto, fundo));
            table.AddCell(getNewCell("Dt Inicial", titulo, Element.ALIGN_LEFT, 10, PdfPCell.BOTTOM_BORDER, preto, fundo));
            table.AddCell(getNewCell("Dt Final", titulo, Element.ALIGN_LEFT, 10, PdfPCell.BOTTOM_BORDER, preto, fundo));
            table.AddCell(getNewCell("Valor", titulo, Element.ALIGN_LEFT, 10, PdfPCell.BOTTOM_BORDER, preto, fundo));
            #endregion

            #region Dados da Tabela
            var projetoAtual = string.Empty;

            foreach (var projeto in _orcamento.Projetos)
            {
                if (projeto.NomeProjeto != projetoAtual)
                {
                    var cell = getNewCell(projeto.Descricao, titulo, Element.ALIGN_LEFT, 5, PdfPCell.BOTTOM_BORDER, preto, branco);
                    cell.Colspan = 5;
                    cell.PaddingTop = 10.0f;
                    table.AddCell(cell);
                    projetoAtual = projeto.NomeProjeto;
                }

                table.AddCell(getNewCell(projeto.NomeProjeto, font, Element.ALIGN_LEFT, 5, PdfPCell.BOTTOM_BORDER, preto, branco));
                table.AddCell(getNewCell(projeto.DataCriacao.ToString(), font, Element.ALIGN_LEFT, 5, PdfPCell.BOTTOM_BORDER, preto, branco));
                table.AddCell(getNewCell(projeto.DataInicial.ToString(), font, Element.ALIGN_LEFT, 5, PdfPCell.BOTTOM_BORDER, preto, branco));
                table.AddCell(getNewCell(projeto.DataFinal.ToString(), font, Element.ALIGN_LEFT, 5, PdfPCell.BOTTOM_BORDER, preto, branco));
                table.AddCell(getNewCell(string.Format("{0:0.00}", projeto.Valor), font, Element.ALIGN_LEFT, 5, PdfPCell.BOTTOM_BORDER, preto, branco));
            }
            // Valor total
            var cellValorTotal = getNewCell($"Valor Total: {string.Format("{0:0.00}", _orcamento.ValorTotal)}", titulo, Element.ALIGN_RIGHT, 5, PdfPCell.BOTTOM_BORDER, preto, fundo);
            cellValorTotal.Colspan = 5;
            cellValorTotal.RightIndent = 20.0f;
            table.AddCell(cellValorTotal);

            // Ajustes tamanho tabela
            float availableWidth = pdf.PageSize.Width - pdf.LeftMargin - pdf.RightMargin;
            table.TotalWidth = availableWidth * 1.0f;
            table.LockedWidth = true;
            float h = table.TotalHeight;
            pdf.SetMargins(30, 30, h - h + 100, 30);

            table.WriteSelectedRows(0, -1, pdf.LeftMargin, pdf.Top, writer.DirectContent);
            #endregion

            pdf.Close();
            arquivo.Close();

            var pdfStream = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read);

            return pdfStream;

        }
        protected PdfPCell getNewCell(string Texto, Font Fonte, int Alinhamento, float Espacamento, int Borda, BaseColor CorBorda, BaseColor CorFundo)
        {
            var cell = new PdfPCell(new Phrase(Texto, Fonte));
            cell.HorizontalAlignment = Alinhamento;
            cell.Padding = Espacamento;
            cell.Border = Borda;
            cell.BorderColor = CorBorda;
            cell.BackgroundColor = CorFundo;

            return cell;
        }
    }   

}
