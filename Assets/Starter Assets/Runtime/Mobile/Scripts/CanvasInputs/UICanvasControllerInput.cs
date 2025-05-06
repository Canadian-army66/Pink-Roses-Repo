using UnityEngine;

namespace StarterAssets
{
    public class UICanvasControllerInput : MonoBehaviour
    {

        [Header("Output")]
        public PlayerMovement playerMove;

        public void VirtualMoveInput(Vector2 virtualMoveDirection)
        {
            playerMove.MoveInput(virtualMoveDirection);
        }

        public void VirtualJumpInput(bool virtualJumpState)
        {
            playerMove.KickInput(virtualJumpState);
        }
        
    }

}
