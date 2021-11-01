using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flor : MonoBehaviour
{
    public GameObject floor;
    float time;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.createFlor();
    }
    void createFlor()
    {
        time += Time.deltaTime;
        if (time > 0.7f)
        {
            //方塊從右邊(-2.5f,3.5f)出來跑出距離9f
            Vector3 pos = new Vector3(9, Random.Range(-6.5f, 1.6f), 0);
            Instantiate(floor, pos, transform.rotation);
            time = 0;

        }
    }
}