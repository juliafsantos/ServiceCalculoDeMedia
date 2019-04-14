using System;

using System.Collections.Generic;

using System.Linq;

using System.Web;

using System.Runtime.Serialization;

namespace ServiceCalcularMedia.DataContract
{
    /* Retorna os valores da média e o resultado para o aplicativo */

    [DataContract]
    public class MediaResponse
    {
        private Double media;

        private String resultado;



        [DataMember]

        public Double Media

        {

            get { return media; }

            set { media = value; }

        }



        [DataMember]

        public String Resultado

        {

            get { return resultado; }

            set { resultado = value; }

        }

    }
}
