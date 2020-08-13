using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRPhysicsRig : MonoBehaviour
{
    public SphereCollider m_vrRigCollider;
    public Transform m_vrHead;

    void Update()
    {
        m_vrRigCollider.center = new Vector3(m_vrHead.localPosition.x, 0.2f, m_vrHead.localPosition.z);
    }
}
