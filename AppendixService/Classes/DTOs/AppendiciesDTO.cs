using AppendixService.Classes.Enums;
using AppendixService.Controllers;

namespace AppendixService.Classes.DTOs
{
    public class AppendiciesDTO
    {
        public int TotalCount { get; set; }
        public List<AppendixDetails> Appendices { get; set; }
    }
    public class AppendixDetails
    {
        public int Id { get; set; }
        public string DirectorateId { get; set; }
        public string DepartmentId { get; set; }
        public string MosqueName { get; set; }
        public string Address { get; set; }
        public string Area { get; set; }
        public DateTime RentalPeriodFrom { get; set; }

        public DateTime RentalPeriodTo { get; set; }

        public string? Notes { get; set; }
        public DateTime ApplicationAvailableFrom { get; set; }

        public DateTime ApplicationAvailableTo { get; set; }

        public string? CurrentActivity { get; set; }

        public AppendixStatus AppendixStatusId { get; set; }
    }
}
