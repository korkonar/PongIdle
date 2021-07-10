using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioSource[] audioSources;
    bool Mute=false;
    public bool MuteFX=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void PlayClick(){
        if(!MuteFX){
            audioSources[2].Play();
        }
    }

    public void PlayNewBall(){
        if(!MuteFX){
            audioSources[3].Play();
        }
    }

    public void PlayBounce(){
        if(!MuteFX){
            audioSources[1].pitch=Random.Range(0.7f,1.3f);
            audioSources[1].Play();
        }
    }

    public void setMute(bool b){
        Mute=b;
        if(b){
            audioSources[0].Stop();
        }else{
            if(!audioSources[0].isPlaying){
                audioSources[0].Play();
            }
        }
    }
}
