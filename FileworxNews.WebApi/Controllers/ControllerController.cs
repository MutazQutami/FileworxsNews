using FileworxNews.Business.Models;
using FileworxNews.Business.Queries;
using FileworxNews.Business.Repos;
using FileworxNews.Shared.Dtos;
using FileworxNews.WebApi.Mapping;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileworxNews.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerController : ControllerBase
    {
        private readonly IContentQueryRepo _contentQueryRepo;
        private readonly IContentRepo _contentRepo;

        public ControllerController(IContentQueryRepo contentQueryRepo, IContentRepo contentRepo)
        {
            _contentQueryRepo = contentQueryRepo;
            _contentRepo = contentRepo;
        }

            // POST: FileworxNews/Content
            [HttpPost]
            [Route("")]
            public async Task<ActionResult> Post([FromBody] ContentDto contentDto)
            {
                if (contentDto == null)
                {
                    return BadRequest("Content cannot be null");
                }

                try
                {

                if (_contentRepo == null)
                {
                    throw new Exception("sfd");
                }
                    var createdContent = new Content(_contentRepo);
                    createdContent = ContentMapper.ToEntity(contentDto);
                    Console.WriteLine(createdContent.Name);
                    await createdContent.Update();
                    return CreatedAtAction(nameof(GetById), new { id = Guid.NewGuid() }, createdContent);
                }
                catch (Exception ex)
                {
                    return StatusCode(500, $"Internal server error: {ex.Message}");
                }
            }

            // GET: FileworxNews/Content/{id}
            [HttpGet]
            [Route("{id}")]
            public async Task<ActionResult<ContentDto>> GetById(Guid id)
            {
                var content = new ContentQuery();
                content.QId = id;

                var result = content.Run();

                if (result == null || !result.Any())
                {
                    return NotFound("Content not found");
                }

                return Ok(result);
            }

            // GET: FileworxNews/Content
            [HttpGet]
            [Route("")]
            public async Task<ActionResult<IEnumerable<ContentDto>>> GetAll()
            {
                var content = new ContentQuery();
                var result = content.Run();
                return Ok(result);
            }

            // PUT: api/Content/
            [HttpPut]
            [Route("{Id}")]
            public async Task<ActionResult> Put(int Id, [FromBody] ContentDto contentDto)
            {
                if (contentDto == null)
                {
                    return BadRequest("Content data cannot be null");
                }

                try
                {
                    var content = ContentMapper.ToEntity(contentDto);
                    await content.Update();

                    await content.Update();

                    return Ok(content);
                }
                catch (Exception ex)
                {
                    return StatusCode(500, $"Internal server error: {ex.Message}");
                }
            }

            // DELETE: api/Content/{id}
            [HttpDelete]
            [Route("{id}")]
            public async Task<ActionResult> Delete(Guid id)
            {
                try
                {
                    var content = new ContentQuery();
                    content.QId = id;
                    var result = content.Run().FirstOrDefault();

                    if (result == null)
                    {
                        return NotFound("Content to delete not found");
                    }

                    await result.Delete();

                    return NoContent();
                }
                catch (Exception ex)
                {
                    return StatusCode(500, $"Internal server error: {ex.Message}");
                }
            }
        }
    }
    
