using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birbscript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float flapstrenght;
    public logicsricpt logic;
    public bool birdisalive = true;

    public birbdatabase characterdb;
    public SpriteRenderer skinsprite;
    public int selectedOption = 0;
    bool touchedlastframe = false;

    [SerializeField] private AudioSource jumpsound;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag(tag: "logic").GetComponent<logicsricpt>();

        if (!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }

        else
        {
            load();
        }

        updatecharacter(selectedOption);
    }

    // Update is called once per frame
    void Update()
    {

        if (touchedlastframe && Input.touchCount == 0)
        {
            touchedlastframe = false;
        }
        else if (!touchedlastframe && Input.touchCount > 0)
        {
            if (birdisalive == true)
            {
                jumpsound.Play();
                myRigidbody.velocity = Vector2.up * flapstrenght;
                touchedlastframe = true;
            }
        }

        if (myRigidbody.transform.position.y >=6 || myRigidbody.transform.position.y <= -6)
        {

            logic.gameover();
            birdisalive = false;
        }

    }

    private void updatecharacter(int selectedOption)
    {
        Birb character = characterdb.GetCharacter(selectedOption);
        skinsprite.sprite = character.charactersprite;
    }

    private void load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        logic.gameover();
        birdisalive = false;
    }
}
