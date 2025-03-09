using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using FileworxNews.Business.Repos;
using Microsoft.EntityFrameworkCore;

namespace FileworxNews.Business.Models;
public class News : Content
{
    private INewsRepo _repo;

    public News(INewsRepo repo) => _repo = repo;
    public News()
    {
        _repo = null;
    }
    public enum CategoryTypes
    {
        General,
        Sports,
        Health,
        Politics
    }
    public CategoryTypes Category { get; set; }

    public override async Task Update()
    {
        Validate();
        await _repo.Update(this); 
    }

    public override async Task Delete() => await _repo.Delete(this);

    public async Task<News> Read()
    {
      return await _repo.Read(this);
    }

    private void Validate()
    {
        if (Category.Equals(null))
            throw new ValidationException("Category cannot be empty.");
    }
}
