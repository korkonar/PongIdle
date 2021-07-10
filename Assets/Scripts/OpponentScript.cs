using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentScript : MonoBehaviour
{
    bool up;
    public static float speed=5;

    public Transform TopCheck;
    public Transform BottomCheck;
    static float maxPosY=4.78f;
    
    public static int size=0;
    //max size 1.6, and max position movement then 1.58
    // Start is called before the first frame update
    void Start()
    {
        up=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(up){
            transform.position+=Vector3.up*speed*Time.deltaTime;
            if(TopCheck.position.y>=maxPosY){
                up=false;
            }
        }else{
            transform.position+=Vector3.down*speed*Time.deltaTime;
            if(BottomCheck.position.y<=-maxPosY){
                up=true;
            }
        }
        
    }
}
