using System.Linq;
using UnityEngine;

public class WorldManager : MonoBehaviour
{

    [Header("Sprites")]
    SpriteRenderer[] Sprites;
    public GameObject[] World;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        changeWorld();
    }

    public void changeWorld()
    {
        if (World.Contains(World[0]))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                World[0].SetActive(false);
                World[1].SetActive(true);
            }

        }else if (World.Contains(World[1]))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                World[0].SetActive(true);
                World[1].SetActive(false);
            }
        }
    }

}
