namespace StudentSystem.Web.Controllers
{
    using System.Web.Http;

    using AutoMapper;
    using AutoMapper.QueryableExtensions;

    using StudentSystem.Data;
    using StudentSystem.Web.Models;

    public class HomeworksController : ApiController
    {
        private IStudentSystemData data;

        public HomeworksController(IStudentSystemData studentSystemData)
        {
            this.data = studentSystemData;
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            return this.Ok(this.data.Homeworks.All().ProjectTo<HomeworkModel>());
        }
    }
}