using FileworxNews.Business.Repos;
using FileworxNews.Shared;
using FileworxNews.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileworxNews.WebApi.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IFileworxEntityRepo _repository;
       
        private readonly IUserRepo _userRepo;

        // Constructor to inject the repository
        public UserController(IFileworxEntityRepo repository , IUserRepo userRepo)
        {
            _repository = repository;
            _userRepo = userRepo;
            
            //var newEntity = new Business.Models.FileWorxEntity(repository)
            //{
            //    Name = "et",
            //    Id = Guid.NewGuid(),  // You can generate the Id or pass it from the request
            //    LastModifierId = null,
            //    CreatorId = null,
            //    Creator=null,
            //    LastModifier=null,
               
            //};
            //newEntity.Update();
        }

        //// POST method to create or update FileWorxEntity
        //[HttpPost]
        //[Route("")]
        //public async Task <ActionResult> Post([FromBody] FileWorxEntityDto entityDto)
        //{
        //    // Validate input
        //    if (entityDto == null)
        //    {
        //        return BadRequest("Content cannot be null");
        //    }

        //    // Create or update the entity based on DTO
        //    var test = new Business.Models.FileWorxEntity(_repository)
        //    {
        //        Name = entityDto.Name,
        //        Id = Guid.NewGuid(),
        //        LastModificationDate = entityDto.LastModificationDate,
        //        CreationDate = DateTime.Now, // Set to current time on creation
        //        LastModifierId = entityDto.LastModifierId,
        //        CreatorId = entityDto.CreatorId
        //    };

        //    // Assuming Update method saves the entity
        //  await   test.Update();

        //    // Return a success message with the updated entity
        //    return Ok(new { Message = "Content received successfully", entityDto });
        //}

        [HttpPost]
        [Route("")]
        public async Task<ActionResult> PostUser([FromBody] User user)
        {
            // Validate input
            if (User == null)
            {
                return BadRequest("Content cannot be null");
            }

            // Create or update the entity based on DTO
            var test = new Business.Models.User(_userRepo)
            {
                Name = user.Name,
                LastModificationDate = user.LastModificationDate,
                LastModifierId = user.LastModifierId,
                CreatorId = user.CreatorId,
                LogInName = user.LogInName,
                Password = user.Password,
                IsAdmin = user.IsAdmin,
                
            };

            // Assuming Update method saves the entity
            await test.Update();

            // Return a success message with the updated entity
            return Ok(new { Message = "Content received successfully", user });
        }
    }

}
