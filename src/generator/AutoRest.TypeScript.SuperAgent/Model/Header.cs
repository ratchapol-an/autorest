using System;

namespace AutoRest.TypeScript.SuperAgent.Model
{
    public class HeaderModel
    {
#if NET451
        public string GeneratedBy => System.Security.Principal.WindowsIdentity.GetCurrent().Name;
#elif NETSTANDARD2_0
        public string GeneratedBy => Environment.UserName;
#endif

        public string GeneratedAt => DateTime.Now.ToString();

        public string GeneratorVersion => "1.0.0";
        public string ApiVersion { get; set; }

// TODO: get this from the version text
    }
}
