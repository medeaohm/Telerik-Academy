using TeleimotBG.Data;
using TeleimotBG.Data.Repositories;

namespace TeleimotBG.Web.Wcf
{
    public class BaseService
    {
        protected BaseService()
        {
            var db = new TeleimotBGDbContext();
            // this.Users = new GenericRepository<User>(db);
        }

        protected IRepository<User> Users
        {
            get; private set;
        }
    }
}