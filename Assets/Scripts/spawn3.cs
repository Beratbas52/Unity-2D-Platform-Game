using UnityEngine;
using UnityEngine.Tilemaps;

public class RandomGameObjectSpawner : MonoBehaviour
{
    public Tilemap tilemap;
    public GameObject[] randomObjects;
    public float spawnXPosition = 37.55f; // Oyuncu karakterinin geçtikten sonraki X pozisyonu
    public int numberOfObjects = 10;

    private bool objectsSpawned = false;

    void Update()
    {
        if (!objectsSpawned && transform.position.x > spawnXPosition)
        {
            SpawnRandomObjects();
            objectsSpawned = true;
        }
    }

    void SpawnRandomObjects()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            float randomX = Random.Range(spawnXPosition, spawnXPosition + 5f); // Örnek olarak X koordinatýna 5 birim ekle
            float randomY = Random.Range(-3f, 3f); // Y koordinatýný belirli bir aralýkta seç

            Vector3 spawnPosition = new Vector3(randomX, randomY, 0f);

            // Oluþturulan rastgele GameObject'leri belirli bir X koordinatýnda yerleþtir
            Instantiate(randomObjects[Random.Range(0, randomObjects.Length)], spawnPosition, Quaternion.identity);
        }
    }
}