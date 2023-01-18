using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class birbdatabase : ScriptableObject
{

    public Birb[] character;

    
    public int Charactercount
    {
        get 
        {
            return character.Length;
        }
    }

    public Birb GetCharacter(int index)
    {
        return character[index];
    }


}
