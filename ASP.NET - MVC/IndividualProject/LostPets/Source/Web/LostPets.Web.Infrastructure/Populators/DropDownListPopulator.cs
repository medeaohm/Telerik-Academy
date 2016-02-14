//namespace LostPets.Web.Infrastructure.Populators
//{
//    using Data.Common.Repositories;
//    using Data.Models;
//    using Services.Web;
//    using System.Collections.Generic;
//    using System.Linq;
//    using System.Web.Mvc;

//    public class DropDownListPopulator
//    {
//        private readonly IIdentifierProvider identifierProvider;
//        private IDeletableEntityRepository<Post> posts;
//        private ICacheService cache;

//        public DropDownListPopulator(IDeletableEntityRepository<Post> posts, ICacheService cache)
//        {
//            this.posts = posts;
//            this.cache = cache;
//        }

//        public IEnumerable<SelectListItem> GetCities()
//        {
//            var cities = this.cache.Get<IEnumerable<SelectListItem>>("cities",
//                () => {
//                    return this.posts
//                       .All()
//                       .Select(c => new SelectListItem {
//                           Value = c.Id.ToString(),
//                           Text = c.Name
//                       })
//                       .ToList();
//                });

//            return categories;
//        }
//    }
//}