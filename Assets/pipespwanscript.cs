using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespwanscript : MonoBehaviour
{

    public GameObject pipe;
    public float spwanrate = 2;
    private float timer = 0;
    public float heightoffset = 10;


    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spwanrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }

    }

    void spawnPipe()
    {

        float lowestpoint = transform.position.y - heightoffset;
        float highestpoint = transform.position.y + heightoffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestpoint,highestpoint), 0), transform.rotation);
    }
}
