namespace Blog.Application.DTOs;

public class CommentDto : DtoBase {
    public string Content { get; private set; }

    public CommentDto(string content) {
        Content = content;
    }
}
