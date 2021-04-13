using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JSender.Contracts;
using JSender.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JSender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailsController : ControllerBase
    {
        private readonly IMailService _mailService;
        public EmailsController(IMailService mailService)
        {
            _mailService = mailService; 
        }
        [HttpPost("send")]
        public async Task<ActionResult> SendEmail(SendEmailRequest request)
        {
            await _mailService.SendEmailAsync(request.To, request.Subject, request.Message);

            return Ok();
        }
    }
}