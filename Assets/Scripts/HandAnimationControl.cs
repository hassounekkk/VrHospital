using UnityEngine;
using UnityEngine.InputSystem;


public class HandAnimationControl : MonoBehaviour
{
    [SerializeField] Animator HandAnimator;
    [SerializeField] InputActionReference gripAction;
    [SerializeField] InputActionReference pinchAction;

    private void OnEnable()
    {
        gripAction.action.performed += GripAnimation;
        pinchAction.action.performed += PinchAnimation;
    }

    private void PinchAnimation(InputAction.CallbackContext obj)
    {
        HandAnimator.SetFloat("Trigger", obj.ReadValue<float>());
    }

    private void GripAnimation(InputAction.CallbackContext obj)
    {
        HandAnimator.SetFloat("Grip", obj.ReadValue<float>());
    }
}
