using Refit;
using Src.Core.Response;

namespace Src.Core.Refit
{
    public interface IViaCepIntegrationRefit
    {
        //ViaCepResponse -> minha resposta ao refit
        //ApiResponse -> response da lib refit
        [Get("/ws/{cep}/json/")] // -> notation do refit, nao passo a url inteira pois eu configuro ela no program.cs e coloquei uma variavel {cep}
        Task<ApiResponse<ViaCepResponse>> GetDataViaCep(string cep);
    }
}
