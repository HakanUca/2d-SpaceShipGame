using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public Ship ShipScript;

    public GameObject borular;

    public float height;

    public float time;

    void Start()
    {
        StartCoroutine(SpawnObject(time));
    }


    

    public IEnumerator SpawnObject(float time)
    {
        while (!ShipScript.isDead)
        {

            Instantiate (borular, new Vector3(3, Random.Range(-height, height), 0), Quaternion.identity);

            yield return new WaitForSeconds(time);

        }
    }




}
