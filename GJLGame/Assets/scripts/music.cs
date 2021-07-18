using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool spawned;

    void Start()
    {
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
