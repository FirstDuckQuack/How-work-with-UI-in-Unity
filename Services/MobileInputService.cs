using UnityEngine;

namespace CodeBase.Services
{
    class MobileInputService : InputService
    {
        public override Vector2 axis => 
            SimpleInputAxis();
    }
}