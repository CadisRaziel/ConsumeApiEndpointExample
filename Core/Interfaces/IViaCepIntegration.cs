using Src.Core.Response;

namespace Src.Core.Interfaces
{
    public interface IViaCepIntegration
    {
        Task<ViaCepResponse> GetDataViaCep(string cep);
    }
}
