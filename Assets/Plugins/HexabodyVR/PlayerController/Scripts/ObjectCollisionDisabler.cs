﻿using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace HexabodyVR.PlayerController
{
    public class ObjectCollisionDisabler : MonoBehaviour
    {
        public bool TriggersOnly;
        public bool IncludeTriggers;
        public List<Transform> Transforms = new List<Transform>();

        void Start()
        {
            foreach (var t in Transforms)
            {
                var colliders = t.GetComponentsInChildren<Collider>();

                if (TriggersOnly)
                    colliders = colliders.Where(e => e.isTrigger).ToArray();
                else if (!IncludeTriggers)
                    colliders = colliders.Where(e => !e.isTrigger).ToArray();


                foreach (var other in Transforms.Where(e => e != t))
                {
                    var otherColliders = other.GetComponentsInChildren<Collider>();

                    if (TriggersOnly)
                        otherColliders = otherColliders.Where(e => e.isTrigger).ToArray();
                    else if (!IncludeTriggers)
                        otherColliders = otherColliders.Where(e => !e.isTrigger).ToArray();

                    foreach (var c in colliders)
                    {
                        foreach (var otherCollider in otherColliders)
                        {
                            Physics.IgnoreCollision(c, otherCollider);
                        }
                    }
                }
            }
        }
    }
}
