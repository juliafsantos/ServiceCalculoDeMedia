using System;

using System.Collections.Generic;

using System.Linq;

using System.Runtime.Serialization;

using System.ServiceModel;

using System.ServiceModel.Web;

using System.Text;

namespace ServiceCalcularMedia
{

    public class Service1 : IService1
    {
        /* Método que realiza o cálculo e retorna o resultado e a média */

        public DataContract.MediaResponse CalcularMedia(DataContract.MediaRequest request)

        {
            //Estancia um novo objeto

            DataContract.MediaResponse response = new DataContract.MediaResponse();


            //Define o resultado como reprovado
            response.Resultado = "Reprovado";

            //Calcula a média
            Double media = (request.Nota1 + request.Nota2) / 2;


            // Se a media for maior que 7 retorna como aprovado
            if (media > 7)

                response.Resultado = "Aprovado";


            //Retorna a media da notas 
            response.Media = media;



            return response;

        }

    }
}

