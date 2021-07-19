using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class tutorailController : MonoBehaviour
{
    public TMP_Text exp;
    public GameObject startButton;
    string text1 = "Great! You've selected a chip. Now choose what action you wish to assign it from below, and press that key. Choose carefully- only keys with corresponding chips can be pressed, and a fuse in the chip will blow once you let go.";
    string text2 = "Hit 'r' to reset at any time. Press the start button to begin. Good luck!";
    void Update()
    {
        if(Input.GetKey("a") || Input.GetKey("d") || Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.LeftShift))
        {
            if(exp.text == text1)
            {
                startButton.SetActive(true);
                exp.text = text2;
            }
        }
    }
    public void changeText()
    {
        exp.text = text1;
    }
}
