using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
namespace Strings
{
    using System.ServiceModel;

    [ServiceContract]
    public interface IStringsService
    {
        [OperationContract]
        int CountHowManyTimesIsContained(string text, string textToSearch);
    }
}
