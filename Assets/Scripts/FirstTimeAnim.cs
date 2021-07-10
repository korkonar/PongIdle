using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FirstTimeAnim : MonoBehaviour
{
    public bool canvas;
    public static bool DoTheThing;

    static bool dis=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dis){
            this.enabled=false;
        }
        if(DoTheThing){
            if(canvas){
                Sequence sq= DOTween.Sequence();
                sq.Append(this.transform.GetChild(1).DOScale(1.2f,0.6f));
                sq.Append(this.transform.GetChild(1).DOScale(0.0f,0.4f));
                this.transform.GetChild(0).GetComponent<RectTransform>().DOAnchorPos3D(new Vector3(-170.0f,-100.0f,0.0f),2.0f);
                Sequence sq2= DOTween.Sequence();
                sq2.Append(this.transform.GetChild(2).DOScale(1.1f,1.5f));
                sq2.Append(this.transform.GetChild(2).DOScale(1.0f,0.5f));
                sq2.SetDelay(1.2f);
                Sequence sq3= DOTween.Sequence();
                sq3.Append(this.transform.GetChild(3).DOScale(1.1f,1.5f));
                sq3.Append(this.transform.GetChild(3).DOScale(1.0f,0.5f));
                sq3.SetDelay(2.2f);
                Sequence sq4= DOTween.Sequence();
                sq4.Append(this.transform.GetChild(4).DOScale(1.1f,1.5f));
                sq4.Append(this.transform.GetChild(4).DOScale(1.0f,0.5f));
                sq4.SetDelay(3.2f);
                Sequence sq5= DOTween.Sequence();
                sq5.Append(this.transform.GetChild(5).DOScale(1.1f,1.5f));
                sq5.Append(this.transform.GetChild(5).DOScale(1.0f,0.5f));
                sq5.SetDelay(4.2f);
            }else{
                //KongregateAPIBehaviour.SendFirstTimeDone();
                Manager.maxBalls=2;
                BallController.MaxBalls=2;
                this.GetComponent<Camera>().DOOrthoSize(7.0f,2.0f);
                this.transform.DOMove(new Vector3(-3.0f,-1.9f,-10.0f),2.0f);
                GameObject a=GameObject.FindGameObjectWithTag("Opponent");
                a.transform.DOScaleY(1.6f,1.5f);
                Manager.opPaddleSize=1.6f;
                ParticleSystem.MainModule m= BallController.particleSys.main;
                m.startSpeed=2;
                //a.transform.DOMoveY(0.0f,1.5f);
                //a.GetComponent<OpponentScript>().enabled=false;
                OpponentScript.size=6;
            }
            Manager.FirstTime=false;
            this.enabled=false;
        }
    }

    public static void disable(){
        dis=true;
    }
}
