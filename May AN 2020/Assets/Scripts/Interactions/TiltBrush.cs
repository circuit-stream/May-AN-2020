﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltBrush : MonoBehaviour
{
    public GameObject m_prefabTrail;
    public Transform m_spawnPoint;

    private GameObject m_currentTrail;

    private List<GameObject> m_drawnTrails = new List<GameObject>();

    void TriggerDown()
    {
        m_currentTrail = Instantiate(m_prefabTrail, m_spawnPoint.position, m_spawnPoint.rotation, m_spawnPoint);
    }

    void TriggerUp()
    {
        m_currentTrail.transform.SetParent(null);
        m_drawnTrails.Add(m_currentTrail);
    }

    void Released()
    {
        m_currentTrail.transform.SetParent(null);
        m_drawnTrails.Add(m_currentTrail);
    }

    void AltButtonDown()
    {
        if(m_drawnTrails.Count > 0)
        {
            GameObject lineToBeDeleted = m_drawnTrails[m_drawnTrails.Count - 1];
            m_drawnTrails.Remove(lineToBeDeleted);
            Destroy(lineToBeDeleted);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Paint")
        {
            m_prefabTrail.GetComponent<TrailRenderer>().material = collision.collider.GetComponent<Renderer>().material;
        }
    }
}
