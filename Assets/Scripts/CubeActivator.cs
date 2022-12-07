using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class CubeActivator : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            // If the player presses E...
            if (Input.GetKeyDown(KeyCode.E))
            {
                // ...announce the events for those tricky little cubes!
                EventsManager.OnChangeColourEvent?.Invoke();
                EventsManager.OnTeleportEvent?.Invoke();
                Debug.Log("E has been pressed!");
            }
        }
    }
}
