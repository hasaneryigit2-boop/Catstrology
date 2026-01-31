using UnityEngine;
using UnityEngine.SceneManagement; // Sahneler arasý geçiþ için gerekli

public class MenuManager : MonoBehaviour
{
    public void OyunaBasla()
    {
        // "TarotDukkani" isimli sahneye geçiþ yapar
        SceneManager.LoadScene("TarotDukkani");
    }

    public void OyundanCik()
    {
        // Oyunu kapatýr (Sadece derlenmiþ oyunda çalýþýr, editörde durdurmaz)
        Application.Quit();
        Debug.Log("Oyundan çýkýldý!");
    }
}