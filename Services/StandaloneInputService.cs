using UnityEngine;

namespace CodeBase.Services
{
    public class StandaloneInputService : InputService
    {

        public override Vector2 axis
        {
            get
            {
                Vector2 axis = SimpleInputAxis();

                if (axis.sqrMagnitude == 0f)
                {
                    axis = UnityAxis();
                }
                return axis;
            }
        }

        private static Vector2 UnityAxis() =>
            new Vector2(UnityEngine.Input.GetAxis(Horizontal), SimpleInput.GetAxis(Vertical));
    }
}