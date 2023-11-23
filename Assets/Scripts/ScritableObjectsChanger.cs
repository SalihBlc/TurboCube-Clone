using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScritableObjectsChanger : MonoBehaviour
{
    [SerializeField] private ScriptableObject[] scriptableObjects;

    [SerializeField] private CharacterDisplay characterDisplay;


    private int currentIndex;
    private void Awake()
    {
        ChangeScritableObject(0);
    }

    public void ChangeScritableObject(int _change)
    {
        AudioManager.Instance.PlaySFX("click");
        currentIndex += _change;
        if (currentIndex < 0) currentIndex = scriptableObjects.Length - 1;
        else if (currentIndex > scriptableObjects.Length - 1) currentIndex = 0;
        if (characterDisplay != null) characterDisplay.UpdateCharacter((Characters)scriptableObjects[currentIndex]);








    }
}
