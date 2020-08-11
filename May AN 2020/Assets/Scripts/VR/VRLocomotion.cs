using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VRLocomotion : MonoBehaviour
{
    public string m_horizontalAxis;
    public string m_verticalAxis;

    public Transform m_VRRig;
    public Transform m_director;

    public Transform m_VRHead;
    public LayerMask m_notPlayerLayer;

    public AudioSource m_as;
    public AudioClip m_walkingStep;
    public AudioClip m_joggingStep;
    public float m_deltaMovement;
    
    // Update is called once per frame
    void Update()
    {
        Vector2 touchPosition;

        touchPosition.x = Input.GetAxis(m_horizontalAxis);
        touchPosition.y = Input.GetAxis(m_verticalAxis);

        m_deltaMovement += Mathf.Abs(touchPosition.x) + Mathf.Abs(touchPosition.y);
        if (m_deltaMovement > 90)
        {
            m_deltaMovement = 0;

            m_as.Play();
        }

        Vector3 playerForward = m_director.forward * touchPosition.y;
        Vector3 playerRight = m_director.right * touchPosition.x;

        playerForward.y = 0;
        playerRight.y = 0;

        m_VRRig.position += playerForward * Time.deltaTime;
        m_VRRig.position += playerRight * Time.deltaTime;

        m_VRRig.position = new Vector3(m_VRRig.position.x, GetHeight() ,m_VRRig.position.z) ;
    }

    float GetHeight()
    {
        RaycastHit hit;
        if(Physics.Raycast(m_VRHead.position, Vector3.down, out hit, 100, m_notPlayerLayer))
        {
            return hit.point.y;
        }
        return m_VRRig.position.y;
    }
}
