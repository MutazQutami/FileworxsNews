using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using FileworxNews.Business.Repos;

namespace FileworxNews.Business.Models;
public class Content : FileWorxEntity
{
    private IContentRepo _repo;
    public string Description { get; set; }

    public string Body { get; set; }

    public Content(IContentRepo repo) => _repo = repo;

    public Content() { }
    public override async Task Update()
    {
        Validate();
       await _repo.Update(this);
     
    }

    public override async Task Delete() => await _repo.Delete(this);

    public async Task<Content> Read() => await _repo.Read(this);

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

