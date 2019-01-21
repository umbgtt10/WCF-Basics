using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFSecurityLibraryWeb
{
    public class CustomUserNamePasswordValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (!userName.Equals("test") || !password.Equals("test"))
            {
                throw new SecurityTokenException("Action Denied");
            }
        }
    }
}
