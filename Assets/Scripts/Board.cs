using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public int width;
    public int heigth;
    public GameObject tilePrefab;
    private BackgroundTile[,] allTiles;
    void Start()
    {
        allTiles = new BackgroundTile[width, heigth];
        SetUp();
    }

    private void SetUp()
    {
        for(int i = 0; i < width; i++)
        {
            for(int j = 0; j< heigth; j++)
            {
                Vector2 temPosition = new Vector2 (i, j);
                Instantiate(tilePrefab,temPosition,Quaternion.identity);
            }
        }
    }
}
