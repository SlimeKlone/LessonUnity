using UnityEngine;

public class Respawn : MonoBehaviour
{
    public HP hp;

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Respawn"))
        {

            hp.i += 1;
            hp.UpdateHearts();
            transform.position = new Vector3(0, 3.52f, 0);
        }
    }
}
