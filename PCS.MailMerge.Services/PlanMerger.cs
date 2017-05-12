using ceTe.DynamicPDF.Merger;
using System.IO;
using System.Linq;

namespace PCS.MailMerge.Services
{
    public class PlanMerger : IMergeCoverPagesToBody
    {
        public string coverPageIdentifier { get; set; } = "*_SPD COVER PAGE.pdf";
        public string bodyPageIdentifier { get; set; } = "*SPD_*";

        public void Merge(string sourceDirectory)
        {
            var coverPages = Directory.EnumerateFiles(sourceDirectory, coverPageIdentifier);

            foreach (string coverPage in coverPages)
            {
                string fileName = coverPage.Substring(sourceDirectory.Length + 1);
                string filePrefix = fileName.Substring(0, fileName.IndexOf("_") + 1);

                var bodyPage = Directory.EnumerateFiles(sourceDirectory, filePrefix + bodyPageIdentifier).First();

                string path = sourceDirectory + @"\" + fileName;
                PdfDocument pdf = new PdfDocument(path);
                var pageCount = pdf.Pages.Count;

                for (int i = 1; i <= pageCount; i++)
                {
                    MergeDocument document = new MergeDocument(path, i, 1);
                    document.Append(bodyPage);

                    string planID = filePrefix + (i.ToString().PadLeft(5, '0')) + ".pdf";

                    string archivePath = sourceDirectory + @"\" + planID;
                    document.Draw(archivePath);
                }
            }
        }

    }
}
