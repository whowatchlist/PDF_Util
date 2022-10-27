using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace PDF_Util
{
    internal class Merge
    {
        public static void mergePDFs(IEnumerable<Stream> docuemnts, String outPath)
        {
            using PdfDocument output = new PdfDocument();
            foreach (Stream docuemnt in docuemnts)
            {
                using var nextDoc = PdfReader.Open(docuemnt);
                appendDoc(output, nextDoc);
            }

            output.Save(outPath);
        }

        public static void appendDoc(PdfDocument first, PdfDocument second)
        {
            foreach (var page in second.Pages)
            {
                first.AddPage(page);
            }
        }
    }
}
