using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSingleton : MonoBehaviour
{
    public static PlayerSingleton s_instance;
    public Transform m_player;
    // Start is called before the first frame update
    void Awake()
    {
        s_instance = this;
        DontDestroyOnLoad(gameObject);
        m_player = transform;
    }
}
