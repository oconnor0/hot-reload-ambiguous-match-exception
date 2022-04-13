using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

[Route("a")]
[ApiController]
public class ABController : ControllerBase {
        
    [HttpGet("b")]
    public async Task<IActionResult> GetB() {
        // return StatusCode(404);
        return StatusCode(200); 
    }
}
 