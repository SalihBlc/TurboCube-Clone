using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDisplay : MonoBehaviour
{
    [SerializeField] private GameObject characterModel;
    public void UpdateCharacter(Characters _newCar)
    {

        //carPrice.text = _newCar.carPrice + "$";


        if (characterModel.transform.childCount > 0)
            Destroy(characterModel.transform.GetChild(0).gameObject);
        Instantiate(_newCar.characterModel, characterModel.transform.position, characterModel.transform.rotation, characterModel.transform);
    }
}
