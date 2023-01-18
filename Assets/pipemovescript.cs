using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pipemovescript : MonoBehaviour
{

    public float moveSpeed = 5;
    public float deadzone = -20;
    public float timer = 2;
    public Text scoretext;
    public logicsricpt logic;



    // Start is called before the first frame update
    void Start()
    {
        //logic = GameObject.FindGameObjectWithTag(tag: "logic").GetComponent<logicsricpt>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
    
        if(transform.position.x < deadzone)
        {
            Debug.Log("pipe deleted!");
            Destroy(gameObject);
        }

         

    }
}
