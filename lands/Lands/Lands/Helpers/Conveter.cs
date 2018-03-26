namespace Lands.Helpers
{
    using Domain;
    using Models;

    public static class Conveter
    {
        public static UserLocal ToUserLocal(User user)
        {
            return new UserLocal()
            {
                UserId = user.UserId,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Telephone = user.Telephone,
                ImagePath = user.ImagePath,
                UserTypeId = user.UserTypeId
                //ImageFullPath = user.ImageFullPath,
                //FullName = user.FullName,
            };
        }

        public static User ToUserDomain(UserLocal user, byte[] imageArray)
        {
            return new User
            {
                UserId = user.UserId,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Telephone = user.Telephone,
                ImagePath = user.ImagePath,
                UserTypeId = user.UserTypeId.Value,
                ImageArray = imageArray
            };
        }
    }
}
