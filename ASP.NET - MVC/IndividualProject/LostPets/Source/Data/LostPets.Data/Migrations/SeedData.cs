namespace LostPets.Data.Migrations
{
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    using Models;
    using Models.Types;
    using LostPets.Common;

    public class SeedData
    {
        private IRandomGenerator random;
        private PasswordHasher passwordHasher;

        public SeedData(LostPetsDbContext context)
        {
            this.random = new RandomGenerator();
            this.passwordHasher = new PasswordHasher();
        }

        public void Seed(LostPetsDbContext context)
        {
            this.SeedRoles(context);
            this.SeedUsers(context);
            this.SeedPostsWithLocationsWithComments(context);
        }

        private void SeedRoles(LostPetsDbContext context)
        {
            context.Roles.AddOrUpdate(x => x.Name, new IdentityRole(GlobalConstants.AdminRole));
            context.Roles.AddOrUpdate(x => x.Name, new IdentityRole(GlobalConstants.UserRole));
            context.SaveChanges();
        }

        private void SeedUsers(LostPetsDbContext context)
        {
            if (context.Users.Any())
            {
                return;
            }

            for (int i = 0; i < 10; i++)
            {
                var user = new User {
                    Email = string.Format("user{0}@site.com", i),
                    UserName = string.Format("username{0}", i),
                    PasswordHash = this.passwordHasher.HashPassword("123456"),
                    UserRole = GlobalConstants.UserRole,
                };

                context.Users.Add(user);
            }

            var adminUser = new User {
                Email = "admin@mysite.com",
                UserName = "Admin",
                PasswordHash = this.passwordHasher.HashPassword("admin123456"),
                UserRole = GlobalConstants.AdminRole,
                ProfilePicture = this.GetImage("admin.jpe")
            };

            context.Users.Add(adminUser);
            context.SaveChanges();
        }

        private void SeedPostsWithLocationsWithComments(LostPetsDbContext context)
        {
            if (context.Posts.Any())
            {
                return;
            }

            var users = context.Users.Take(10).ToList();

            var locations = new List<Location>();
            var location1 = new Location {
                City = City.Sofia,
                Street = "Mladost",
                AdditionalInfo = "Near the Business Park"
            };
            context.Locations.Add(location1);

            locations.Add(location1);
            var location2 = new Location {
                City = City.Plovdiv,
                Street = "Bulevard Bulgaria",
                AdditionalInfo = "near the park"
            };
            locations.Add(location2);
            context.Locations.Add(location2);

            var location3 = new Location {
                City = City.Sofia,
                Street = "Bulevard Bulgaria",
                AdditionalInfo = "near the park"
            };
            locations.Add(location3);
            context.Locations.Add(location3);

            var dog1 = new Dog {
                Name = "Rex",
                Age = 2,
                Color = "Black",
                DogType = DogType.Bulldog,
            };
            context.Dog.Add(dog1);

            var image1 = this.GetImage("dog1.jpg");
            context.Images.Add(image1);

            var commentsContent = new List<string>();
            commentsContent.Add("Nice");
            commentsContent.Add("I saw it this morning!");
            commentsContent.Add("I will look around!");

            var post1 = new Post {
                Title = "I lost my dog!",
                Author = users[this.random.RandomNumber(0, users.Count - 1)],
                AnimalType = AnimalType.Dog,
                PostType = PostType.Lost,
            };
            post1.Locations.Add(locations[1]);
            for (int i = 0; i < 3; i++)
            {
                var comment = new Comment {
                    Content = commentsContent[this.random.RandomNumber(0, commentsContent.Count - 1)],
                    Author = users[this.random.RandomNumber(0, users.Count - 1)],
                };
                post1.Comments.Add(comment);
            }

            context.Posts.Add(post1);
            context.SaveChanges();
        }

        // TODO: Get the real file extension
        private Image GetImage(string imageName)
        {
            var directory = AssemblyHelpers.GetDirectoryForAssembyl(Assembly.GetExecutingAssembly());
            var file = File.ReadAllBytes(directory + "../../../../Data/LostPets.Data/Migrations/imgs/" + imageName);
            var image = new Image {
                Content = file,
                FileExtension = "jpg"
            };

            return image;
        }
    }
}
