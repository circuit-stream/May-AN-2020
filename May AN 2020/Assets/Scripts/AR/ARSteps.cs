using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARSteps : MonoBehaviour
{
    public GameObject m_mainMenu;
    public List<GameObject> m_steps = new List<GameObject>();

    private int m_currentStep;

    public void NextStep()
    {
        if (m_currentStep < m_steps.Count - 1)
        {
            m_steps[m_currentStep].SetActive(false);
            m_currentStep++;
            m_steps[m_currentStep].SetActive(true);
        }
        else
        {
            m_steps[m_currentStep].SetActive(false);
            m_currentStep = 0;
            m_steps[m_currentStep].SetActive(true);

            m_mainMenu.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
