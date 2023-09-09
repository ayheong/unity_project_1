using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TopSpriteRendering : MonoBehaviour
{
    public GameObject player;
    public TilemapRenderer tilemapRenderer;
    string tileName;

    private void Start()
    {
        tileName = gameObject.name;
        Debug.Log(tileName);
    }

    // Update is called once per frame
    void Update()
    {
        if (tileName == "Front Gate")
        {
            if (player.transform.position.y < -7.23)
            {
                tilemapRenderer.sortingOrder = 9;
            }
            else
            {
                tilemapRenderer.sortingOrder = 11;
            }
        }
        else if (tileName == "Chainsaw Top")
        {
            if (player.transform.position.y < -3.1)
            {
                tilemapRenderer.sortingOrder = 9;
            }
            else
            {
                tilemapRenderer.sortingOrder = 11;
            }
        }
        else if (tileName == "Trashcan Top")
        {
            if (player.transform.position.y < -4.1)
            {
                tilemapRenderer.sortingOrder = 9;
            }
            else
            {
                tilemapRenderer.sortingOrder = 11;
            }
        }
    }
}
