using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitGun : MonoBehaviour
{
    public GameObject m_prefabBit;
    public Transform m_bitSpawn;
    public float shootForce = 500;
    // Start is called before the first frame update
    void TriggerDown()
    {
        GameObject bit = Instantiate(m_prefabBit, m_bitSpawn.position, m_bitSpawn.rotation);
        bit.GetComponent<Rigidbody>().AddForce(bit.transform.forward * shootForce);
        Destroy(bit, 5);
    }
}
