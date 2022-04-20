using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveApointer : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    private Vector3 tp;
    private Vector2 t;

    public GameObject Charpos;
    void Start()
    {
        rb = GetComponent<Rigidbody> ();
        Charpos = GameObject.FindWithTag("Characters");
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.touchCount > 0) 
        {
            Touch touch = Input.GetTouch(0);
            
            if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved) 
            {
            
                rb.position = new Vector3(((touch.position.x/55)+(497)) , (touch.position.y/65)+(Camera.main.transform.position.y -5), 160);
            }
        }
        
    }
}
