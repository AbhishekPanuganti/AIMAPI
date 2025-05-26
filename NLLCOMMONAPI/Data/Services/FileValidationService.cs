namespace NLLCOMMONAPI.Data.Services
{
    using nClam;
    using System.IO;
    using SixLabors.ImageSharp;
    using PdfSharpCore.Pdf;
    using PdfSharpCore.Pdf.IO;
    using SixLabors.ImageSharp.ColorSpaces;
    using static System.Net.Mime.MediaTypeNames;

    public class FileValidationService
    {
        private readonly long _maxFileSize = 5 * 1024 * 1024; // 5 MB

        private readonly List<string> _allowedExtensions = new List<string>
        {
             ".jpg", ".png", ".pdf", ".docx", ".xlsx", ".csv", ".xls" // Add valid extensions
        };

        private readonly List<string> _allowedMimeTypes = new List<string>
        {
            "image/jpeg", "image/png", "application/pdf","text/csv","application/msword","application/vnd.ms-excel",
            "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
        };

        public bool ValidateFile(IFormFile file, out string errorMessage)
        {
            errorMessage = null;

            // Check file size
            if (file.Length > _maxFileSize)
            {
                errorMessage = "File size exceeds the maximum allowed size.";
                return false;
            }

            // Check file extension
            var extension = Path.GetExtension(file.FileName).ToLower();
            if (!_allowedExtensions.Contains(extension))
            {
                errorMessage = "File extension is not allowed.";
                return false;
            }

            // Check MIME type
            if (!_allowedMimeTypes.Contains(file.ContentType))
            {
                errorMessage = "File MIME type is not allowed.";
                return false;
            }

            return true;
        }

        public async Task<bool> ScanFileForViruses(string filePath)
        {
            var clam = new ClamClient("localhost", 3310); // Default ClamAV host and port
            var scanResult = await clam.SendAndScanFileAsync(filePath);

            return scanResult.Result == ClamScanResults.Clean;
        }

        public bool IsValidImage(string filePath)
        {
            try
            {
                using var image = SixLabors.ImageSharp.Image.Load(filePath); // Try loading the image
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool IsValidPdf(string filePath)
        {
            try
            {
                // Check if the file exists
                if (!File.Exists(filePath))
                    throw new FileNotFoundException("File not found _IsValidPdf.");

                // Try to open the PDF
                using (var pdfDocument = PdfReader.Open(filePath, PdfDocumentOpenMode.ReadOnly))
                {
                    // If the file is successfully opened, consider it valid
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool IsValidMemoryPdf(IFormFile file)
        {
            try
            {
                if (file == null || file.Length == 0)
                    throw new InvalidDataException("File is empty _IsValidMemoryPdf.");

                // Read the PDF from the uploaded stream
                using (var stream = file.OpenReadStream())
                {
                    using (var pdfDocument = PdfReader.Open(stream, PdfDocumentOpenMode.ReadOnly))
                    {
                        // If the file is successfully opened, consider it valid
                        return true;
                    }
                }

            }
            catch
            {
                return false;
            }

            // Check if the file is not null
            
           
        }
    }

}
