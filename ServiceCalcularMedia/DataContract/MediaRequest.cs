using System;

using System.Collections.Generic;

using System.Linq;

using System.Web;

using System.Runtime.Serialization;

namespace ServiceCalcularMedia.DataContract
{

    /* Recebe os valores da Nota1 e Nota2 do aplicativo */

    [DataContract]
    public class MediaRequest
    {
            private Double nota1;

            private Double nota2;

            [DataMember]

            public Double Nota1

            {
                get { return nota1; }
                set { nota1 = value; }
            }

            [DataMember]

            public Double Nota2

            {
                get { return nota2; }
                set { nota2 = value; }
            }



        }
    }
