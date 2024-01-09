using System;

namespace SocialNetwork.Domain.Aggregates.UserProfileAggregate
{
    public class UserProfile
    {
        private UserProfile()
        {

        }

        public Guid UserProfileId { get; private set; }

        public string IdentityId { get; private set; }

        public BasicInfo BasicInfo { get; private set; }

        public DateTime DateCreated { get; set; }

        public DateTime LastModified { get; private set; }


        // Factory method
        public static UserProfile CreateUserProfile(string identityId, BasicInfo basicInfo)
        {
            // to do: add validate data

            var userProfile = new UserProfile()
            {
                IdentityId = identityId,
                BasicInfo = basicInfo,
                DateCreated = DateTime.UtcNow,
                LastModified = DateTime.UtcNow
            };

            return userProfile;
        }

        // public method
        public void UpdateBasicInfo(BasicInfo newInfo)
        {
            BasicInfo = newInfo;
            LastModified = DateTime.UtcNow;
        }
    }
}

