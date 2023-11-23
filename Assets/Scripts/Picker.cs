using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Picker : MonoBehaviour
{
    GameObject MainCube;
    public int height;
    float gold;
    public TextMeshProUGUI textGold;
    public TextMeshProUGUI textMetres;
    public GameObject gameOverpanel;




    MovementController movement;


    // Start is called before the first frame update
    void Start()
    {

        height = 0;
        MainCube = GameObject.Find("MainCube");

    }

    // Update is called once per frame
    void Update()
    {
        MainCube.transform.position = new Vector3(transform.position.x, height + 1, transform.position.z);
        transform.localPosition = new Vector3(0, -height, 0);
        textMetres.text = height.ToString() + "mt";

    }

    public void DropHeight()
    {

        if (height > 0)
        {
            height -= 1;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("collect") && other.gameObject.GetComponent<Collactables>().isCollectable() == false)
        {
            Debug.Log("topladim");
            AudioManager.Instance.PlaySFX("cubeCollect");
            height += 1;
            other.gameObject.GetComponent<Collactables>().GetCollect();
            other.gameObject.GetComponent<Collactables>().Index(height);
            other.transform.parent = MainCube.transform;
        }
        if (other.gameObject.CompareTag("Gold"))
        {
            AudioManager.Instance.PlaySFX("goldCollect");
            gold += 1;
            textGold.text = gold.ToString();
            Destroy(other.gameObject);
        }
        if (height == 0 && other.gameObject.CompareTag("block"))
        {
            Debug.Log("game overr");
            gameOverpanel.SetActive(enabled);
            Time.timeScale = 0f;




        }
    }
}
