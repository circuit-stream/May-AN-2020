using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    AudioSource m_as;
    public Text m_myText;
    // Start is called before the first frame update
    void Start()
    {
        m_myText.text = "Hi\nhello";
    }

    // Update is called once per frame
    void Update()
    {
        m_as.volume = 0.2f;
    }
}
