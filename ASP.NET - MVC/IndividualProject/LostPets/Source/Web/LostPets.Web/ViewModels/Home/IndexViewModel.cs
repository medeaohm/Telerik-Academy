namespace LostPets.Web.ViewModels.Home
{
    using System.Collections.Generic;

    public class IndexViewModel
    {
        public IEnumerable<PostViewModel> Posts
        { get; set; }
    }
}
