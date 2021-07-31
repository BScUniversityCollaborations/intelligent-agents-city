using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGrid : MonoBehaviour
{
    [SerializeField] Canvas mapAreaCanvas;
    [SerializeField] float mapAreaHeight;
    [SerializeField] float mapAreaWidth;

    // Start is called before the first frame update
    void Start()
    {
        mapAreaCanvas = GameObject.Find("Map_Area")
                                  .GetComponent<Canvas>();

        mapAreaHeight = mapAreaCanvas.GetComponent<RectTransform>().rect.height;
        mapAreaWidth = mapAreaCanvas.GetComponent<RectTransform>().rect.width;

        Debug.Log(mapAreaHeight + " " + mapAreaWidth);

        Grid grid = new Grid((int)Math.Round(mapAreaHeight), (int)Math.Round(mapAreaWidth), 2f);
    }
}
