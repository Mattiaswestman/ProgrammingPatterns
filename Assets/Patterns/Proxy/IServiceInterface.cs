
namespace Personal.Patterns.Proxy
{
    // The Service Interface declares the interface of the Service. The proxy must follow this interface to be able to disguise itself as a service object.
    public interface IServiceInterface
    {
        public void PrintLog();
    }
}