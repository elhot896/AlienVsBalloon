using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    bool ifTouched;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    /*
    // Update is called once per frame
    void Update()
    {
       if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchposition = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                ifTouched = true;
            }

            if (touch.phase == TouchPhase.Moved)
            {
                if (ifTouched)
                {
                    transform.position = new Vector2(6.24f, touchposition.y);
                }
            }

            if (touch.phase == TouchPhase.Ended)
            {
                ifTouched = false;
            }
        }
    }*/

    public void GoingUp()
    {

        rb.AddForce(transform.right * 73f);
        
    }
}
