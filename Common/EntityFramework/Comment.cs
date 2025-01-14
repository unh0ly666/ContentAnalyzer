﻿namespace Common.EntityFramework;

public class Comment
{
    public Comment()
    {
        IncludedInEvaluatedComments = new HashSet<EvaluatedComment>();
    }

    public long Id { get; init; }
    public long CommentId { get; init; }
    public long PostId { get; init; }
    public long GroupId { get; init; }
    public long AuthorId { get; init; }
    public string Text { get; init; }
    public DateTime PostDate { get; init; }
    public ICollection<EvaluatedComment> IncludedInEvaluatedComments { get; }
}