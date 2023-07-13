namespace Delegatesv2_0506
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var policyService = new PolicyService();

            policyService.SendEmail();
        }
    }
}