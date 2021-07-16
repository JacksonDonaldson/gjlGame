using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startcontroller : MonoBehaviour
{
    int activeCircuit = -1;

    public string[] circuitValues = { "none", "none", "none", "none", "none", "none", "none", "none", "none" };
    public static string[] savedCircuitValues = { "none", "none", "none", "none", "none", "none", "none", "none", "none" };
    public GameObject[] circuits;
    public GameObject startPanel;

    public Sprite chipA;
    public Sprite chipD;
    public Sprite chipS;
    public Sprite chipLS;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        circuitValues = savedCircuitValues;
        for(int i = 0; i < 9; i++)
        {
            activeCircuit = i;
            configureActiveCircuit(circuitValues[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(activeCircuit != -1)
        {
            if (Input.GetKey("a"))
            {
                configureActiveCircuit("a");
            }
            else if (Input.GetKey("d"))
            {
                configureActiveCircuit("d");
            }
            else if (Input.GetKey(KeyCode.Space))
            {
                configureActiveCircuit("Space");
            }
            else if (Input.GetKey(KeyCode.LeftShift))
            {
                configureActiveCircuit("lShift");
            }
        }
    }
    void configureActiveCircuit(string value)
    {

        circuitValues[activeCircuit] = value;
        

        if (value == "a")
        {
            Image image = circuits[activeCircuit].GetComponent(typeof(Image)) as Image;
            image.sprite = chipA;
        }
        else if(value == "d")
        {
            Image image = circuits[activeCircuit].GetComponent(typeof(Image)) as Image;
            image.sprite = chipD;
        }
        else if(value == "Space")
        {
            Image image = circuits[activeCircuit].GetComponent(typeof(Image)) as Image;
            image.sprite = chipS;
        }
        else if(value == "lShift")
        {
            Image image = circuits[activeCircuit].GetComponent(typeof(Image)) as Image;
            image.sprite = chipLS;
        }

        activeCircuit = -1;
    }
    public void setActiveCircuit(int circuitNum)
    {
        activeCircuit = circuitNum;
    }
    public void begin()
    {
        Time.timeScale = 1;
        savedCircuitValues = (string[])circuitValues.Clone();
        startPanel.SetActive(false);

    }
}
