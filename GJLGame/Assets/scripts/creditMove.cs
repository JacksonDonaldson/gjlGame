using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creditMove : MonoBehaviour
{
    public Transform camT;
    public float speed;
    public float maxHeight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(speed < 11)
        {
            speed += 2 * Time.deltaTime;
        }

        if (camT.position.y < maxHeight)
        {
            camT.position = Vector3.MoveTowards(camT.position, new Vector3(camT.position.x, maxHeight, camT.position.z), Time.deltaTime * speed);
            transform.position = new Vector3(transform.position.x, transform.position.y + Time.deltaTime * speed, transform.position.z);
        }
    }
}
