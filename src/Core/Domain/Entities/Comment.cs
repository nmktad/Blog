using Blog.SharedKernel.Base;
using Blog.SharedKernel.Interfaces;

namespace Blog.Domain.Entities;

public class Comment : EntityBase, IAggregateRoot {
    public string Content { get; private set; }

    public Comment(string content) {
        Content = content;
    }

    public int? PostId { get; set; }
    public virtual Post? Post { get; set; }  

    public override string ToString()
    {
        return $"Comment Id: {Id}\nPost Id: {PostId}\nText: \n\t{Content}\nDate: {CreatedAt}";
    }
}
