using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using TeleimotBG.Web.Api.Models;

namespace TeleimotBG.Web.Wcf
{
    public interface IUser
    {
        [OperationContract]
        [WebInvoke(Method = "Get", UriTemplate = "services/estates.svc")]

        /* Sorry for this -  I do no havre User Moodel*/
        IEnumerable<ListedRealEstatesModel> GetAll(string page);
    } 
}
