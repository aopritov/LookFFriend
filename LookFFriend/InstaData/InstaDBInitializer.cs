using System.Collections.Generic;
using System.Data.Entity;
using InstaData.Enum;
using InstaData.InstaModels;

namespace InstaData
{
    public class InstaDBInitializer : DropCreateDatabaseIfModelChanges<InstaContext>
    {
        protected override void Seed(InstaContext context)
        {
            IList<User> defaultUsers = new List<User>();

            defaultUsers.Add(new User() { UserId = 1, Username = "coffee_n_photo", Status = CommonStatus.None });
            defaultUsers.Add(new User() { UserId = 2, Username = "artemiytrov", Status = CommonStatus.None });

            foreach (User us in defaultUsers)
                context.Users.Add(us);

            base.Seed(context);
        }
    }
}
