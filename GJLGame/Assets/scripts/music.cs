using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool spawned;
    private AudioSource aS;
    public AudioClip end;
    public AudioClip levels;

    void Start()
    {
        aS = gameObject.GetComponent(typeof(AudioSource)) as AudioSource;
        if (!spawned)
        {
            DontDestroyOnLoad(gameObject);
            spawned = true;
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    public void startTrack(string track)
    {
        if(track == "end")
        {
            aS.clip = end;
            aS.Play();
        }
        if(track == "levels")
        {
            aS.clip = levels;
            aS.Play();
        }

    }
}
