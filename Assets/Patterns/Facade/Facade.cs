using UnityEngine;

namespace Personal.Patterns.Facade
{
    public class Facade : IFacade
    {
        private readonly Service _service;

        public Facade(Service service)
        {
            _service = service;
        }

        public void MethodA()
        {
            _service.MethodA();
        }
    }
}