﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SpatialTracking;
using UnityEngine.XR;

public class GameManager : MonoBehaviour
{
    void Awake()
    {
        XRDevice.SetTrackingSpaceType(TrackingSpaceType.RoomScale);
    }
}
