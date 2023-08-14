namespace Blog.SharedKernel.Interfaces;

public interface IReadRepository<T> where T : class, IAggregateRoot {
    Task<T?> GetByIdAsync<TId>(TId id, CancellationToken cancellationToken = default) where TId : notnull;

    Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default);
}
