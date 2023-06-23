using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System.IO;

namespace Boutique
{
    internal class GestionPDF
    {

        /// <summary>
        /// Générer un PDF avec un titre et a partir d'une table de données
        /// </summary>
        /// <param name="title">Titre du PDF</param>
        /// <param name="data">Table a afficher sur le PDF</param>
        public static void GeneratePdfFromDataTable(string title, DataTable data)
        {
            // Création du document PDF
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("fichier.pdf", FileMode.Create));
            document.Open();

            // Ajout d'une image
            string imageUrl = "../../Resources/devLogo.png";
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imageUrl);
            image.ScaleToFit(140.0F, 120.0F);
            image.SpacingBefore = 10.0F;
            image.SpacingAfter = 10.0F;
            image.Alignment = Element.ALIGN_MIDDLE;
            document.Add(image);
            document.Add(new Paragraph(" "));

            // Ajout d'un titre
            Paragraph titleParagraph = new Paragraph();
            titleParagraph.Alignment = Element.ALIGN_CENTER;
            titleParagraph.Add("SAUZET SHOP");
            document.Add(titleParagraph);
            document.Add(new Paragraph(" "));

            // Ajout du titre de la table
            Paragraph tableTitle = new Paragraph();
            tableTitle.Alignment = Element.ALIGN_CENTER;
            tableTitle.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12f);
            tableTitle.Add(title + " "+ DateTime.Now);
            document.Add(tableTitle);
            document.Add(new Paragraph(" "));


            // Création de la table de données
            PdfPTable dataTable = new PdfPTable(data.Columns.Count);

            // Ajout des titres de colonnes
            foreach (DataColumn column in data.Columns)
            {
                dataTable.AddCell(new PdfPCell(new Phrase(column.ColumnName, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10f)))
                {
                    BackgroundColor = BaseColor.LIGHT_GRAY,
                    Padding = 5f
                });
            }

            // Ajout des données
            foreach (DataRow row in data.Rows)
            {
                foreach (DataColumn column in data.Columns)
                {
                    dataTable.AddCell(new PdfPCell(new Phrase(row[column].ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 9f)))
                    {
                        Padding = 5f
                    });
                }
            }

            document.Add(dataTable);

            // Fermeture du document PDF
            document.Close();

            // Ouverture du fichier PDF
            System.Diagnostics.Process.Start("fichier.pdf");
        }
    }
}
