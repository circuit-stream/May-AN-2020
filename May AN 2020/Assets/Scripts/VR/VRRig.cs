using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VRRig : MonoBehaviour
{

    public void SwitchToRoomScale()
    {
        XRDevice.SetTrackingSpaceType(TrackingSpaceType.RoomScale);
    }

    public void SwitchToStationary()
    {
        XRDevice.SetTrackingSpaceType(TrackingSpaceType.Stationary);
    }
}
