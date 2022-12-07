using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class EventsManager
    {
        // This will contain ALL OF OUR EVENTS

        // Event delegates have TWO PARTS
        // the DELEGATE which is the "type of event"
        // the EVENT itself, which gets "announced"

        // This is the TYPE of event we will call
        public delegate void VoidDelegate();

        // This is the EVENT itself
        public static VoidDelegate OnTeleportEvent;
        public static VoidDelegate OnChangeColourEvent;
        public static VoidDelegate OnTransientBlockButtonPressEvent;
    }
}
