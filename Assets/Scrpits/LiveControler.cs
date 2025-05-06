using UnityEngine;

namespace StarterAssets
{
    public class LiveControler : MonoBehaviour
    {

        [Header("Output")]
        public Edmovement edMove;
        public Controls control;

        public void VirtualMoveInput(Vector2 virtualMoveDirection)
        {
            control.MoveInput(virtualMoveDirection);
        }

        public void VirtualLookInput(Vector2 virtualLookDirection)
        {
            edMove.LookInput(virtualLookDirection);
        }

        public void VirtualJumpInput(bool virtualJumpState)
        {
            edMove.KickInput(virtualJumpState);
        }

    }

}