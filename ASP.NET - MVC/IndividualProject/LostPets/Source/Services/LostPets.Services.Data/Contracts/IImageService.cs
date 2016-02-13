namespace LostPets.Services.Data
{
    using LostPets.Data.Models;

    public interface IImageService
    {
        Image GetById(int id);
    }
}