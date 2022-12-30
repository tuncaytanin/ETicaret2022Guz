using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Eticaret.Core.Dtos.Response
{

    /// <summary>
    /// Servislerdeki ortak yanıt yapısı... 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CustomResponseDto<T>
    {
        // T demek generic. İstedğimiz şekilde bir data olabilir.. 
        public T Data { get; set; }


        [JsonIgnore] // Json formatına döndürdüğümüzde StatusCode çevirmesin..
        public int StatusCode { get; set; }
        public List<string> Errors { get; set; }


        // Factory Design Patter
        public static CustomResponseDto<T> Succes(int StatusCode, T data)
        {

            return new CustomResponseDto<T> { Data = data, StatusCode = StatusCode, Errors = null };
        }
        public static CustomResponseDto<T> Succes(int StatusCode)
        {
            return new CustomResponseDto<T> { StatusCode = StatusCode };
        }

        public static CustomResponseDto<T> Fail(int statusCode, List<string> errors)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, Errors = errors };
        }
        public static CustomResponseDto<T> Fail(int statusCode, string errors)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, Errors = new List<string> { errors } };
        }
    }
}
