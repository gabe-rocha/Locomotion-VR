using UnityEngine;

public class LocomotionController {
    private LocomotionStrategy _currentStrategy;

    public LocomotionController(GroundedMoveStrategy groundedMoveStrategy) {
        _currentStrategy = groundedMoveStrategy;
    }

    public void Move(Vector2 input) {
        _currentStrategy.Move(input);
    }
}