using lib12.DependencyInjection;

namespace lib12.Test.DependencyInjectionTest.Classes
{
    [Singleton]
    public class InjectInCtor2Ctors
    {
        public InjectInCtor2Ctors()
        {

        }

        public InjectInCtor2Ctors(SingletonClass basicClass)
        {

        }
    }
}