using FileworxNews.Business.Repos;

namespace FileworxNews.Business.Models
{
    public class FileWorxEntity
    {
        private readonly IFileworxEntityRepo _repository;

        public Guid Id { get; set; }

        public DateTime CreationDate { get; set; }

        public Guid? LastModifierId { get; set; }

        public DateTime LastModificationDate { get; set; }

        public Guid? CreatorId { get; set; }

        public string Name { get; set; }
     
        public FileWorxEntity()
        {

        }

        public FileWorxEntity(IFileworxEntityRepo repository)
        {
            _repository = repository;
        }

        public FileWorxEntity(Guid guidValue)
        {
            Id = guidValue;
        }

        public virtual async Task  Update()
        {

            await _repository.Update(this);
        }

        public virtual async Task Delete()
        {
           await _repository.Delete(this);
        }

        public virtual async Task<FileWorxEntity> Read()
        {
            return await _repository.Read(this);
        }
    }
}




