using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tail.Api.Models
{
    internal class JwtClaimModel
    {
        private string _iss = "http://idssite.com";

        public double exp { get; set; }//expiration time

        public double nbf { get; set; }//not before

        public double iat { get; set; }//issued at

        public string iss => _iss;//issuer

        public string usr { get; set; }//UserName

        public string sub => "IDSApp";

        public long accid { get; set; }//Account Id

        public string accname { get; set; }//Account Name
    }
}