using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class coinscript : MonoBehaviour
{
    public GameObject coin;
    public birbscript birb;
    public logicsricpt logic;

    // Start is called before the first frame update
    void Start()
    {
        birb = GameObject.FindGameObjectWithTag(tag: "birb").GetComponent<birbscript>();
        logic = GameObject.FindGameObjectWithTag(tag: "logic").GetComponent<logicsricpt>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "birb" && birb.birdisalive == true)
        {
            logic.coinadd(1);
            Destroy(gameObject);

        }

    }


}
