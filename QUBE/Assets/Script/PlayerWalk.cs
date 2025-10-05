using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWalk : MonoBehaviour
{
    private Vector2 walk;
    private Vector3 targetVelocity;
    private Rigidbody rb;
    public int speed = 3;
    private bool isGrounded = false;
    private groundDetector GD;
    public GameObject groundDetector;
    private Transform originalParent;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        GD = groundDetector.GetComponent<groundDetector>();
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
            if (GD.isGrounded)
            {
                rb.AddForce(Vector3.up * 300f);
            }
        }
    }

    void WalkOn()
    {
        // Vector3 MoveOn = (walk.x * transform.right + walk.y * transform.forward) * speed;
        // transform.Translate(MoveOn * Time.deltaTime);

        float currentYVelocity = rb.linearVelocity.y;
        targetVelocity = new Vector3(walk.x, 0, 0) * speed;
        targetVelocity.y = currentYVelocity;
        rb.linearVelocity = targetVelocity;

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Booster_Platform") && (targetVelocity.y != 0))
        {
            float currentYVelocity = rb.linearVelocity.y + 10;
            targetVelocity = new Vector3(walk.x, 0, walk.y) * speed;
            targetVelocity.y = currentYVelocity;
            rb.linearVelocity = targetVelocity;

        }

        if (collision.gameObject.CompareTag("Platform"))
        {
            originalParent = transform.parent;
            transform.SetParent(collision.transform, true);
        }


    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            transform.SetParent(originalParent, true);
        }
    }

}