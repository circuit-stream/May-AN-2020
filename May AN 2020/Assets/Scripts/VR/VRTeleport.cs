using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRTeleport : MonoBehaviour
{
    public string m_teleportButtonName;
    public Transform m_VRPlayer;
    public LineRenderer m_teleportLine;
    private RaycastHit m_hit;
    private bool m_canTeleport;

    void Update()
    {
        if (Input.GetButton(m_teleportButtonName))
        {
            if (Physics.Raycast(transform.position, transform.forward, out m_hit))
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
        else if (Input.GetButtonUp(m_teleportButtonName))
        {
            m_teleportLine.enabled = false;
            if (m_canTeleport)
            {
                m_VRPlayer.position = m_hit.point;
            }
        }
    }
}