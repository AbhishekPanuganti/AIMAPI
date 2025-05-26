using System.Text.Json;

namespace NLLCOMMONAPI.Models
{
    public class ExceptionModel
    {
        public string? Message { get; set; }
        public string? StatusCode { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

    }
}
