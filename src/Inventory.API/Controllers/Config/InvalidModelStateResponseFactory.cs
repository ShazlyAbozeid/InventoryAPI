using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Inventory.API.Extensions;
using Inventory.API.Resources;

namespace Inventory.API.Controllers.Config
{
    public static class InvalidModelStateResponseFactory
    {
        public static IActionResult ProduceErrorResponse(ActionContext context)
        {
            var errors = context.ModelState.GetErrorMessages();
            var response = new ErrorResource(messages: errors);
            
            return new BadRequestObjectResult(response);
        }
    }
}