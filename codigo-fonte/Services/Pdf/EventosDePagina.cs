using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUConstruir.Services.Pdf

{
    class EventosDePagina: PdfPageEventHelper
    {
        string tituloCabecalho;
        string Subtitulo;

        public EventosDePagina(string titulo, string subtitulo)
        {
            tituloCabecalho = titulo;
            Subtitulo = subtitulo;
        }

        public override void OnOpenDocument(PdfWriter writer, Document document)
        {
            base.OnOpenDocument(writer, document);
            ImprimeCabecalho(writer, document);

        }

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            base.OnEndPage(writer, document);
            ImprimeRodape(writer, document);
        }


        private void ImprimeCabecalho(PdfWriter writer, Document doc)
        {
            #region Dados do Cabeçalho
            BaseColor preto = new BaseColor(0, 0, 0);
            Font font = FontFactory.GetFont("Verdana", 10, Font.NORMAL, preto);
            Font fontTitulo = FontFactory.GetFont("Verdana", 14, Font.BOLD, preto);
            float[] sizes = new float[] { 1f, 3f, 1f };

            PdfPTable table = new PdfPTable(3);
            table.TotalWidth = doc.PageSize.Width - (doc.LeftMargin + doc.RightMargin);
            table.SetWidths(sizes);

            #region Imagem Logo
            var caminhoWWWRoot = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
            var caminhoLogo = Path.Combine(caminhoWWWRoot, "logopuconstruir.png");

            Image imgLogo = Image.GetInstance(caminhoLogo);
            imgLogo.ScalePercent(25);

            PdfPCell cell = new PdfPCell(imgLogo);
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.Border = 0;
            cell.BorderWidthTop = 1.5f;
            cell.BorderWidthBottom = 1.5f;
            cell.PaddingTop = 10f;
            cell.PaddingBottom = 10f;
            table.AddCell(cell);
            #endregion

            #region Titulo e Subtitulo
            PdfPTable micros = new PdfPTable(1);
            
            cell = new PdfPCell(new Phrase(tituloCabecalho, fontTitulo));
            cell.Border = 0;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.NoWrap = false;
            micros.AddCell(cell);

            cell = new PdfPCell(new Phrase(Subtitulo, font));
            cell.Border = 0;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            micros.AddCell(cell);

            cell = new PdfPCell(micros);
            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            cell.Border = 0;
            cell.BorderWidthTop = 1.5f;
            cell.BorderWidthBottom = 1.5f;
            cell.PaddingTop = 10f;
            table.AddCell(cell);
            #endregion

            #region Página
            micros = new PdfPTable(1);
            cell = new PdfPCell(new Phrase("Página: " + (doc.PageNumber).ToString(), font));
            cell.Border = 0;
            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
            micros.AddCell(cell);

            cell = new PdfPCell(micros);
            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            cell.Border = 0;
            cell.BorderWidthTop = 1.5f;
            cell.BorderWidthBottom = 1.5f;
            cell.PaddingTop = 10f;
            table.AddCell(cell);
            #endregion

            //table.SpacingAfter = 20f;

            table.WriteSelectedRows(0, -1, doc.LeftMargin, (doc.PageSize.Height - 10), writer.DirectContent);
            #endregion
        }

        private void ImprimeRodape(PdfWriter writer, Document doc)
        {
            #region Dados do Rodapé
            BaseColor preto = new BaseColor(0, 0, 0);
            BaseColor azul = new BaseColor(20, 20, 184);
            Font font = FontFactory.GetFont("Verdana", 10, Font.NORMAL, preto);
            Font negrito = FontFactory.GetFont("Verdana", 10, Font.BOLD, preto);
            Font fontAzul = FontFactory.GetFont("Verdana", 10, Font.NORMAL, azul);

            float[] sizes = new float[] { 1.0f, 3.5f, 1f };

            PdfPTable table = new PdfPTable(3);
            table.TotalWidth = doc.PageSize.Width - (doc.LeftMargin + doc.RightMargin);
            table.SetWidths(sizes);

            #region Imagem Logo
            var caminhoWWWRoot = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
            var caminhoLogo = Path.Combine(caminhoWWWRoot, "logopuconstruir.png");
            
            Image imgLogo = Image.GetInstance(caminhoLogo);
            imgLogo.ScalePercent(25);

            PdfPCell cell = new PdfPCell(imgLogo);
            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            cell.Border = 0;
            cell.BorderWidthTop = 1.5f;
            cell.PaddingLeft = 10f;
            cell.PaddingTop = 10f;
            cell.PaddingBottom = 10f;
            table.AddCell(cell);
            #endregion

            #region Dizeres e Link
            PdfPTable micros = new PdfPTable(1);
            cell = new PdfPCell(new Phrase("Orçamento Gerado via PUConstruir", negrito));
            cell.Border = 0;
            micros.AddCell(cell);
            cell = new PdfPCell(new Phrase("Acesse o website em:", font));
            cell.Border = 0;
            micros.AddCell(cell);

            cell = new PdfPCell(new Phrase("https://puconstruir.azurewebsites.net/", fontAzul));
            cell.Border = 0;
            micros.AddCell(cell);

            cell = new PdfPCell(micros);
            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            cell.Border = 0;
            cell.BorderWidthTop = 1.5f;
            cell.PaddingTop = 10f;
            cell.PaddingBottom = 10f;
            table.AddCell(cell);
            #endregion

            #region Data e Hora Geracao
            micros = new PdfPTable(1);
            cell = new PdfPCell(new Phrase("Gerado em:", font));
            cell.Border = 0;
            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
            micros.AddCell(cell);
            cell = new PdfPCell(new Phrase(DateTime.Today.ToString("dd/MM/yyyy"), font));
            cell.Border = 0;
            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
            micros.AddCell(cell);
            cell = new PdfPCell(new Phrase(DateTime.Now.ToString("HH:mm:ss"), font));
            cell.Border = 0;
            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
            micros.AddCell(cell);

            cell = new PdfPCell(micros);
            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            cell.Border = 0;
            cell.BorderWidthTop = 1.5f;
            cell.PaddingTop = 10f;
            table.AddCell(cell);
            #endregion

            table.WriteSelectedRows(0, -1, doc.LeftMargin, 70, writer.DirectContent);
        #endregion 
        }

    }
}
