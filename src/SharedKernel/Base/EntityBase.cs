namespace Blog.SharedKernel.Base;

public abstract class EntityBase {
    public int Id { get; }

    public DateTime CreatedAt { get; }
    public DateTime UpdatedAt { get; private set; }
}
