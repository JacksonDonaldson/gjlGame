using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickyMover : MonoBehaviour
{
    
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "robot")
        {
            col.collider.transform.SetParent(transform);
        }
    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.name == "robot")
        {
            col.collider.transform.SetParent(null);
        }
    }
}
