using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPaletScript : MonoBehaviour
{
    private MouseKeyboard inputs;
    public static float speed=5;
    public static bool AutoMove=false;
    public static bool autoOn=false;
    static float maxPosY=4.25f;
    public Transform TopCheck;
    public Transform BottomCheck;

    bool up;
    void Awake()
    {
        inputs=new MouseKeyboard();
    }

    void OnEnable(){
        inputs.Enable();
    }

    void OnDisable(){
        inputs.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (autoOn){
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
        }else{
            float axisValue=inputs.Player.MovePalet.ReadValue<float>();
            if(axisValue!=0){
                if(TopCheck.position.y<maxPosY && axisValue>0){
                    transform.position+=Vector3.up*speed*axisValue*Time.deltaTime;
                }else if(BottomCheck.transform.position.y>-maxPosY && axisValue<0){
                    transform.position+=Vector3.up*speed*axisValue*Time.deltaTime;
                }
            }
        }
    }
}
