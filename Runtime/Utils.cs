using mirrorworld_unity_sdk.Runtime.Models.Response;
using UnityEngine.Networking;

namespace mirrorworld_unity_sdk.Runtime
{
    public static class Utils
    {
        public static CommonResponse<TData> CustomErrorResponse<TData>(long httpStatusCode, string error, string message)
        {
            return new CommonResponse<TData>()
            {
                Data = default(TData),
                Code = 0,
                Status = "fail",
                Message = message,
                Error = error,
                HttpStatusCode = httpStatusCode
        
            };
        }

        public static void SetApiKeyHeader(UnityWebRequest req, string apiKey)
        {
            req.SetRequestHeader("x-api-key", apiKey);
        }
        
        public static void SetAcceptHeader(UnityWebRequest req)
        {
            req.SetRequestHeader("Accept", "application/json");
        }
        
        public static void SetContentTypeHeader(UnityWebRequest req)
        {
            req.SetRequestHeader("Content-Type", "application/json");
        }
    }
}