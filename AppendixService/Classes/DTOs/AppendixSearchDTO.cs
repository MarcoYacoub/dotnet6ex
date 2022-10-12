using AppendixService.Classes.Enums;
using AppendixService.Controllers;

namespace AppendixService.Classes.DTOs
{
    public class AppendixSearchDTO
    {
        public string? DirectorateId { get; set; }
        public string? DepartmentId { get; set; }
        public string? MosqueName { get; set; }
        public string? CurrentActivity { get; set; }

        public List<int> ActivityId { get; set; }

        public List<AppendixStatus> AppendixStatusId { get; set; }

        public int PageNumber { get; set; } = 1;


        public int PageSize { get; set; } = 10;


    }
}
