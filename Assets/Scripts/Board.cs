using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public int width;
    public int heigth;
    public GameObject tilePrefab;
    public GameObject[] dots;
    private BackgroundTile[,] allTiles;
    public GameObject[,] allDots;
    void Start()
    {
        allTiles = new BackgroundTile[width, heigth];
        allDots = new GameObject[width, heigth];
        SetUp();
    }

    private void SetUp()
    {
        for(int i = 0; i < width; i++)
        {
            for(int j = 0; j< heigth; j++)
            {
                Vector2 tempPosition = new Vector2 (i, j);                                                          //
                GameObject backgroundTile = Instantiate(tilePrefab,tempPosition,Quaternion.identity) as GameObject; // Rendering background squares
                backgroundTile.transform.parent = this.transform;                                                  //
                backgroundTile.name = "( " + i + ", " + j + " )";                                                  //

                int dotToUse = Random.Range(0, dots.Length);                                           // randomize dotToUse
                GameObject dot = Instantiate(dots[dotToUse], tempPosition, Quaternion.identity); // render dots
                dot.transform.parent = this.transform;                                                 //
                dot.name = "( " + i + ", " + j + " )";
                allDots[i, j] = dot;
            }
        }
    }
}
