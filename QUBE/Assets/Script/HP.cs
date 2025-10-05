using UnityEngine;

public class HP : MonoBehaviour
{
    public int maxHealth = 3; // Максимальное количество здоровья
    public int currentHealth; // Текущее количество здоровья
    public int i = -1;

    // Массив изображений сердечек на канвасе
    public UnityEngine.UI.Image[] heartImages;
    // Массив спрайтов: [0] - полное сердце, [1] - пустое сердце
    public Sprite[] heartSprites;
    
    public void UpdateHearts()
    {
        if (i < heartImages.Length)
        {
            // Если индекс текущего сердца МЕНЬШЕ текущего здоровья, оно должно быть полным.
            if (i < currentHealth)
            {
                heartImages[i].sprite = heartSprites[0]; // Полное сердце
            }
            else
            {
                heartImages[i].sprite = heartSprites[1]; // Пустое сердце
            }
        }
    }

}
