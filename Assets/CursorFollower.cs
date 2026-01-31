using UnityEngine;

public class CursorFollower : MonoBehaviour
{
    void Awake()
    {
        // Start yerine Awake kullanarak en baþta çalýþmasýný saðlýyoruz
        SetCursorState();
    }

    void OnApplicationFocus(bool hasFocus)
    {
        // Uygulamaya geri dönüldüðünde (Alt-Tab vs) imleci tekrar gizle
        if (hasFocus)
        {
            SetCursorState();
        }
    }

    void SetCursorState()
    {
        Cursor.visible = false;
        // Ýmleci oyun penceresine hapseder (isteðe baðlý)
        Cursor.lockState = CursorLockMode.Confined;
    }

    void Update()
    {
        transform.position = Input.mousePosition;
    }
}