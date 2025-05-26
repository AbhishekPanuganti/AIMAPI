using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLLCOMMONAPI.Service;
using NLLCOMMONAPI.Models;

namespace NLLCOMMONAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FileUploadController : ControllerBase
    {
        private readonly FileValidationService _fileValidationService;

        public FileUploadController(FileValidationService fileValidationService)
        {
            _fileValidationService = fileValidationService;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile([FromForm] FileUploadRequest request)
        {
            var file = request.File;

            if (file == null || file.Length == 0)
                return BadRequest("No file uploaded.");

            // Validate file
            if (!_fileValidationService.ValidateFile(file, out var errorMessage))
                return BadRequest(errorMessage);

            // Save file to a temporary location (optional)
            var safeFileName = Path.GetFileName(file.FileName);
            var safeFilePath = Path.Combine("Uploads", safeFileName);
            using (var stream = new FileStream(safeFilePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            // (Optional) Scan the file for malware here

            return Ok(new { Message = "File uploaded successfully." });
        }
    }
}
