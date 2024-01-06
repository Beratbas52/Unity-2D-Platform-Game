using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public GameObject Tilemap, Tilemap1, Tilemap2;
    bool hasmap = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasmap)
        {
            spawnmap();
            hasmap = true;

        }
    }
    public void spawnmap()
    {
        int randomNum = Random.Range(1, 4);

        if (randomNum == 1)
        {
            Instantiate(Tilemap, new Vector3(transform.position.x + 3, 0f, 0), Quaternion.identity);
        }
        if (randomNum == 2)
        {
            Instantiate(Tilemap1, new Vector3(transform.position.x + 3, -9.89f, 0), Quaternion.identity);
        }
        if (randomNum == 3)
        {
            Instantiate(Tilemap2, new Vector3(transform.position.x + 3, -9.39f, 0), Quaternion.identity);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("map"))
        {
            hasmap = true;
        }
    }
    private void TriggerExit2D(Collider2D collision)
    {
        hasmap = false;

    }
}
