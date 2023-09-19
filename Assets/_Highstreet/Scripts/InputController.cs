using HexabodyVR.PlayerController;
using UnityEngine;

public class InputController : MonoBehaviour {

    [SerializeField] private HexaXRInputs LeftController;
    [SerializeField] private HexaXRInputs RightController;
    
    private LocomotionController _locomotionController;

    private void Start() {
        _locomotionController = new LocomotionController(new GroundedMoveStrategy());
    }

    public void Update() {
        _locomotionController.Move(LeftController.JoystickAxis);
    }
}