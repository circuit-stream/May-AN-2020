﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject m_prefabFireball;
    public float m_shootForce;
    public DisplayShotCounter m_DSCScript;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject fireball;
            fireball = Instantiate(m_prefabFireball, transform.position, transform.rotation);
            fireball.GetComponent<Rigidbody>().AddForce(transform.forward * m_shootForce);
            Destroy(fireball, 5f);
            m_DSCScript.m_shotCount++;
            m_DSCScript.UpdateDisplay();
        }
    }
}
