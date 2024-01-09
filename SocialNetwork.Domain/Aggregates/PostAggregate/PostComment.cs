using System;

namespace SocialNetwork.Domain.Aggregates.PostAggregate
{
    public class PostComment
    {
        private PostComment()
        {

        }

        public Guid CommentId { get; private set; }

        public Guid PostId { get; private set; }

        public string Text { get; private set; }

        public Guid UserProfileId { get; private set; }

        public DateTime DateCreated { get; private set; }

        public DateTime LastModified { get; private set; }

        // Fatory method
        public static PostComment CreatePostCommment(Guid postId, string text, Guid userProfileId)
        {
            // validate data, handling error, error notification
            var comment = new PostComment()
            {
                PostId = postId,
                Text = text,
                DateCreated = DateTime.UtcNow,
                LastModified = DateTime.UtcNow
            };

            return comment;
        }

        // public method
        public void UpdateCommentText(string newText)
        {
            Text = newText;
            LastModified = DateTime.UtcNow;
        }
    }

}

