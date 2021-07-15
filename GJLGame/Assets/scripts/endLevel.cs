using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject endPanel;
    void OnTriggerEnter2D(Collider2D col)
    {
        endPanel.SetActive(true);
        Time.timeScale = 0;
    }
}
