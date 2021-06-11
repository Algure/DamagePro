using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodySceneManager : MonoBehaviour
{
    public GameObject Body;

    private Dictionary<int, Color> tickColors;
    private Dictionary<string, Image> imageMap;
    private Dictionary<string, int> tickCountMap;
    
    // Start is called before the first frame update
    void Start()
    {
        Refresh();
    }

    public void Refresh()
    {
        InitMaps();
        InitImageColors();
    }

    private void InitImageColors()
    {
        foreach( string bodyPart in imageMap.Keys)
        {
            RenderTick(bodyPart);
        }
    }

    public void EnactTick(string bodyPart)
    {
        tickCountMap[bodyPart]++;
        RenderTick(bodyPart);
    }

    private void RenderTick(string bodyPart)
    {
        imageMap[bodyPart].color = tickCountMap[bodyPart] < 4 ? tickColors[tickCountMap[bodyPart]]: Color.red;
    }

    private void InitMaps()
    {
        tickCountMap = new Dictionary<string, int>();
        tickCountMap["Shoulder"] = 0;
        tickCountMap["Chest"] = 0;
        tickCountMap["Abs"] = 0;
        tickCountMap["Legs"] = 0;
        tickCountMap["RightArm"] = 0;
        tickCountMap["LeftArm"] = 0;

        tickColors = new Dictionary<int, Color>();
        tickColors[0] = Color.green;
        tickColors[1] = Color.yellow;
        tickColors[2] = new Color(1, 0.5f, 0);
        tickColors[3] = Color.red;

        imageMap = new Dictionary<string, Image>();
        imageMap["Shoulder"] = Body.transform.Find("Shoulder").transform.GetComponent<Image>();
        imageMap["Chest"] = Body.transform.Find("Chest").transform.GetComponent<Image>();
        imageMap["Abs"] = Body.transform.Find("Abs").transform.GetComponent<Image>();
        imageMap["Legs"] = Body.transform.Find("Legs").transform.GetComponent<Image>();
        imageMap["RightArm"] = Body.transform.Find("RightArm").transform.GetComponent<Image>();
        imageMap["LeftArm"] = Body.transform.Find("LeftArm").transform.GetComponent<Image>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
