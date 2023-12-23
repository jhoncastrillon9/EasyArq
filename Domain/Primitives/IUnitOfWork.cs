namespace Domain;

public interface IUnitOfWork
{
    Task<int> SaveshangesAsync(CancellationToken cancellationToken = default);
}
