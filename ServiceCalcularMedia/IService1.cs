using ServiceCalcularMedia.DataContract;
using System;

using System.Collections.Generic;

using System.Linq;

using System.Runtime.Serialization;

using System.ServiceModel;

using System.ServiceModel.Web;

using System.Text;

namespace ServiceCalcularMedia
{

    [ServiceContract]
    public interface IService1
    {
        [OperationContract]

        //Faz o request do método CalcularMedia

        MediaResponse CalcularMedia(MediaRequest request);
    }
}
