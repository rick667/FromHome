using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : AbstractStar
{
    public Vector2 tp = new Vector2(0, 0);
    //public ApoiterAngle apointer;
    public Transform guy;
    public Rigidbody rb;
    private GameObject apointer;
    public Vector3 directionMove;
    public float distanceMove;
    private ApoiterAngle apointerAngle;
    public float movePower;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if(apointer == null){
            apointer = GameObject.FindWithTag("Control");
            apointerAngle = apointer.GetComponent<ApoiterAngle>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        directionMove = apointerAngle.direction;
        distanceMove = apointerAngle.distance;
        movePower = (distanceMove - 10)* -1;
        if(Input.touchCount > 0){
            Touch t = Input.GetTouch(0);
            if(t.phase == TouchPhase.Began)
            {
                if(energy >= 1 && status != 0)
                {
                    if(movePower > 0)
                    {
                        rb.AddForce(-directionMove * (10 - distanceMove), ForceMode.Impulse);
                        energy = energy -1;
                    }
                    
                }else if(status == 0 ){
                    status = 1;
                    //transform.Translate((new Vector3 (0,50,0)) * Time.deltaTime * 1f );
                    rb.AddForce(transform.up * 10, ForceMode.Impulse);

                }
            }
        }
        if(transform.position.y == 0.5 && Input.touchCount == 0){
            status = 0;
            energy = 3;

        }
        if(transform.position.x < 497){
            rb.AddForce(transform.right * 0.5f, ForceMode.Impulse);
        }
        else if (transform.position.x > 503)
        {
            rb.AddForce(-transform.right * 0.5f, ForceMode.Impulse);
        }

        if(distanceMove >= 10)
        {
            distanceMove = distanceMove - (distanceMove -10);
        } 
        if(movePower < 0)
        {
            movePower = 0;
        }

    }
}
