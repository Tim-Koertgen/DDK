using System;
namespace DDK.Helper
{
    public class AssemblyHelper
    {
        public AssemblyHelper()
        {
        }

        public string GetAssemblyVersion()
        {
            return GetType().Assembly.GetName().Version.ToString();
        }
    }
}
