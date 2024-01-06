using UnityEngine;

public class sabit : MonoBehaviour
{
    public Transform sabitKonum; // Düðmenin sabit konumu

    void Update()
    {
        if (sabitKonum != null)
        {
            // Düðmenin konumunu sabit konuma ayarla
            transform.position = sabitKonum.position;
        }
    }
}
