using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControledeCamera : MonoBehaviour
{
    public int status;
    public int statusGame;
    public bool ativa;
    public GameObject star;
    private Move starStatus;
    private Vector3 inGame;
    private Vector3 offGame;
    private Vector3 follownUp;
    private Vector3 follownDown;
    private Rigidbody starRb;

    // Start is called before the first frame update
    void Start()
    {
        ativa = true;
        status = 0;
        star = GameObject.FindWithTag("Player");
        starRb = star.GetComponent<Rigidbody>();
        starStatus = GetComponent<Move>();
        inGame = new Vector3(500, transform.position.y, 140);
        offGame = new Vector3(500, transform.position.y, 150);
        follownUp = new Vector3(500, star.transform.position.y +1, 140);
        follownDown = new Vector3(500, star.transform.position.y +5, 140);

    }

    // Update is called once per frame
    void Update()
    {
        if(status == 0 && transform.position.z < 150f){
            transform.Translate(new Vector3(0,0,+10) * Time.deltaTime * 2f);
        }else if (status == 1 && transform.position.z > 140f){
            transform.Translate(new Vector3(0,0,-10) * Time.deltaTime * 2f);
        }
        if(star.transform.position.y < transform.position.y -4){
            status = 0;
        }else if (star.transform.position.y > transform.position.y -4){
            status = 1;

        }
        if(star.transform.position.y > transform.position.y +4){
            transform.Translate(new Vector3(0, starRb.velocity.y, 0) * Time.deltaTime);
        }else if(star.transform.position.y < transform.position.y -8){
            transform.Translate(new Vector3(0, -starRb.velocity.y, 0) * Time.deltaTime);
        }
        if(transform.position.x != 500f){
            transform.TransformVector(500f, transform.position.y, transform.position.z);
        }

    }

}
