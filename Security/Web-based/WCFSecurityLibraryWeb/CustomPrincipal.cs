using System.Security.Principal;

namespace WCFSecurityLibraryWeb
{
    public class CustomPrincipal : IPrincipal
    {
        public CustomPrincipal(IIdentity identity)
        {
            Identity = identity;
        }

        public bool IsInRole(string role)
        {
            // custom logic here.
            return Identity.Name.Equals("test") && role.Equals("Admin");
        }

        public IIdentity Identity { get; }
    }
}