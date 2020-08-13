using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgrammedLever : MonoBehaviour
{
    public Transform m_start;
    public Transform m_end;
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            Vector3 heading = m_end.position - m_start.position;
            float magnitudeOfHeading = heading.magnitude;
            heading.Normalize();

            Vector3 startToHand = other.transform.position - m_start.position;
            float dotProduct = Vector3.Dot(startToHand, heading);
            dotProduct = Mathf.Clamp(dotProduct, 0, magnitudeOfHeading);

            Vector3 spot = m_start.position + heading * dotProduct;

            transform.position = spot;
        }
    }
}
