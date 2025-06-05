using Microsoft.AspNetCore.Mvc;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Users.UpdateUser
{
    public class UpdateUserIdRequest
    {
        /// <summary>
        /// The unique identifier of the Updated user
        /// </summary> 
        [FromRoute]
        public Guid Id { get; set; }
        [FromBody]
        public UpdateUserRequest? Request { get; set; }
    }
}
