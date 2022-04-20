using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : AbstractStar
{
    public Vector2 tp = new Vector2(0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0){
            Touch t = Input.GetTouch(0);
            tp = t.position;
            Debug.Log("possition: "+ tp);

        }
    }
}
