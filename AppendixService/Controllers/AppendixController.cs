using AppendixService.Classes.DTOs;
using AppendixService.Classes.DTOs.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Diagnostics;
using System.Net;

namespace AppendixService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppendixController : ControllerBase
    {
        
        [HttpGet("GetTermsAndConditions")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(GenericResponseDTO<TermsAndConditionsDTO>))]
        public IActionResult GetTermsAndConditions()
        {
            var genericResponseDTO = new GenericResponseDTO<TermsAndConditionsDTO>();
            genericResponseDTO.Data = new TermsAndConditionsDTO();
            return Ok(genericResponseDTO);
        }
        [HttpPost("GetAppendices")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(GenericResponseDTO<List<AppendiciesDTO>>))]
        public IActionResult GetAppendices(AppendixSearchDTO appendixSearchDTO)
        {
            var genericResponseDTO = new GenericResponseDTO<List<AppendiciesDTO>>();
            genericResponseDTO.Data = new List<AppendiciesDTO>();
            return Ok(genericResponseDTO);
        }
        [HttpPost("RequestAppendix")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ApplicationResponseDTO))]
        public IActionResult RequestAppendix(AppendixApplicationDTO appendixApplicationDTO)
        {
            return Ok();
        }
        [HttpGet("InquireRequestStatus")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(RequestStatusDTO))]
        public IActionResult InquireRequestStatus(UpdateRequestStatusDTO updateRequestStatusDTO)
        {
            // check if Request can move from the current status or not if not return false/error depending on schecma.
            return Ok();
        }
        [HttpPost("UpdateRequestStatus")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(RequestStatusDTO))]
        public IActionResult UpdateRequestStatus(UpdateRequestStatusDTO updateRequestStatusDTO )
        {
            // check if Request can move from the current status or not if not return false/error depending on schecma.
            return Ok();
        }
        // would we use the same update request status object
        [HttpPost("UpdateAppendixDeliveryStatus")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(RequestStatusDTO))]
        public IActionResult UpdateAppendixDeliveryStatus(UpdateRequestStatusDTO scheduleContractAppointment)
        {
            return Ok();
        }
        [HttpPost("NotifyContractDelivered")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(RequestStatusDTO))]
        public IActionResult NotifyContractDelivered(NotifyContractDeliveredDTO notifyContractDelivered)
        {
            return Ok();
        }
        [HttpPost("ScheduleContractAppointment")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ScheduleContractAppointmentResponse))]
        public IActionResult ScheduleContractAppointment(ScheduleContractAppointmentDTO scheduleContractAppointment)
        {
            return Ok();
        }
    }

  

    

   
}
