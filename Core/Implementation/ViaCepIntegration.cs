using Src.Core.Interfaces;
using Src.Core.Refit;
using Src.Core.Response;
using System.Threading.Tasks;

namespace Src.Core.Implementation
{
    public class ViaCepIntegration : IViaCepIntegration
    {
        private readonly IViaCepIntegrationRefit _viaCepIntegrationRefit;

        public ViaCepIntegration(IViaCepIntegrationRefit viaCepIntegrationRefit)
        {
            _viaCepIntegrationRefit = viaCepIntegrationRefit;
        }

        public async Task<ViaCepResponse> GetDataViaCep(string cep)
        {
            var responseData = await _viaCepIntegrationRefit.GetDataViaCep(cep);

            if (responseData != null && responseData.IsSuccessStatusCode)
            {
                return responseData.Content;
            }

            return null;
        }
    }
}
