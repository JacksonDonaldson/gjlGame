using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transition : MonoBehaviour
{
    public Vector3 startPos;
    public float startRotation;

    public float transitionTime = 1;
    public Vector3 endPos;
    public float endRotation;

    public bool atStart = true;
    public bool doIt;
    // Start is called before the first frame update
    void Start()
    {
        if(startPos == Vector3.zero)
        {
            startPos = transform.position;
            startRotation = transform.rotation.eulerAngles.z;
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        if (doIt)
        {
            StartCoroutine(translate());
            doIt = false;

        }
    }

    public void Activate()
    {
        StartCoroutine(translate());

    }
    IEnumerator translate()
    {
        print("translate called");
        bool destination = !atStart;
        atStart = !atStart;

        float distance = Mathf.Sqrt((startPos.x - endPos.x) * (startPos.x - endPos.x) + (startPos.y - endPos.y) * (startPos.y - endPos.y));
        float angleChange = Mathf.DeltaAngle(startRotation, endRotation);

        print(distance);
        float startTime = Time.time;


        while (destination == atStart)
        {
            if(Time.time - startTime >= transitionTime)
            {
                if (!atStart)
                {
                    transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, endRotation);
                    transform.position = endPos;
                }
                else
                {
                    transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, startRotation);
                    transform.position = startPos;
                }
                break;
            }

            if (!atStart)
            {
;
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, endRotation), Time.deltaTime * angleChange / transitionTime);


                transform.position = Vector3.MoveTowards(transform.position, endPos, Time.deltaTime * distance / transitionTime);

            }
            else
            {
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, startRotation), Time.deltaTime * angleChange / transitionTime);

                transform.position = Vector3.MoveTowards(transform.position, startPos, Time.deltaTime * distance /transitionTime);


            }

            yield return null;

        }
        
        
    }
}
