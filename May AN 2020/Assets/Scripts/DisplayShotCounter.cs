using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayShotCounter : MonoBehaviour
{
    public int m_shotCount;

    public Text m_shotsFiredDisplay;

    public void UpdateDisplay()
    {
        m_shotsFiredDisplay.text = "Shots Fired: " + m_shotCount;
    }
}
