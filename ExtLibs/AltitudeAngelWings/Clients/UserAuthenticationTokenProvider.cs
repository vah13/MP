using System;
using System.Collections.Specialized;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using AltitudeAngelWings.Clients.Auth;
using AltitudeAngelWings.Clients.Auth.Model;
using AltitudeAngelWings.Model;
using AltitudeAngelWings.Service;
using AltitudeAngelWings.Service.Messaging;

namespace AltitudeAngelWings.Clients
{
    public class UserAuthenticationTokenProvider : ITokenProvider
    {
        private readonly ISettings _settings;
        private readonly IAuthClient _authClient;
        private readonly Lazy<IAltitudeAngelService> _service;
        private readonly IAuthorizeCodeProvider _provider;
        private readonly IMessagesService _messagesService;
        private readonly SemaphoreSlim _lock = new SemaphoreSlim(1);

        public UserAuthenticationTokenProvider(ISettings settings, IAuthClient authClient, Lazy<IAltitudeAngelService> service, IAuthorizeCodeProvider provider, IMessagesService messagesService)
        {
            _settings = settings;
            _authClient = authClient;
            _service = service;
            _provider = provider;
            _messagesService = messagesService;
        }

    }
}