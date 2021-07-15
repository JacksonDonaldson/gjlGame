using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class movement : MonoBehaviour
{
    private bool holdingR;
    private bool holdingL;
    private bool holdingJ;
    public bool holdingA;
    private string recentHold;
    
    public float speed;
    public float jumpSpeed;

    public startcontroller circs;
    public Rigidbody2D rb;
    public bool grounded = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.timeScale == 0)
        {
            return;
        }

        checkInputs();



        if (Input.GetKey("r"))
        {
            reset();
        }


        if (holdingR)
        {
            //if(!Physics2D.OverlapArea(new Vector2(transform.position.x + .51f, transform.position.y - .49f), new Vector2(transform.position.x + .51f, transform.position.y + .49f))){
            //    rb.velocity = new Vector2(speed, rb.velocity.y);
            //}
            rb.AddForce(new Vector2(222, 0));
            
            
        }
        if (holdingL)
        {
            rb.AddForce(new Vector2(-222, 0));
            

        }
        if (holdingL && holdingR)
        {
            if (recentHold == "L")
            {
                rb.AddForce(new Vector2(-222, 0));

            }
            else
            {
                rb.AddForce(new Vector2(222, 0));
            }
        }

        if(!holdingL && !holdingR)
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        if (holdingJ)
        {
            if (grounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
            }
        }


        if (rb.velocity.x > speed)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        if(rb.velocity.x < -speed)
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }

        checkGroundedness();
    }


    int index(string[] ar, string element)
    {
        for(int i = 0; i < ar.Length; i++)
        {
            if (ar[i] == element)
            {
                return i;
            }
        }
        return -1;

    }

    void checkInputs()
    {
        if (!Input.GetKey("a"))
        {
            holdingL = false;
        }
        else
        {
            if (!holdingL)
            {
                if (index(circs.circuitValues, "a") != -1)
                {
                    circs.circuitValues[index(circs.circuitValues, "a")] = "none";
                    holdingL = true;
                    recentHold = "L";
                }
            }
        }


        if (!Input.GetKey("d"))
        {
            holdingR = false;
        }
        else
        {
            if (!holdingR)
            {
                if (index(circs.circuitValues, "d") != -1)
                {
                    circs.circuitValues[index(circs.circuitValues, "d")] = "none";
                    holdingR = true;
                    recentHold = "R";
                }
            }
        }

        if (!Input.GetKey(KeyCode.LeftShift))
        {
            holdingA = false;
        }
        else
        {
            if (!holdingA)
            {
                if (index(circs.circuitValues, "lShift") != -1)
                {
                    circs.circuitValues[index(circs.circuitValues, "lShift")] = "none";
                    holdingA = true;
                }
            }
        }

        if (!Input.GetKey(KeyCode.Space))
        {
            holdingJ = false;
        }
        else
        {
            if (!holdingJ)
            {
                if (index(circs.circuitValues, "Space") != -1)
                {
                    circs.circuitValues[index(circs.circuitValues, "Space")] = "none";
                    holdingJ = true;
                }
            }
        }
    }

    void checkGroundedness()
    {
        if(Physics2D.OverlapArea(new Vector2(transform.position.x - .35f, transform.position.y - .51f), new Vector2(transform.position.x + .35f, transform.position.y -.52f)))
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
    }

    void reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.name == "spikeLayer")
        {
            reset();
        }
    }
}
