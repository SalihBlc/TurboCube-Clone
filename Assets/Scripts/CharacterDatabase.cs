using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
[CreateAssetMenu]
public class CharacterDatabase : ScriptableObject
{
    public Store[] character;
    public int characterCount
    {
        get
        {
            return character.Length;
        }
    }
    public Store GetCharacter(int index)
    {
        return character[index];
    }
}
