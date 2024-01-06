using UnityEngine;

public class AkiciYEksenindeHareketEdenKamera : MonoBehaviour
{
    public Transform takipEdilen; // Kameranýn takip edeceði nesne (oyuncu genellikle)
    public float yumusatmaHizi = 1f;
    public float takipHizi = 2f; // Takip hýzý, belirli bir hýzda hareket eden nesneleri takip etmek için

    void Update()
    {
        if (takipEdilen != null)
        {
            // Kameranýn y ekseni üzerinde takip edilen nesnenin pozisyonunu al
            float oyuncuY = takipEdilen.position.y;

            // Hesaplanan hýzla Lerp kullanarak kameranýn yeni pozisyonunu güncelle
            float yeniY = Mathf.Lerp(transform.position.y, oyuncuY, yumusatmaHizi * Time.deltaTime * takipHizi);
            transform.position = new Vector3(transform.position.x, yeniY, transform.position.z);
        }
    }
}