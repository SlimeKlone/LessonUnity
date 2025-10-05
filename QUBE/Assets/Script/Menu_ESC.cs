using UnityEngine;
using UnityEngine.InputSystem;

public class Menu_ESC : MonoBehaviour
{
    public GameObject targetObject;
    void Update()
    {
        // Проверяем нажатие Esc каждый кадр
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            OnEscapePressed();
        }
    }

    void OnEscapePressed()
    {
        targetObject.SetActive(true);
    }
}
