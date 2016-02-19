namespace LostPets.Web.ViewModels.Posts
{
    using System.Collections.Generic;

    public class PageableListPostViewModel
    {
        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }

        public IEnumerable<PostViewModel> Posts { get; set; }
    }
}
