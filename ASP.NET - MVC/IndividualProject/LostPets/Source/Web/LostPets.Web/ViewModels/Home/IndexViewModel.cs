namespace LostPets.Web.ViewModels.Home
{
    using System.Collections.Generic;

    using Posts;

    public class IndexViewModel
    {
        public IEnumerable<PostViewModel> Posts
        { get; set; }
    }
}
