using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class CharacterManager : MonoBehaviour
{
    public Birb[] characters;

    public birbdatabase characterdb;

    public SpriteRenderer skinsprite;

    public TMP_Text birbname;

    public TMP_Text coins;

    public Button selet;

    public Text select;

    public int coincount;

    public int selectedOption = 0;


        

    // Start is called before the first frame update
    void Start()
    {

        Birb character = characterdb.GetCharacter(selectedOption);

        if (!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }

        else
        {
            load();
        }

        updatecharacter(selectedOption);

        coins.text = PlayerPrefs.GetInt("CoinCount").ToString();

        foreach(Birb c in characters)
        {
            if (character.price == 0)
            {
                character.isUnlocked = true;
            }
            else
            {
                if (PlayerPrefs.GetInt(c.newname) == 0)
                {

                    character.isUnlocked = true;

                }
                else
                {
                    character.isUnlocked = false;
                }
            }
        }

    }

    public void nextoption()
    {
        selectedOption++;

        if(selectedOption >= characterdb.Charactercount)
        {
            selectedOption = 0;
        }

        updatecharacter(selectedOption);
        save();
    }


    public void backoption()
    {
        selectedOption--;

        if (selectedOption < 0)
        {
            selectedOption = characterdb.Charactercount - 1;
        }

        updatecharacter(selectedOption);
        save();
    }

    public void unlock()
    {
        Birb character = characterdb.GetCharacter(selectedOption);
        coincount = PlayerPrefs.GetInt("CoinCount");

        if (coincount >= character.price && character.isUnlocked == false)
        {
            if (PlayerPrefs.GetInt(character.newname) == 0)
            {
                character.isUnlocked = true;
            }

            coincount = coincount - character.price;
            
            PlayerPrefs.SetInt("CoinCount", coincount);
            
            coins.text = PlayerPrefs.GetInt("CoinCount").ToString();
            
            select.text = "select";
        }
    }

    private void updatecharacter(int selectedOption)
    {

        coincount = PlayerPrefs.GetInt("CoinCount");

        Birb character = characterdb.GetCharacter(selectedOption);


        skinsprite.sprite = character.charactersprite;
        
        birbname.text = character.newname;
        
        if (character.isUnlocked == true)
        {
            select.text = "select";
        }
        else
        {            

            select.text = character.price.ToString();
         
        }
        
    }

    private void load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }

    private void save()
    {
        PlayerPrefs.SetInt("selectedOption", selectedOption);
    }

    
}
