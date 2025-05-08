using Ambev.DeveloperEvaluation.Application.Users.GetUser;
using Ambev.DeveloperEvaluation.WebApi.Common;
using Ambev.DeveloperEvaluation.WebApi.Features.Users.GetUser;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrroductController : BaseController
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mediator"></param>
        /// <param name="mapper"></param>
        public PrroductController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }


        // GET api/<PrroductController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ApiResponseWithData<GetUserResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetUser([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var request = new GetUserRequest { Id = id };
            var validator = new GetUserRequestValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var command = _mapper.Map<GetUserCommand>(request.Id);
            var response = await _mediator.Send(command, cancellationToken);

            return Ok(new ApiResponseWithData<GetUserResponse>
            {
                Success = true,
                Message = "User retrieved successfully",
                Data = _mapper.Map<GetUserResponse>(response)
            });
        }
    }
}
