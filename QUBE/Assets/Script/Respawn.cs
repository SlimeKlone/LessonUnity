using UnityEngine;

public class Respawn : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Respawn"))
        {

            transform.position = new Vector3(0, 3.52f, 0);
        }
    }
}
