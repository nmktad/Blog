namespace Blog.Application.DTOs;

public class PostDto : DtoBase {
    public string Title { get; private set; } 
    public string Content { get; private set; } 

    public PostDto(string title, string content) {
        Content = content;
        Title = title;
    }
}
