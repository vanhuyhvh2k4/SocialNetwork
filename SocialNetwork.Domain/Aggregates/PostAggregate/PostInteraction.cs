using System;

namespace SocialNetwork.Domain.Aggregates.PostAggregate
{
    public class PostInteraction
    {
        private PostInteraction()
        {

        }

        public Guid InteractionId { get; private set; }

        public Guid PostId { get; private set; }

        public InteractionType InteractionType { get; private set; }

        // factory method
        public static PostInteraction CreatePostInteraction(Guid postId, InteractionType interactionType)
        {
            // validate data, error handling, error notification
            var postInteraction = new PostInteraction()
            {
                PostId = postId,
                InteractionType = interactionType 
            };

            return postInteraction;
        }
    }
}

