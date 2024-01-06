using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    [SerializeField] private List<GameObject> engellerListesi;

    [SerializeField] private Transform ustobje;
    private void Awake()
    {
        //SpawnLevelPart(new Vector3(45, -1));
        //SpawnLevelPart(new Vector3(45, 3) + new Vector3(7, 0));
        //SpawnLevelPart(new Vector3(45, 6) + new Vector3(7 + 7, 0));
    }
    //private void SpawnLevelPart(Vector3 spawnPosition)
    //{
    //    GameObject newObj = Instantiate(engel1, spawnPosition, Quaternion.identity).gameObject;
    //    newObj.transform.parent = parent;
    //}

    public void YeniEngelOlustur()
    {
        GameObject yeniEngel = Instantiate(engellerListesi[Random.Range(0, 3)]);
        yeniEngel.transform.position = new Vector2(82,-2);
        yeniEngel.transform.parent = ustobje;
    }

}