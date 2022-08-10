using System;
using System.Collections;
using mirrorworld_unity_sdk.Runtime.Models.Request.Authentication;
using mirrorworld_unity_sdk.Runtime.Models.Response;
using mirrorworld_unity_sdk.Runtime.Models.Response.Authentication;

namespace mirrorworld_unity_sdk.Runtime.Services.Interfaces
{
    public interface IAuthenticationService
    {
        public IEnumerator LoginWithEmail(BasicEmailLogin requestBody, Action<CommonResponse<LoginResponse>> callBack);
    }
}