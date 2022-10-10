using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    float timer = 0.0f;
    public float delay = 100.0f;
    public GameObject Enemy;

    //float sinInd = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > delay)
        {
            GameObject obj = Instantiate(Enemy);
            obj.transform.position = new Vector3(0f, 0.407f, 2.708f);
            timer = 0.0f;
        }
    }
}
