using System.ComponentModel.DataAnnotations;
using FileworxNews.Business.Repos;
using Microsoft.EntityFrameworkCore;

namespace FileworxNews.Business.Models;

public class Photo : Content
{
    private IPhotoRepo _repo;
   
    public string PhotoPath { get; set; }

    public Photo(IPhotoRepo repo)
    {
        _repo = repo;
    }

    public Photo() => _repo = null;

    public override async Task Update()
    {
        Validate();

        await _repo.Update(this);
    }

    public override async Task Delete() => await _repo.Delete(this);

    public  async Task<Photo> Read() => await _repo.Read(this);

    private void Validate()
    {
        if (string.IsNullOrEmpty(PhotoPath))
            throw new ValidationException("PhotoPath cannot be empty.");
    }
}
