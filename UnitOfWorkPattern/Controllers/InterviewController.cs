namespace UnitOfWorkPattern.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using UnitOfWorkPattern.Api.Dtos;
    using UnitOfWorkPattern.Api.Services;

        [Route("api/[controller]")] 
        public class InterviewController : Controller
        {
            private readonly IInterviewService _interviewService;

            public InterviewController(IInterviewService interviewService)
            {
                _interviewService = interviewService;
            }

            [HttpPost]
            public async Task Post([FromBody]InterviewDto interviewDto)
            {
                await _interviewService.SubmitAsync(interviewDto);
            }
        }
}
