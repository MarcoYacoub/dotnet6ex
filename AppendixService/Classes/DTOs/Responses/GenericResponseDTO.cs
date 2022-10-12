namespace AppendixService.Classes.DTOs.Responses
{
    public class GenericResponseDTO<T>
    {
        public T Data { get; set; }
        public int ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public List<string> Errors { get; set; }
    }
}
