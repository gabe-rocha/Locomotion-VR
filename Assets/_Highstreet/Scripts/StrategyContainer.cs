using UnityEngine;

public class StrategyContainer<T> : ScriptableObject where T : LocomotionStrategy {
    public T Strategy { get; set; }
}
