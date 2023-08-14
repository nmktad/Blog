using Blog.SharedKernel.Interfaces;
using Blog.SharedKernel.Base;

namespace Blog.Domain.Entities;

public class Post : EntityBase, IAggregateRoot {
    public string Title { get; private set; } 
    public string Content { get; private set; } 

    public virtual ICollection<Comment> Comments { get; }

    public Post(string title, string content) {
        Title = title;
        Content = content;
        Comments = new List<Comment>();
    }

    public override string ToString() {
        return $"Post Id: {Id}\nPost Title: {Title}\nPost Content: \n\t{Content}\nDate: {CreatedAt}";
    }     
}
