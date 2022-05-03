using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudGenerator : MonoBehaviour
{

    public Transform cloudPrefab;
    public Vector3 cloudVolume;
    public int cloudNum;
    public int cloudSpeed;
    public float maxSize;
    public float minSize;


    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < cloudNum; i++)
        {
            Transform cloud = Instantiate(cloudPrefab, randomPosition(cloudVolume), Quaternion.identity);
            cloud.localScale *= Random.value * maxSize;
            cloud.localScale += new Vector3(minSize, minSize, minSize);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector3 randomPosition(Vector3 volume)
    {
        return new Vector3(Random.Range(-volume.x/2, volume.x/2), Random.Range(-volume.y/2, volume.y/2) + transform.position.y, Random.Range(-volume.z/2, volume.z/2));
    }
}
