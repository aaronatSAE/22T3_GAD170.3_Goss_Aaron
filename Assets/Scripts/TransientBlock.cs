using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class TransientBlock : MonoBehaviour
    {
        /*  1. Check what state the block is in
                - If state is tangible, set to intangible
                    - Disable box collider component
                    - Change material to �Intangible� material
                - Else, if state is intangible, set to tangible
                    - Enable box collider component
                    - Change material to �Tangible� material
         */

        [SerializeField] private GameObject block;
        [SerializeField] private Material tangibleMaterial;
        [SerializeField] private Material intangibleMaterial;

        // We don't want the blocks to turn tangible on Start...
        // ...we want them to turn tangible when the SWITCH IS TRIGGERED
        //private void Start()
        //{
        //    TurnIntangible();
        //}

        public void TurnIntangible()
        {
            // If the box collider is enabled...
            if (block.GetComponent<BoxCollider>().enabled == true)
            {
                // ...disable the box collider...
                block.GetComponent<BoxCollider>().enabled = false;

                // ...and change the material to "Intangible"
                block.GetComponent<MeshRenderer>().material = intangibleMaterial;
            }
        }

        public void TurnTangible()
        {
            // If the box collider is disabled...
            if (block.GetComponent<BoxCollider>().enabled == false)
            {
                // ...enable the box collider...
                block.GetComponent<BoxCollider>().enabled = true;

                // ...and change the material to "Tangible"
                block.GetComponent<MeshRenderer>().material = tangibleMaterial;
            }
        }
    }
}
