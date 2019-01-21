using System;
using System.Collections;
using System.Collections.Generic;
using System.IdentityModel.Claims;
using System.IdentityModel.Policy;
using System.Runtime.Remoting.Messaging;
using System.Security.Principal;

namespace WCFSecurityLibraryWeb
{
    public class AuthorizationPolicy : IAuthorizationPolicy
    {
        public string Id => Guid.NewGuid().ToString();
        public ClaimSet Issuer => ClaimSet.System;

        public bool Evaluate(EvaluationContext evaluationContext, ref object state)
        {
            // This is to be fixed.
            object obj;
            if (evaluationContext.Properties.TryGetValue("identities", out obj))
                return false;

            IList<IIdentity> identities = obj as IList<IIdentity>; 


            if (obj == null || identities.Count == 0)
                return false;

            evaluationContext.Properties["Principal"] = new CustomPrincipal(identities[0]);
            return true;
        }
    }
}