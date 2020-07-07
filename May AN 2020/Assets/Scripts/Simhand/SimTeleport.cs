using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimTeleport : MonoBehaviour
{
    public LayerMask m_teleportableLayer;
    public LineRenderer m_teleportLine;
    private RaycastHit m_hit;
    private bool m_canTeleport;

    void Update()
    {
        if(Input.GetKey(KeyCode.T))
        {
            if(Physics.Raycast(transform.position, transform.forward, out m_hit, Mathf.Infinity, m_teleportableLayer))
            {
                m_teleportLine.SetPosition(0, transform.position);
                m_teleportLine.SetPosition(1, m_hit.point);
                m_teleportLine.enabled = true;
                m_canTeleport = true;
            }
            else
            {
                m_teleportLine.enabled = false;
                m_canTeleport = false;
            }
        }
        else if(Input.GetKeyUp(KeyCode.T))
        {
            m_teleportLine.enabled = false;
            if(m_canTeleport)
            {
                transform.position = m_hit.point;
            }
        }
    }
}
