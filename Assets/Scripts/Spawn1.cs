using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawn1 : MonoBehaviour
{
    public GameObject engel1, engel2;
    bool hasground = true;
    [SerializeField] private Transform ustobje;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!hasground)
        {
            SpawnGround();
            hasground = true;
  


        }
    }
    public void SpawnGround()
    {
        int randomNum = Random.Range(1, 4);
        if (randomNum == 1)
        {
            GameObject yeniengel= Instantiate(engel1, new Vector3(transform.position.x + 3, 0.35f), Quaternion.identity);
            yeniengel.transform.parent = ustobje;

        }
        if (randomNum == 2)
        {
            GameObject yeniengel =Instantiate(engel2, new Vector3(transform.position.x + 3, 1.38f), Quaternion.identity);
            yeniengel.transform.parent = ustobje;

        }
        //if (randomNum == 3)
      //  {
       //     GameObject yeniengel=Instantiate(engel3, new Vector3(transform.position.x + 3, -0, 7f), Quaternion.identity);
     //       yeniengel.transform.parent = ustobje;

     //   }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            hasground = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            hasground = false;
        }
    }
}
