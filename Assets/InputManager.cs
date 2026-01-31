using UnityEngine;
using TMPro; // TextMeshPro kullanmak için þart
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{
    public TMP_InputField isimAlani;
    public TMP_InputField tarihAlani; 

    public void BilgileriKaydetVeBasla()
    {
        // Kutulara yazýlanlarý hafýzaya alýyoruz
        PlayerData.OyuncuIsmi = isimAlani.text;
        PlayerData.DogumTarihi = tarihAlani.text;

        Debug.Log("Kaydedildi: " + PlayerData.OyuncuIsmi + " - " + PlayerData.DogumTarihi);

        // Fal bakma sahnesine geç (Sahne adýnýn doðru olduðundan emin ol)
        SceneManager.LoadScene("KisiselFalSahnesi");
    }
}