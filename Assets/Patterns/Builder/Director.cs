
namespace Personal.Patterns.Builder
{
    // The director is only responsible for executing the building steps in a particular sequence. It's helpful when producing products according to a specific order or configuration.
    // Strictly speaking, the director class is optional, since the client can control builders directly.
    public class Director
    {
        public void Build(IBuilder builder)
        {
            builder.BuildStepA("Director string");
            builder.BuildStepB(2);
            builder.BuildStepC(true);
        }
    }
}