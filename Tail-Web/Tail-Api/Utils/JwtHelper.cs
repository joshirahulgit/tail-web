using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tail.Api.Utils
{
    //internal static class JwtHelper
    //{

    //    internal static string CreateLoginJwt(string userName, long accountId, string accountName)
    //    {
    //        IDateTimeProvider provider = new UtcDateTimeProvider();
    //        var now = provider.GetNow();
    //        var unixEpoch = JwtValidator.UnixEpoch;
    //        var issued = Math.Round((now - unixEpoch).TotalSeconds);
    //        var expired = Math.Round((now.AddDays(1)-unixEpoch).TotalSeconds);
    //        JwtClaimModel jwtClaimModel = new JwtClaimModel()
    //        {
    //            usr = userName,
    //            accid = accountId,
    //            accname = accountName,
    //            iat = issued,
    //            nbf = issued,
    //            exp = expired
    //        };
    //        //string json = JsonConvert.SerializeObject(jwtClaimModel, Formatting.None);

    //        var payload = jwtClaimModel;
    //        var secret = GlobalContext.ApplicationSetting.TokenSecret;

    //        IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
    //        IJsonSerializer serializer = new JsonNetSerializer();
    //        IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
    //        IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);

    //        var token = encoder.Encode(payload, secret);
    //        return token;
    //    }

    //    internal static JwtClaimModel GetJwtClaimModel(string token)
    //    {
    //        var secret = GlobalContext.ApplicationSetting.TokenSecret;
    //        try
    //        {
    //            IJsonSerializer serializer = new JsonNetSerializer();
    //            IDateTimeProvider provider = new UtcDateTimeProvider();
    //            IJwtValidator validator = new JwtValidator(serializer, provider);
    //            IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
    //            IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder);

    //            var jwtClaim = decoder.DecodeToObject<JwtClaimModel>(token, secret, verify: true);

    //            return jwtClaim;
    //        }
    //        catch (TokenExpiredException tEx)
    //        {
    //            return null;
    //        }
    //        catch (SignatureVerificationException sEx)
    //        {
    //            //Good to log signature voilation
    //            return null;
    //        }
    //    }

    //}
}