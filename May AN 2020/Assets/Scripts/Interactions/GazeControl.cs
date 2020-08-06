using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GazeControl : MonoBehaviour
{
    public LayerMask m_gazeTargets;
    public Transform m_radialCanvas;
    public Image m_radilBar;
    public float m_timeRequired;
    private float m_timeLoaded;
    

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, 100, m_gazeTargets))
        {
            //m_radialCanvas.position = transform.forward;
            m_radialCanvas.LookAt(transform);

            if (m_timeLoaded < 1)
            {
                m_timeLoaded += Time.deltaTime / m_timeRequired;
                m_radilBar.fillAmount = m_timeLoaded;
            }
            else
            {
                hit.transform.gameObject.SendMessage("Gaze");
                m_timeLoaded = 0;
            }
        }
        else
        {
            m_timeLoaded = 0;
            m_radilBar.fillAmount = m_timeLoaded;
        }



    }
}
