using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startcontroller : MonoBehaviour
{
    int activeCircuit = -1;

    public string[] circuitValues = { "none", "none", "none", "none", "none", "none", "none", "none", "none" };
    public GameObject[] circuits;
    public GameObject startPanel;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;

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
            image.color = new Color(0, 0, 1);
        }
        else if(value == "d")
        {
            Image image = circuits[activeCircuit].GetComponent(typeof(Image)) as Image;
            image.color = new Color(1, 0, 0);
        }
        else if(value == "Space")
        {
            Image image = circuits[activeCircuit].GetComponent(typeof(Image)) as Image;
            image.color = new Color(.5f, .5f, .5f, 1);
        }
        else if(value == "lShift")
        {
            Image image = circuits[activeCircuit].GetComponent(typeof(Image)) as Image;
            image.color = new Color(.8f, .8f, 0);
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
        startPanel.SetActive(false);

    }
}
