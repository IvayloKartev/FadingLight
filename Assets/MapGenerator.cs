using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class MapGenerator : MonoBehaviour
{
    // Your Tile Map
    public int[,] tileMap = new int[,]
    {
        {1,1,1,1,0, 0, 1,1},
        {1,1,1,1,0, 0, 1,1},
        {1,1,1,1,0, 0, 1,1},
        {1,1,1,1,0, 0, 0,1},
        {1,1,1,1,0, 0, 0,1},
        {1,0,0,0,0, 0, 1,1},
        {1,0,0,0,0, 0, 1,1},
        {1,0,0,1,1, 1, 1,1},
        {1,0,0,1,1, 1, 1,1}
    };

    public float tileSize = 1.0f;
    public Vector2 startPoint = new Vector2(0, 0); // Adjust this as needed

    public GameObject baseTile1;
    public GameObject baseTile2;

    void Start()
    {
        PopulateTileMap();
    }

    public void PopulateTileMap()
    {
        //RandomTerrainGeneration(ref tileMap, 100,100); - in development for future tests
        for (int i = 0; i < tileMap.GetLength(0); i++)
        {
            for (int j = 0; j < tileMap.GetLength(1); j++)
            {
                // Determine which tile to instantiate based on the tileMap value
                GameObject prefab;
                if (tileMap[i, j] == 0)
                {
                    prefab = baseTile1;
                }
                else
                {
                    prefab = baseTile2;
                }

                // Instantiate the tile
                GameObject tile = Instantiate(prefab);

                // Set the tile's position
                tile.transform.position = new Vector3(
                    startPoint.x + i * tileSize + (tileSize / 2),
                    startPoint.y + j * tileSize + (tileSize / 2),
                    0
                );
            }
        }
    }
    public void RandomTerrainGeneration(ref int[,] matrix, int a, int b)
    {
        System.Random rand = new System.Random();
        for(int i=0; i<a; i++)
        {
            for(int j=0; j<b; j++)
            {
                int k=rand.Next(0,1);
                matrix[i, j] = k;
            }
        }
    }
    void Update()
    {
        // Add any update logic you need here
    }
}
