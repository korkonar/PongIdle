using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public static int MaxBalls=1;
    public static int currBalls=0;
    public static float emissionRate=0.2f;
    private float timer;

    public static ParticleSystem particleSys;
    private ParticleSystem.Particle[] m_Balls;
    public Text opponentPoint;
    int opponentPoints=0;
    public Text cuurBalls;

    // Start is called before the first frame update
    void Start()
    {
        timer=0.5f;
        particleSys=transform.GetChild(Manager.ballType).GetComponent<ParticleSystem>();
        //if(Manager.FirstTime){
        //    particleSys.Emit(1);
        //    currBalls++;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        cuurBalls.text="Balls: "+currBalls+"/"+MaxBalls;
        timer-=Time.deltaTime;
        if(timer<0){
            if(currBalls<MaxBalls){
                timer=1/emissionRate;
                particleSys.Emit(1);
                currBalls++;
            }
        }

        if(particleSys.particleCount!=currBalls){
            if(particleSys.particleCount<currBalls){
                Manager.Points+=10;
                Manager.totalPoints+=10;
                Manager.updatePointCounter();
            }
            currBalls=particleSys.particleCount;
        }

        m_Balls=new ParticleSystem.Particle[currBalls];
        particleSys.GetParticles(m_Balls);

        for(int i=0;i<currBalls;i++){
            if(m_Balls[i].position.x>7.75f){
                m_Balls[i].remainingLifetime=0.0f;
                currBalls--;
                //add Points
                Manager.addPoint();
            }else if(m_Balls[i].position.x<-7.75f){
                m_Balls[i].remainingLifetime=0.0f;
                currBalls--;
                if(Manager.FirstTime)opponentPoint.text=++opponentPoints+"";
            }
        }
        particleSys.SetParticles(m_Balls);


        
    }
    public void removeParticleSys(){
        m_Balls=new ParticleSystem.Particle[currBalls];
        particleSys.GetParticles(m_Balls);

        for(int i=0;i<currBalls;i++){
            m_Balls[i].remainingLifetime=0.0f;
        }

        
        particleSys.SetParticles(m_Balls);
    }
    public void changeParticleSys(){
        particleSys=transform.GetChild(Manager.ballType).GetComponent<ParticleSystem>();
    }
    
    void OnParticleTrigger(){
        print("Trigger");
        BallController.currBalls--;
        if(tag.Equals("Goal")){
            //add points amd stuff
        }
    }
}
