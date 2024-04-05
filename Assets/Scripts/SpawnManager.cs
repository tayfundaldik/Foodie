
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float RandomRangeX = 20;
    private float SpawnCoXYZ =10;
    private float Interval = 0.5f;
    private float starts = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMgr1",starts,Interval);
        InvokeRepeating("SpawnMgr2",starts,Interval);
        InvokeRepeating("SpawnMgr3",starts,Interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnMgr1()
    {
        Vector3 SpawnPos = new Vector3(Random.Range(-RandomRangeX,RandomRangeX),0,SpawnCoXYZ);

        int animalIndex = Random.Range(0,animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex],SpawnPos,animalPrefabs[animalIndex].transform.rotation);
    }
    void SpawnMgr2(){
        Vector3 SpawnPosleft = new Vector3(-SpawnCoXYZ,0,Random.Range(-RandomRangeX,RandomRangeX));
        int animalIndex = Random.Range(0,animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex],SpawnPosleft,Quaternion.LookRotation(Vector3.right));
    }
    void SpawnMgr3(){
        Vector3 SpawnPosright = new Vector3(SpawnCoXYZ,0,Random.Range(-RandomRangeX,RandomRangeX));
        int animalIndex = Random.Range(0,animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex],SpawnPosright,Quaternion.LookRotation(Vector3.left));
    }
}
