using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteorPrefab;



    void Start()
    {
        InvokeRepeating("SpawnMeteor", 0, 0.5f);
    }

    void SpawnMeteor()
    {
        float randomX = Random.Range(-8.5f, 8.5f);
        float randomScale = Random.Range(1.0f, 3.0f);
        GameObject meteor = Instantiate(meteorPrefab);
        meteor.transform.position = new Vector3(randomX, transform.position.y, transform.position.z);
        meteor.transform.localScale = new Vector3(randomScale, randomScale, randomScale);
    }

}
