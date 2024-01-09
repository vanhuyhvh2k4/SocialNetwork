using System;
using SocialNetwork.Domain.Aggregates.UserProfileAggregate;

namespace SocialNetwork.Domain.Aggregates.PostAggregate
{
    public class Post
    {
        private readonly List<PostComment> _comments = new List<PostComment>();
        private readonly List<PostInteraction> _interactions = new List<PostInteraction>();

        private Post()
        {
        }

        public Guid PostId { get; private set; }

        public Guid UserProfileId { get; private set; }

        public UserProfile userProfile { get; private set; }

        public string TextContent { get; private set; }

        public DateTime CreatedDate { get; private set; }

        public DateTime LastModified { get; private set; }

        public IEnumerable<PostComment> Comments { get { return _comments; } }

        public IEnumerable<PostInteraction> Interactions { get { return _interactions; } }

        // factory method
        public static Post CreatePost(Guid userProfileId, string textContent)
        {
            var post = new Post()
            {
                UserProfileId = userProfileId,
                TextContent = textContent,
                CreatedDate = DateTime.UtcNow,
                LastModified = DateTime.UtcNow
            };

            return post;
        }

        // public method
        public void UpdatePostText(string newText)
        {
            TextContent = newText;
            LastModified = DateTime.UtcNow;
        }

        public void AddPostComment(PostComment newPostComment)
        {
            _comments.Add(newPostComment);
        }

        public void RemoveComment(PostComment toRemove)
        {
            _comments.Remove(toRemove);
        }

        public void AddInteraction(PostInteraction newInteraction)
        {
            _interactions.Add(newInteraction);
        }

        public void RemoveInteraction(PostInteraction toRemove)
        {
            _interactions.Remove(toRemove);
        }
    }
}

