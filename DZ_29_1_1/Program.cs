using DZ_29_1_1;
using Microsoft.EntityFrameworkCore;

//using (ApplicationContext db= new ApplicationContext())
//{
//    db.Database.EnsureDeleted();
//    db.Database.EnsureCreated();

//    List<User> users = new List<User>()
//    {
//        new User
//        {
//            Email="admin@gmail.com",
//            UserStrings = new UserStrings
//            {
//                Country="China",
//                City="CityOne"
//            }
//        },
//                new User
//        {
//            Email="admin1@gmail.com",
//            UserStrings = new UserStrings
//            {
//                Country="USA",
//                City="CityTwo"
//            }
//        }                
//    };
//    db.Users.AddRange(users);
//    db.SaveChanges();
//}

using (ApplicationContext db = new ApplicationContext())
{
    var currentUser=db.Users.Include(e=>e.UserStrings).FirstOrDefault();
}


