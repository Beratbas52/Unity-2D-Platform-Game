using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkorTablosu : MonoBehaviour
{
    public Text skorText; // Unity Editörü'nde UI Text elemanýný baðlayýn.
    public int skor = 0;
    public float skorhizi;// Skorun artma hýzý.

    private void Start()
    {
        StartCoroutine(skorArtisi());
        // belli zamanlar belli iþlemler
    }
    
    IEnumerator skorArtisi()
    {
        while (true)
        {
            yield return new WaitForSeconds(skorhizi);
            skor++;
            skorText.text = skor.ToString();
        }
    }

 
}