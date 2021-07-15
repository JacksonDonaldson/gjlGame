using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class tutorailController : MonoBehaviour
{
    public TMP_Text exp;

    public void changeText()
    {
        exp.text = "Great! You've selected a chip. Now choose what action you wish to assign it from below, press that key, and hit start. Once you let go of the button though, a fuse will blow and that chip will be unusable. Good luck!";
    }
}
