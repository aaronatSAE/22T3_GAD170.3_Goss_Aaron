using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class Brambles : MonoBehaviour
    {
        [SerializeField] private int hitDamage;

        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("BRAMBLES HAVE BEEN COLLIDED WITH");

            // We could...
            // - Reload the scene... but we can fix this later on.
        }
    }
}
