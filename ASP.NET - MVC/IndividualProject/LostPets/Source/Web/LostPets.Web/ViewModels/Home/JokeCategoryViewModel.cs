namespace LostPets.Web.ViewModels.Home
{
    using LostPets.Data.Models;
    using LostPets.Web.Infrastructure.Mapping;

    public class JokeCategoryViewModel : IMapFrom<JokeCategory>
    {
        public int Id
        { get; set; }

        public string Name
        { get; set; }
    }
}
