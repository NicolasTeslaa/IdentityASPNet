using Identity.API.ViewModels;

namespace Identity.API.Utilites;


// classes staticas não precisam ser instanciadas
public static class Responses
{
    public static ResultViewModel ApplicationErrorMessage()
    {
        return new ResultViewModel
        {
            Message = "Ocorreu algum erro interno na aplicação, tente novamente",
            Sucess = false,
            Data = null
        };
    }
    public static ResultViewModel DomainErrorMessage(string message)
    {
        return new ResultViewModel
        {
            Message = message,
            Sucess = false,
            Data = null
        };
    }

    public static ResultViewModel DomainErrorMessage(string message, IReadOnlyCollection<string> errors)
    {
        return new ResultViewModel
        {
            Message = message,
            Sucess = false,
            Data = errors
        };
    }

        public static ResultViewModel UnauthorizedErrorMessage()
    {
        return new ResultViewModel
        {
            Message = "Login ou Senha Incorretos",
            Sucess = false,
            Data = null
        };
    }
}