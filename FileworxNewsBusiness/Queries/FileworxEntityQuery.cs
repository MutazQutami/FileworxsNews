using FileworxNews.Business.Models;
using FileworxNews.Business.Repos;


namespace FileworxNews.Business.Queries;

public class FileworxEntityQuery

{
    private IfileworxEntityQueryRepo _repository;

    public DateFilter QCreationDate = new DateFilter();

    public DateFilter QLastModificationDate = new DateFilter();


    public StringFilter QName = new StringFilter();

    public Guid? QId { get; set; }

    public Guid? QLastModifierId { get; set; }

    public Guid? QCreatorId { get; set; }

    public FileworxEntityQuery(IfileworxEntityQueryRepo repository)
    {
        _repository=repository;
    }

    public List<FileWorxEntity> Run()
    {
       return _repository.Run(this);
        
    }
}

