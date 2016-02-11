namespace YoutubePlaylists.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using System;
    using System.Collections.Generic;
    using YouTubePlaylists.Data.Models;

    public class SeedData
    {
        public static Random Rand = new Random();

        public List<Category> Categories;

        public List<Playlist> Playlists;

        public List<Video> Videos;

        public List<Rating> Ratings;

        public List<User> Users;

        public User Author
        {
            get; set;
        }

        public SeedData(User author)
        {
            var passwordHash = new PasswordHasher();
            string password1 = passwordHash.HashPassword("user1");
            string password2 = passwordHash.HashPassword("user2");
            string password3 = passwordHash.HashPassword("user3");
            string password4 = passwordHash.HashPassword("user4");
            string password5 = passwordHash.HashPassword("user5");

            this.Users = new List<User>();
            Users.Add(new User() { UserName = "user1@site.com", PasswordHash = password1, SecurityStamp="aasas" });
            Users.Add(new User() { UserName = "user2@site.com", PasswordHash = password2, SecurityStamp = "aasas" });
            Users.Add(new User() { UserName = "user3@site.com", PasswordHash = password3, SecurityStamp = "aasas" });
            Users.Add(new User() { UserName = "user4@site.com", PasswordHash = password4, SecurityStamp = "aasas" });
            Users.Add(new User() { UserName = "user5@site.com", PasswordHash = password5, SecurityStamp = "aasas" });

            

            this.Categories = new List<Category>();
            Categories.Add(new Category() { Name = "Music" });
            Categories.Add(new Category() { Name = "Film" });
            Categories.Add(new Category() { Name = "Lectures" });
            Categories.Add(new Category() { Name = "Funnny " });
            Categories.Add(new Category() { Name = "Cats" });
            Categories.Add(new Category() { Name = "a" });
            Categories.Add(new Category() { Name = "b" });
            Categories.Add(new Category() { Name = "c" });
            Categories.Add(new Category() { Name = "d" });
            Categories.Add(new Category() { Name = "e" });
            Categories.Add(new Category() { Name = "f" });
            Categories.Add(new Category() { Name = "g" });
            Categories.Add(new Category() { Name = "h" });
            Categories.Add(new Category() { Name = "i" });
            Categories.Add(new Category() { Name = "j" });
            Categories.Add(new Category() { Name = "k" });
            Categories.Add(new Category() { Name = "l" });
            Categories.Add(new Category() { Name = "m" });
            Categories.Add(new Category() { Name = "n" });
            Categories.Add(new Category() { Name = "o" });
            Categories.Add(new Category() { Name = "p" });
            Categories.Add(new Category() { Name = "q" });
            Categories.Add(new Category() { Name = "r" });
            Categories.Add(new Category() { Name = "s" });
            Categories.Add(new Category() { Name = "t" });
            Categories.Add(new Category() { Name = "u" });
            Categories.Add(new Category() { Name = "v" });
            Categories.Add(new Category() { Name = "x" });
            Categories.Add(new Category() { Name = "y" });
            Categories.Add(new Category() { Name = "z" });


            this.Author = author;
            User user = author;

            this.Playlists = new List<Playlist>();
            Playlists.Add(new Playlist()
            {
                Title = "Playlist1",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Category = Categories[0],
                Author = user,
                DateCreated = DateTime.Now.AddDays(Rand.Next(-5, 5)),
                Videos = this.Videos,
            });

            Playlists.Add(new Playlist()
            {
                Title = "Playlist2",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Category = Categories[2],
                Author = user,
                DateCreated = DateTime.Now.AddDays(Rand.Next(-5, 5)),

            });

            Playlists.Add(new Playlist()
            {
                Title = "Playlist3",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Category = Categories[3],
                Author = user,
                DateCreated = DateTime.Now.AddDays(Rand.Next(-5, 5)),

            });

            Playlists.Add(new Playlist()
            {
                Title = "Playlist1",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Category = Categories[4],
                Author = Users[0],
                DateCreated = DateTime.Now.AddDays(Rand.Next(-5, 5)),
            });

            Playlists.Add(new Playlist()
            {
                Title = "Playlist5",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Category = Categories[5],
                Author = user,
                DateCreated = DateTime.Now.AddDays(Rand.Next(-5, 5)),
            });

            Playlists.Add(new Playlist()
            {
                Title = "Playlist6",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Category = Categories[6],
                Author = Users[2],
                DateCreated = DateTime.Now.AddDays(Rand.Next(-5, 5)),

            });

            Playlists.Add(new Playlist()
            {
                Title = "Playlist7",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Category = Categories[7],
                Author = user,
                DateCreated = DateTime.Now.AddDays(Rand.Next(-5, 5)),

            });

            Playlists.Add(new Playlist()
            {
                Title = "Playlist8",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Category = Categories[8],
                Author = user,
                DateCreated = DateTime.Now.AddDays(Rand.Next(-5, 5)),

            });

            Playlists.Add(new Playlist()
            {
                Title = "Playlist9",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Category = Categories[3],
                Author = user,
                DateCreated = DateTime.Now.AddDays(Rand.Next(-5, 5)),

            });

            Playlists.Add(new Playlist()
            {
                Title = "Playlist10",

                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Category = Categories[1],
                Author = user,
                DateCreated = DateTime.Now.AddDays(Rand.Next(-5, 5)),
                Videos = this.Videos
            });

            this.Videos = new List<Video>();
            Videos.Add(new Video() { Url = "https://www.youtube.com/watch?v=XMNgfEVk8oo", Playlist=Playlists[0] });
            Videos.Add(new Video() { Url = "https://www.youtube.com/watch?v=KzxOlP68n4M", Playlist = Playlists[0] });
            Videos.Add(new Video() { Url = "https://www.youtube.com/watch?v=SEmq9Lzm5do", Playlist = Playlists[0] });
            Videos.Add(new Video() { Url = "https://www.youtube.com/watch?v=SEmq9Lzm5do", Playlist = Playlists[1] });
            Videos.Add(new Video() { Url = "https://www.youtube.com/watch?v=SEmq9Lzm5do", Playlist = Playlists[1] });
            Videos.Add(new Video() { Url = "https://www.youtube.com/watch?v=SEmq9Lzm5do", Playlist = Playlists[1] });
            Videos.Add(new Video() { Url = "https://www.youtube.com/watch?v=SEmq9Lzm5do", Playlist = Playlists[2] });
            Videos.Add(new Video() { Url = "https://www.youtube.com/watch?v=SEmq9Lzm5do", Playlist = Playlists[2] });
            Videos.Add(new Video() { Url = "https://www.youtube.com/watch?v=SEmq9Lzm5do", Playlist = Playlists[2] });
            Videos.Add(new Video() { Url = "https://www.youtube.com/watch?v=SEmq9Lzm5do", Playlist = Playlists[3] });
            Videos.Add(new Video() { Url = "https://www.youtube.com/watch?v=SEmq9Lzm5do", Playlist = Playlists[3] });
            Videos.Add(new Video() { Url = "https://www.youtube.com/watch?v=SEmq9Lzm5do", Playlist = Playlists[3] });
            Videos.Add(new Video() { Url = "https://www.youtube.com/watch?v=SEmq9Lzm5do", Playlist = Playlists[4] });
            Videos.Add(new Video() { Url = "https://www.youtube.com/watch?v=SEmq9Lzm5do", Playlist = Playlists[4] });
            Videos.Add(new Video() { Url = "https://www.youtube.com/watch?v=SEmq9Lzm5do", Playlist = Playlists[4] });
            Videos.Add(new Video() { Url = "https://www.youtube.com/watch?v=SEmq9Lzm5do", Playlist = Playlists[5] });
            Videos.Add(new Video() { Url = "https://www.youtube.com/watch?v=SEmq9Lzm5do", Playlist = Playlists[5] });
            Videos.Add(new Video() { Url = "https://www.youtube.com/watch?v=SEmq9Lzm5do", Playlist = Playlists[5] });


            this.Ratings = new List<Rating>();
            Ratings.Add(new Rating() { Author = Users[0], Playlist = Playlists[0], Value = Rand.Next(1, 5) });
            Ratings.Add(new Rating() { Author = Users[0], Playlist = Playlists[0], Value = Rand.Next(1, 5) });
            Ratings.Add(new Rating() { Author = Users[0], Playlist = Playlists[0], Value = Rand.Next(1, 5) });
            Ratings.Add(new Rating() { Author = Users[0], Playlist = Playlists[0], Value = Rand.Next(1, 5) });
            Ratings.Add(new Rating() { Author = Users[0], Playlist = Playlists[0], Value = Rand.Next(1, 5) });
            Ratings.Add(new Rating() { Author = Users[2], Playlist = Playlists[1], Value = Rand.Next(1, 5) });
            Ratings.Add(new Rating() { Author = Users[2], Playlist = Playlists[1], Value = Rand.Next(1, 5) });
            Ratings.Add(new Rating() { Author = Users[2], Playlist = Playlists[1], Value = Rand.Next(1, 5) });
            Ratings.Add(new Rating() { Author = Users[1], Playlist = Playlists[1], Value = Rand.Next(1, 5) });
            Ratings.Add(new Rating() { Author = Users[1], Playlist = Playlists[1], Value = Rand.Next(1, 5) });
            Ratings.Add(new Rating() { Author = Users[1], Playlist = Playlists[1], Value = Rand.Next(1, 5) });
            Ratings.Add(new Rating() { Author = Users[0], Playlist = Playlists[1], Value = Rand.Next(1, 5) });
            Ratings.Add(new Rating() { Author = Users[2], Playlist = Playlists[3], Value = Rand.Next(1, 5) });
            Ratings.Add(new Rating() { Author = Users[2], Playlist = Playlists[3], Value = Rand.Next(1, 5) });
            Ratings.Add(new Rating() { Author = Users[1], Playlist = Playlists[3], Value = Rand.Next(1, 5) });
            Ratings.Add(new Rating() { Author = Users[1], Playlist = Playlists[3], Value = Rand.Next(1, 5) });
            Ratings.Add(new Rating() { Author = Users[1], Playlist = Playlists[3], Value = Rand.Next(1, 5) });
        }
    }
}
