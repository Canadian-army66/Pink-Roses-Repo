using UnityEngine;

namespace StarterAssets
{
    public class UICanvasControllerInput : MonoBehaviour
    {

        [Header("Output")]
        public PlayerMovement playerMove;
        public controls edMove;

        public void VirtualMoveInput(Vector2 virtualMoveDirection)
        {
            playerMove.MoveInput(virtualMoveDirection);
        }

         public void VirtualLookInput(Vector2 virtualLookDirection)
        {
            edMove.LookInput(virtualLookDirection);
        }

        public void VirtualJumpInput(bool virtualJumpState)
        {
            playerMove.KickInput(virtualJumpState);
        }
        
    }

}
