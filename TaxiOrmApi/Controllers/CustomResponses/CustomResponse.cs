using Microsoft.AspNetCore.Mvc;

namespace TaxiOrmApi.Controllers.CustomResponses
{
    public static class CustomResponse
    {
        public static ContentResult RegistroNaoEncontrado(string message = "Registro não encontrado.")
        {
            var response = new ContentResult
            {
                StatusCode = StatusCodes.Status404NotFound,
                Content = message
            };

            return response;
        }

        public static ContentResult RegistroJaCadastrado(string message = "Registro já cadastrado.")
        {
            var response = new ContentResult
            {
                StatusCode = StatusCodes.Status409Conflict,
                Content = message
            };
            return response;
        }
    }
}
