using AppendixService.Classes.Enums;

namespace AppendixService.Classes.DTOs
{
    public class UpdateRequestStatusDTO
    {
        public string RequestId { get; set; }
        public RequestStatus RequestStatus { get; set; }
    }
}
