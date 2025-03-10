using FileworxNews.Business.Queries;
using FileworxNews.Business.Repos;
using FileworxNews.DataAccess.Repos;
using FileworxNews.Shared.Dtos;
using FileworxNews.WebApi.Mapping;
using Microsoft.AspNetCore.Mvc;

namespace FileworxNews.WebApi.Controllers
{
    [Route("FileworxNews/[controller]")]
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

                var createdContent = ContentMapper.ToEntity(contentDto);
                createdContent.Repo = _contentRepo;

                await createdContent.Update();
                    return CreatedAtAction(nameof(GetById), new { id = Guid.NewGuid() }, contentDto);
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
                var content = new ContentQuery(_contentQueryRepo);
                content.QId = id;

                var result = content.Run().FirstOrDefault();
              

                if (result == null )
                {
               
                return NotFound("Content not found");
                }
            var contentDto = ContentMapper.ToDto(result);

            return Ok(contentDto);
            }

            // GET: FileworxNews/Content
            [HttpGet]
            [Route("")]
            public async Task<ActionResult<IEnumerable<ContentDto>>> GetAll()
            {
                var content = new ContentQuery(_contentQueryRepo);
                var result = content.Run();
                var DtoResult = result.Select(e => ContentMapper.ToDto(e)).ToList();
          
                return Ok(DtoResult);
            }

        // PUT: FileworxNews/Content/
        [HttpPut]
            [Route("{Id}")]
            public async Task<ActionResult> Put(Guid Id, [FromBody] ContentDto contentDto)
            {
                if (contentDto == null)
                {
                    return BadRequest("Content data cannot be null");
                }

            var ContentQuery = new ContentQuery(_contentQueryRepo);
            ContentQuery.QId = Id;
            var result = ContentQuery.Run().FirstOrDefault();
            if(result == null)
            {
                return NotFound("Content to update not found");
            }

            try
            {
                    var content = ContentMapper.ToEntity(contentDto);
                    content.Repo=_contentRepo;
                    await content.Update();

                    return Ok(content);
                }
                catch (Exception ex)
                {
                    return StatusCode(500, $"Internal server error: {ex.Message}");
                }
            }

        // DELETE: FileworxNews/Content/{id}
        [HttpDelete]
            [Route("{id}")]
            public async Task<ActionResult> Delete(Guid id)
            {
                try
                {
                    var content = new ContentQuery(_contentQueryRepo);
                    content.QId = id;
                    var result = content.Run().FirstOrDefault();

                    if (result == null)
                    {
                        return NotFound("Content to delete not found");
                    }
                    result.Repo = _contentRepo;

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
    
