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

            /* Locations Creation */
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

            /* Pets Creations */
            var dog1 = new Dog {
                Name = "Rex",
                Age = 2,
                Color = "Black",
                DogType = DogType.Bulldog,
            };
            context.Dogs.Add(dog1);

            var dog2 = new Dog {
                Name = "Aria",
                Age = 12,
                Color = "Grey",
                DogType = DogType.Beagle,
            };
            context.Dogs.Add(dog2);

            var dog3 = new Dog {
                Name = "Mimi",
                Age = 5,
                Color = "White",
                DogType = DogType.Chihuahua,
            };
            context.Dogs.Add(dog3);

            var cat1 = new Cat {
                Name = "Kety",
                Age = 1,
                Color = "Grey",
                CatType = CatType.Burmese,
            };
            context.Cats.Add(cat1);

            var rabbit1 = new Rodent {
                Name = "Bugs",
                Age = 0,
                Color = "Black",
                RodentType = RodentType.Rabbit,
            };
            context.Rodents.Add(rabbit1);

            var guineaPig1 = new Rodent {
                Name = "Susanna",
                Age = 3,
                Color = "Maroon",
                RodentType = RodentType.GuineaPig,
            };
            context.Rodents.Add(guineaPig1);

            var bird1 = new Bird {
                Name = "Ahil",
                Age = 2,
                Color = "Yellow and red",
                BirdType = BirdType.Parrot,
            };
            context.Birds.Add(bird1);

            var bird2 = new Bird {
                Name = "Jakopson",
                Age = 2,
                Color = "Black and white",
                BirdType = BirdType.Eagle,
            };
            context.Birds.Add(bird2);

            var image1 = this.GetImage("dog1.jpg");
            var image2 = this.GetImage("dog2.jpg");
            var image3 = this.GetImage("dog3.jpg");
            var image4 = this.GetImage("cat1.jpg");
            var image5 = this.GetImage("rabbit1.jpg");
            var image6 = this.GetImage("guineaPig1.jpg");
            var image7 = this.GetImage("bird1.jpg");
            var image8 = this.GetImage("bird2.jpg");

            context.Images.Add(image1);
            context.Images.Add(image2);
            context.Images.Add(image3);
            context.Images.Add(image4);
            context.Images.Add(image5);
            context.Images.Add(image6);
            context.Images.Add(image7);
            context.Images.Add(image8);

            var commentsContent = new List<string>();
            commentsContent.Add("Nice");
            commentsContent.Add("I saw it this morning!");
            commentsContent.Add("I will look around!");
            commentsContent.Add("Hope you'll find it :(");
            commentsContent.Add("Please help");
            commentsContent.Add("Shared!");


            /* Posts Creations */
            var post1 = new Post {
                Title = "I lost my dog!",
                Author = users[this.random.RandomNumber(0, users.Count - 1)],
                AnimalType = AnimalType.Dog,
                PostType = PostType.Lost,
                Pet = dog1,
            };
            post1.Locations.Add(locations[this.random.RandomNumber(0, locations.Count - 1)]);
            for (int i = 0; i < this.random.RandomNumber(1, 5); i++)
            {
                var comment = new Comment {
                    Content = commentsContent[this.random.RandomNumber(0, commentsContent.Count - 1)],
                    Author = users[this.random.RandomNumber(0, users.Count - 1)],
                };
                post1.Comments.Add(comment);
            }

            post1.Gallery.Add(image1);
            context.Posts.Add(post1);

            var post2 = new Post 
            {
                Title = "Beagle Found!",
                Author = users[this.random.RandomNumber(0, users.Count - 1)],
                AnimalType = AnimalType.Dog,
                PostType = PostType.Found,
                Pet = dog2,
            };
            post2.Locations.Add(locations[this.random.RandomNumber(0, locations.Count - 1)]);
            for (int i = 0; i < this.random.RandomNumber(1, 5); i++)
            {
                var comment = new Comment {
                    Content = commentsContent[this.random.RandomNumber(0, commentsContent.Count - 1)],
                    Author = users[this.random.RandomNumber(0, users.Count - 1)],
                };
                post2.Comments.Add(comment);
            }

            post2.Gallery.Add(image2);
            context.Posts.Add(post2);

            var post3 = new Post 
            {
                Title = "I lost Mimi!",
                Author = users[this.random.RandomNumber(0, users.Count - 1)],
                AnimalType = AnimalType.Dog,
                PostType = PostType.Lost,
                Pet = dog3,
            };
            post3.Locations.Add(locations[this.random.RandomNumber(0, locations.Count - 1)]);
            for (int i = 0; i < this.random.RandomNumber(1, 5); i++)
            {
                var comment = new Comment 
                {
                    Content = commentsContent[this.random.RandomNumber(0, commentsContent.Count - 1)],
                    Author = users[this.random.RandomNumber(0, users.Count - 1)],
                };
                post3.Comments.Add(comment);
            }

            post1.Gallery.Add(image3);
            context.Posts.Add(post3);

            var post4 = new Post {
                Title = "Where is Kety",
                Author = users[this.random.RandomNumber(0, users.Count - 1)],
                AnimalType = AnimalType.Cat,
                PostType = PostType.Lost,
                Pet = cat1,
            };
            post4.Locations.Add(locations[this.random.RandomNumber(0, locations.Count - 1)]);
            for (int i = 0; i < this.random.RandomNumber(1, 5); i++)
            {
                var comment = new Comment 
                {
                    Content = commentsContent[this.random.RandomNumber(0, commentsContent.Count - 1)],
                    Author = users[this.random.RandomNumber(0, users.Count - 1)],
                };
                post4.Comments.Add(comment);
            }

            post4.Gallery.Add(image4);
            context.Posts.Add(post4);

            var post5 = new Post 
            {
                Title = "I found a black rabbit",
                Author = users[this.random.RandomNumber(0, users.Count - 1)],
                AnimalType = AnimalType.Rodent,
                PostType = PostType.Found,
                Pet = rabbit1,
            };
            post5.Locations.Add(locations[this.random.RandomNumber(0, locations.Count - 1)]);
            for (int i = 0; i < this.random.RandomNumber(1, 5); i++)
            {
                var comment = new Comment 
                {
                    Content = commentsContent[this.random.RandomNumber(0, commentsContent.Count - 1)],
                    Author = users[this.random.RandomNumber(0, users.Count - 1)],
                };
                post5.Comments.Add(comment);
            }

            post5.Gallery.Add(image5);
            context.Posts.Add(post5);

            var post6 = new Post 
            {
                Title = "My peruvian is not at home",
                Author = users[this.random.RandomNumber(0, users.Count - 1)],
                AnimalType = AnimalType.Rodent,
                PostType = PostType.Lost,
                Pet = guineaPig1,
            };
            post6.Locations.Add(locations[this.random.RandomNumber(0, locations.Count - 1)]);
            for (int i = 0; i < this.random.RandomNumber(1, 5); i++)
            {
                var comment = new Comment 
                {
                    Content = commentsContent[this.random.RandomNumber(0, commentsContent.Count - 1)],
                    Author = users[this.random.RandomNumber(0, users.Count - 1)],
                };
                post6.Comments.Add(comment);
            }

            post6.Gallery.Add(image6);
            context.Posts.Add(post6);

            var post7 = new Post 
            {
                Title = "Somebody is searching a parrot?",
                Author = users[this.random.RandomNumber(0, users.Count - 1)],
                AnimalType = AnimalType.Bird,
                PostType = PostType.Found,
                Pet = bird1,
            };
            post7.Locations.Add(locations[this.random.RandomNumber(0, locations.Count - 1)]);
            for (int i = 0; i < this.random.RandomNumber(1, 5); i++)
            {
                var comment = new Comment 
                {
                    Content = commentsContent[this.random.RandomNumber(0, commentsContent.Count - 1)],
                    Author = users[this.random.RandomNumber(0, users.Count - 1)],
                };
                post7.Comments.Add(comment);
            }

            post7.Gallery.Add(image7);
            context.Posts.Add(post7);

            var post8 = new Post 
            {
                Title = "Help me to find my eagle",
                Author = users[this.random.RandomNumber(0, users.Count - 1)],
                AnimalType = AnimalType.Bird,
                PostType = PostType.Lost,
                Pet = bird2,
            };
            post8.Locations.Add(locations[this.random.RandomNumber(0, locations.Count - 1)]);
            for (int i = 0; i < this.random.RandomNumber(1, 5); i++)
            {
                var comment = new Comment 
                {
                    Content = commentsContent[this.random.RandomNumber(0, commentsContent.Count - 1)],
                    Author = users[this.random.RandomNumber(0, users.Count - 1)],
                };
                post8.Comments.Add(comment);
            }

            post8.Gallery.Add(image8);
            context.Posts.Add(post8);

            context.SaveChanges();
        }

        // TODO: Get the real file extension
        private Image GetImage(string imageName)
        {
            var directory = AssemblyHelpers.GetDirectoryForAssembyl(Assembly.GetExecutingAssembly());
            var file = File.ReadAllBytes(directory + "../../../../Data/LostPets.Data/Migrations/imgs/" + imageName);
            var image = new Image 
            {
                Content = file,
                FileExtension = "jpg"
            };

            return image;
        }
    }
}
