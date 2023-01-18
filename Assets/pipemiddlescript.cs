using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pipemiddlescript : MonoBehaviour
{

    public logicsricpt logic;
    public birbscript birb;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag(tag: "logic").GetComponent<logicsricpt>();
        birb = GameObject.FindGameObjectWithTag(tag: "birb").GetComponent<birbscript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3 && birb.birdisalive == true)
        {
            logic.addscore(1);
        }

    }

}
