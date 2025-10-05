using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float Speed = 0.1f;
    public float Distance = 100f;
    private Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Движение вперед-назад по синусоиде
        float movement = Mathf.Sin(Time.time * Speed) * Distance;
        transform.position = startPosition + new Vector3(movement, 0, 0);
    }
}
