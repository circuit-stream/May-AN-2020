using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System; // To use Actions
using System.Linq; // To use ToArray()
using UnityEngine.Windows.Speech; //To be able to use Voice Recognition

public class VoiceCommander : MonoBehaviour
{
    public GameObject m_prefabCube;
    public GameObject m_prefabSphere;

    private Dictionary<string, Action> m_keyWordActions = new Dictionary<string, Action>();

    private KeywordRecognizer m_keywordRecognizer;
    
    void Start()
    {
        m_keyWordActions.Add("Hello computer", Speak);
        m_keyWordActions.Add("Spawn box", SpawnCube);
        m_keyWordActions.Add("Spawn cube", SpawnCube);
        m_keyWordActions.Add("Spawn ball", SpawnSphere);
        m_keyWordActions.Add("Spawn sphere", SpawnSphere);

        m_keywordRecognizer = new KeywordRecognizer(m_keyWordActions.Keys.ToArray());
        m_keywordRecognizer.OnPhraseRecognized += OnKeywordRecognized;
        m_keywordRecognizer.Start();
    }

    void OnKeywordRecognized(PhraseRecognizedEventArgs args)
    {
        m_keyWordActions[args.text].Invoke();
    }
    
    void Speak()
    {
        Debug.Log("Hello World!");
    }

    void SpawnSphere()
    {
        Instantiate(m_prefabSphere, transform.position, transform.rotation);
    }
    void SpawnCube()
    {
        Instantiate(m_prefabCube, transform.position, transform.rotation);
    }
}
