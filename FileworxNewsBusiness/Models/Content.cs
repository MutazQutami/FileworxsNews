using System.ComponentModel.DataAnnotations;
using FileworxNews.Business.Repos;

namespace FileworxNews.Business.Models;
public class Content : FileWorxEntity
{
    public IContentRepo Repo { get; set; }

    public string Description { get; set; }

    public string Body { get; set; }

    public Content(IContentRepo repo) {
       
        repo = repo;
    }

    public Content() { }

    public override async Task Update()
    {
        Validate();
        await Repo.Update(this);
    }

    public override async Task Delete() => await Repo.Delete(this);

    public async Task<Content> Read() => await Repo.Read(this);

    private void Validate()
    {
        if (string.IsNullOrEmpty(Name))
            throw new ValidationException("Title cannot be empty.");

        if (string.IsNullOrEmpty(Description))
            throw new ValidationException("Description cannot be empty.");

        if (string.IsNullOrEmpty(Body))
            throw new ValidationException("Body cannot be empty.");
    }
}

