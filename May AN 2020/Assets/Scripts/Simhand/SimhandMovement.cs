using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimhandMovement : MonoBehaviour
{
    public Transform m_hand;
    public float m_moveSpeed;
    public bool m_isLocked;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        m_isLocked = true;
    }

    // Update is called once per frame
    void Update()
    {
        #region Cursor Lockstate Toggle
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            if (m_isLocked)
            {
                Cursor.lockState = CursorLockMode.None;
                m_isLocked = false;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                m_isLocked = true;
            }
        }
        #endregion


        if (Input.GetKey(KeyCode.W))
        {
            m_hand.Translate(Vector3.forward * Time.deltaTime * m_moveSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            m_hand.Translate(Vector3.back * Time.deltaTime * m_moveSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            m_hand.Translate(Vector3.left * Time.deltaTime * m_moveSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            m_hand.Translate(Vector3.right * Time.deltaTime * m_moveSpeed);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            m_hand.Translate(Vector3.up * Time.deltaTime * m_moveSpeed);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            m_hand.Translate(Vector3.down * Time.deltaTime * m_moveSpeed);
        }

        m_hand.Rotate(Input.GetAxis("Mouse X") * Vector3.up, Space.World);
        m_hand.Rotate(Input.GetAxis("Mouse Y") * Vector3.left);
    }
}