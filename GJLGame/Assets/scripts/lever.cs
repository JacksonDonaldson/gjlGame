using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever : MonoBehaviour
{
    private bool used;
    public transition wallToMove;

    private SpriteRenderer sr;

    void Start()
    {
        sr = gameObject.GetComponent(typeof(SpriteRenderer)) as SpriteRenderer;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.name != "robot")
        {
            return;
        }
        if (!used && (other.gameObject.GetComponent(typeof(movement)) as movement).holdingA)
        {
            wallToMove.Activate();
            used = true;
            sr.flipX = !sr.flipX;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        used = false;
    }
}
