using FileworxNews.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileworxNews.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentContoller : ControllerBase
    {

        

        [HttpPost]
        [HttpPost]
        [Route("")]
        public ActionResult Post([FromBody] ContentDto contentDto)
        {
            if (contentDto == null)
            {
                return BadRequest("Content cannot be null");
            }

           
           

            return Ok(new { Message = "Content received successfully", Content = contentDto });
        }

    }
}
