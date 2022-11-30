using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class TransientBlockActivator : MonoBehaviour
    {
        // Needs to know the blocks to activate
        // Needs to know which method to call(TurnTangible, or TurnIntangible)

        // If we had ONE or a FEW blocks, we could do this:
        [SerializeField] private TransientBlock[] transientBlocksToActivate;

        // USING EVENTS IS BETTER
        // Have one class (object) that "announces" an EVENT
        // Have any number of other objects "listening" for that EVENT to be called
        // When those objects hear that event, they RESPOND

        private void Start()
        {
            ActivateTransientBlocks();
        }

        private void ActivateTransientBlocks()
        {
            // access ALL blocks and turn them tangible
            for (int i = 0; i < transientBlocksToActivate.Length; i++)
            {
                transientBlocksToActivate[i].TurnTangible();
            }
        }
    }
}