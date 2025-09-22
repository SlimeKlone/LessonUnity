using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWalk : MonoBehaviour
{
    private Vector2 walk;
    private Vector3 targetVelocity;
    private Rigidbody rb;
    public int speed = 3;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        WalkOn();
    }

    public void OnMove(InputValue iv)
    {
        walk = iv.Get<Vector2>();
    }
    public void OnJump(InputValue iv)
    {
        if (iv.isPressed)
        {
            rb.AddForce(Vector3.up * 300f);
        }
    }

    void WalkOn()
    {
        // Vector3 MoveOn = (walk.x * transform.right + walk.y * transform.forward) * speed;
        // transform.Translate(MoveOn * Time.deltaTime);

        float currentYVelocity = rb.linearVelocity.y;
        targetVelocity = new Vector3(walk.x, 0, walk.y) * speed;
        targetVelocity.y = currentYVelocity;
        rb.linearVelocity = targetVelocity;

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Respawn"))
        {

            transform.position = new Vector3(0, 1, 0);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Проверяем тэг объекта (опционально)
        if (collision.gameObject.CompareTag("YourTag") && (targetVelocity.y != 0))
        {
            float currentYVelocity = rb.linearVelocity.y + 10;
            targetVelocity = new Vector3(walk.x, 0, walk.y) * speed;
            targetVelocity.y = currentYVelocity;
            rb.linearVelocity = targetVelocity;

        }
    }

}