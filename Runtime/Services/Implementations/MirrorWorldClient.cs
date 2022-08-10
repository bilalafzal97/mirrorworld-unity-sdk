using System.Reflection.Emit;
using mirrorworld_unity_sdk.Runtime.Services.Interfaces;

namespace mirrorworld_unity_sdk.Runtime.Services.Implementations
{
    public class MirrorWorldClient : IMirrorWorldClient
    {
        private readonly Environment _environment;

        private readonly EnvironmentVersion _environmentVersion;

        private readonly string _baseUrlWithVersion;

        private readonly string _apiKey;
        
        private IAuthenticationService _authentication;
        
        public MirrorWorldClient(Environment environment, EnvironmentVersion environmentVersion, string apiKey)
        {
            _environment = environment;
            _environmentVersion = environmentVersion;
            _apiKey = apiKey;

            string baseUrl;

            baseUrl = environment == Environment.Staging ? Constant.StagingV1ApiBaseUrl : Constant.ProductionV1ApiBaseUrl;

            _baseUrlWithVersion = baseUrl + "v1/";

        }

        public IAuthenticationService Authentication
        {
            get { return _authentication ??= new AuthenticationService(_environment, _environmentVersion, _apiKey); }
        }
    }
}