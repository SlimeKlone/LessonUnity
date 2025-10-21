using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float RotationSpeed = 50f;
    public CoinCounter coinCounter;
    public GameObject Boom;
    void Start()
    {
    
}
    void Update()
    {
        transform.Rotate(RotationSpeed * Time.deltaTime, 0, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        
        // Проверяем, что это игрок
        if (other.CompareTag("Player"))
        {
            Instantiate(Boom,  gameObject.transform.position,gameObject.transform.rotation);
            // Уничтожаем текущий объект
            coinCounter.AddCoin();
            Destroy(gameObject);
        }
    }
}
