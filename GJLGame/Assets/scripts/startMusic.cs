using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startMusic : MonoBehaviour
{
    private music audi;
    public string track;
    private bool done;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (!done)
        {
            done = true;
            audi = GameObject.Find("soundPlayer").GetComponent(typeof(music)) as music;
            print(audi);
            audi.startTrack(track);
        }

    }
}
