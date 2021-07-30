using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Grid
{
    private int width;
    private int height;
    private float cellSize;
    private int[,] gridArray;

    public Grid(int height, int width, float cellSize)
    {
        this.height = height;
        this.width = width;
        this.cellSize = cellSize;

        gridArray = new int[width, height];

        for (int x = 0; x < gridArray.GetLength(0); x++)
        {
            for (int y = 0; y < gridArray.GetLength(1); y++)
            {
                UtilsClass.CreateWorldText(
                    gridArray[x, y].ToString(),
                    null,
                    getWorldPosition(x, y),
                    20,
                    Color.white,
                    TextAnchor.MiddleCenter
                );
            }
        }
    }

    public Vector3 getWorldPosition(int x, int y)
    {
        return new Vector3(x, y) * cellSize;
    }

}
