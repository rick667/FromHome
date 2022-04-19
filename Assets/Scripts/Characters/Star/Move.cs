using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : AbstractStar
{
    public Vector2 touchPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.TouchCount > 0){
            Touch touch = Input.GetTouch(0);


            switch(touch.phase){
                case TouchPhase.Began: MonoBehaviour
                    touchPosition = touch.position;
                    Debug.Log("position is: " + touchPosition);
            }
        }

    }

    public void TouchTest(){
        
    }
}
