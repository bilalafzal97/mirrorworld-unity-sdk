using Newtonsoft.Json;

namespace mirrorworld_unity_sdk.Runtime.Models.Request.Authentication
{
    public class LoginWithGoogleRequest
    {
        [JsonProperty("identity_provider_token")]
        public string IdentityProviderToken;
    }
}