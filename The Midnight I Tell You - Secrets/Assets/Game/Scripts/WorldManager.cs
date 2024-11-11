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

    }

    public void changeWorld()
    {
        if (World.Contains(World[0]))
        {


        }else if (World.Contains(World[1]))
        {

        }
    }

}
