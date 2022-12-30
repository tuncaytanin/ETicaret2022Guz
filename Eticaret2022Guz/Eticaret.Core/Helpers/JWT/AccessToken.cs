using System;

namespace Eticaret.Core.Helpers.JWT
{
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime Expration { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
    }
}
