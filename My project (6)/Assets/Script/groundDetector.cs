using UnityEngine;

public class groundDetector : MonoBehaviour
{
    public bool isGrounded = false;
    
    // Вызывается при входе в триггер
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            isGrounded = true;
        }
    }

    // Вызывается при выходе из триггера
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            isGrounded = false;
        }
    }
}
