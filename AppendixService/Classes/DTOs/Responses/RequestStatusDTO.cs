namespace AppendixService.Classes.DTOs.Responses
{
    public class RequestStatusDTO
    {
        public string RequestStatus { get; set; }
        public string RequestId { get; set; }
        public string Details { get; set; }
        public DateTime TimeStamp { get; set; }
        public int ResponseCode { get; set; }
        public string ResponseMessage { get; set; }

    }
}
