using UnityEngine;

public class HP : MonoBehaviour
{
    public int currentHealth = 3; // Текущее количество здоровья
    public int i = 3;

   
    public UnityEngine.UI.Image[] heartImages;
    // Массив спрайтов: [0] - полное сердце, [1] - пустое сердце
    public Sprite[] heartSprites;
    
    public void UpdateHearts()
    {
        if (i < heartImages.Length)
        {

            if ((0 <= i) && (i < currentHealth))
            {
                heartImages[i].sprite = heartSprites[1]; // Полное сердце
                Debug.Log("Пустое");
                
            }
        }
    }

}
