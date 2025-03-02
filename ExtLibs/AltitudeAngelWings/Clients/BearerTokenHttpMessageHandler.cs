using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace AltitudeAngelWings.Clients
{
    public class BearerTokenHttpMessageHandler : DelegatingHandler
    {
        private const string BearerScheme = "Bearer";

        private readonly ITokenProvider _tokenProvider;

        public BearerTokenHttpMessageHandler(ITokenProvider tokenProvider)
        {
            _tokenProvider = tokenProvider;
        }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            var accessToken = "111";
            if (!string.IsNullOrEmpty(accessToken))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue(BearerScheme, accessToken);
            }
            return await base.SendAsync(request, cancellationToken);
        }
    }
}