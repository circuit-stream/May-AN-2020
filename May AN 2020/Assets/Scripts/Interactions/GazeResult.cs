using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeResult : MonoBehaviour
{
    // Start is called before the first frame update
    void Gaze()
    {
        GetComponent<Rigidbody>().AddExplosionForce(500, transform.position, 5);
    }
}
