using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileworxNews.Business.Models;

namespace FileworxNews.Business.Repos
{
    public interface IContentRepo
    {
        Task Update(Content content);

        Task Delete(Content content);

        Task<Content> Read(Content content);

        Task<List<Content>> ReadAll();
    }
}
