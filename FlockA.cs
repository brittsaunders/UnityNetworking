using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlockA : MonoBehaviour
{

    public GameObject prefab;
    public static int size = 20;
    public float speed = 5f;

    static int amount = 150;
    public static GameObject[] flock = new GameObject[amount];
    public static Vector3 goTo = Vector3.zero;
    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < amount; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-size, size), Random.Range(-size, size), Random.Range(-size, size));
            flock[i] = (GameObject)Instantiate(prefab, pos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        goTo = prefab.transform.position - transform.position;
        goTo = goTo.normalized;
        transform.Translate(goTo * Time.deltaTime * speed, Space.World);
    }
}
