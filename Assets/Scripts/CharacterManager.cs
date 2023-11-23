using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    public CharacterDatabase characterDB;

    public SpriteRenderer changedCharacter;
    private int selectedOption = 0;

    void Start()
    {
        UpdateCharacter(selectedOption);
    }
    public void NextOption()
    {
        selectedOption++;
        if (selectedOption >= characterDB.characterCount)
        {
            selectedOption = 0;
        }
        UpdateCharacter(selectedOption);
    }
    public void BackOption()
    {
        selectedOption--;
        if (selectedOption < 0)
        {
            selectedOption = characterDB.characterCount - 1;
        }
        UpdateCharacter(selectedOption);

    }
    private void UpdateCharacter(int selectedOption)
    {
        Store store = characterDB.GetCharacter(selectedOption);
        changedCharacter.sprite = store.characterPrefab;
    }
}
