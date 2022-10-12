namespace AppendixService.Classes.DTOs
{
    public class AppendixApplicationDTO
    {
        public NationalIdInfo CitizenInfo { get; set; }
        public int AppendixId { get; set; }
        public int ActivityId { get; set; }
        public string? OtherActivity { get; set; }
        public List<IFormFile>? Attachments { get; set; }
        public string RequestId { get; set; }
    }
}
