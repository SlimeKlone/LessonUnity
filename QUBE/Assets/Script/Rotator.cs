using UnityEngine;
using UnityEngine.UI;

public class Rotator : MonoBehaviour
{
    public float RotationSpeed = 50f;
    public CoinCounter coinCounter;

    void Update()
    {
        transform.Rotate(RotationSpeed * Time.deltaTime, 0, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        // Проверяем, что это игрок
        if (other.CompareTag("Player"))
        {
            // Уничтожаем текущий объект
            coinCounter.AddCoin();
            Destroy(gameObject);
        }
    }
}
