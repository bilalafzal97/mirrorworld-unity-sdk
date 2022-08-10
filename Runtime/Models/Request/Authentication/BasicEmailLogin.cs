using Newtonsoft.Json;

namespace mirrorworld_unity_sdk.Runtime.Models.Request.Authentication
{
    public class BasicEmailLogin
    {
        [JsonProperty("email")]
        public string Email;
    
        [JsonProperty("password")]
        public string Password;
    }
}