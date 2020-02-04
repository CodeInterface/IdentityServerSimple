using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClientCredentialApi.Controllers{
    
    [Route("identity")]
    [Authorize]
    public class IdentityController:ControllerBase{
        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(new {Msg="Success",Code=200});
        }
    }
}