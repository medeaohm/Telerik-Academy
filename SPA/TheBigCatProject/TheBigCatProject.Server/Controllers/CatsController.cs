namespace TheBigCatProject.Server.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Web.Http;
    using Models;
    using Extensions;

    public class CatsController : ApiController
    {
        private List<CatRequestModel> catsData = new List<CatRequestModel>
        {
            new CatRequestModel
            {
                Id = 1,
                Name = "Pesho",
                Age = 3,
                Breed = CatBreed.Persian,
                Url = "http://favim.com/orig/201108/23/all-star-cat-cute-kitten-pretty-Favim.com-128504.jpg"
            }, 

            new CatRequestModel
            {
                Id = 2,
                Name = "Mimi",
                Age = 13,
                Breed = CatBreed.Street,
                Url = "http://cattowerscondos.com/myimages/PrettyCats003.jpg"
            },
            new CatRequestModel
            {
                Id = 3,
                Name = "Fortuna",
                Age = 1,
                Breed = CatBreed.Street,
                Url = "http://www.aaj.tv/wp-content/uploads/2015/08/bullet_cat1.jpg"
            },
            new CatRequestModel
            {
                Id = 4,
                Name = "Keti",
                Age = 5,
                Breed = CatBreed.Persian,
                Url = "https://i.ytimg.com/vi/UIrEM_9qvZU/maxresdefault.jpg"
            }
        };

        public IHttpActionResult Get([FromUri]CatFilterModel model)
        {
            var result = this.catsData
                .AsQueryable()
                .ToFilteredCats(model)
                .Take(10)
                .ToList();

            return this.Ok(result);
        }

        public IHttpActionResult Post(CatRequestModel model)
        {
            if (model != null)
            {
                model.Id = catsData.Count + 1;
                catsData.Add(model);
            }

            return Ok(model.Id);
        }
    }
}
