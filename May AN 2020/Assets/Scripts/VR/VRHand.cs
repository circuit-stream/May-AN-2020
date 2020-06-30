using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRHand : MonoBehaviour
{
    public string m_gripName;
    private bool m_gripHeld;

    public Animator m_anim;
    private GameObject m_touchingObject;
    private GameObject m_heldObject;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Interactable")
        {
            m_touchingObject = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        m_touchingObject = null;
    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Mouse1))
        if (Input.GetAxis(m_gripName) > 0.5f && m_gripHeld == false)
        {
            m_gripHeld = true;

            m_anim.SetBool("isGrabbing", true);
            if (m_touchingObject)
            {
                Grab();
            }
        }
        else if (Input.GetAxis(m_gripName) < 0.5f && m_gripHeld == true)
        {
            m_gripHeld = false;

            m_anim.SetBool("isGrabbing", false);
            if (m_heldObject)
            {
                Release();
            }
        }
    }

    void Grab()
    {
        m_heldObject = m_touchingObject;
        m_heldObject.GetComponent<Rigidbody>().isKinematic = true;
        m_heldObject.transform.SetParent(transform);
    }

    void Release()
    {
        m_heldObject.GetComponent<Rigidbody>().isKinematic = false;
        m_heldObject.transform.SetParent(null);
        m_heldObject = null;
    }
}