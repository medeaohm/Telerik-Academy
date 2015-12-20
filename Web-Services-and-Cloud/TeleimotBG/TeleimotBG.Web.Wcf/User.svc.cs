using System.Collections.Generic;
using System.ServiceModel;
using System.Linq;
using System;
using TeleimotBG.Web.Api.Models;

namespace TeleimotBG.Web.Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "IUsers" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select IUsers.svc or IUsers.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class User : BaseService, IUser
    {
        public IEnumerable<ListedRealEstatesModel> GetAll(string page)
        {
            throw new NotImplementedException();
        }
    }
}
