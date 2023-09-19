using System;
using UnityEngine;

public class GroundedMoveStrategy : LocomotionStrategy
{
    public override void Move(Vector2 input) {
        Console.WriteLine("Moving...");
    }
}
