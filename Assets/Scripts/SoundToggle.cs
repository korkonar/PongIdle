using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundToggle : MonoBehaviour
{
    public bool fx;
    public SoundManager sound;
    // Start is called before the first frame update
    void Start()
    {
        sound=GameObject.Find("GameManager").GetComponent<SoundManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnToggle(){
        if(fx){
            if(this.GetComponent<Toggle>().isOn){
                sound.MuteFX=false;
            }else{
                sound.MuteFX=true;
            }
        }else{
            if(this.GetComponent<Toggle>().isOn){
                sound.setMute(false);
                this.transform.GetChild(0).GetChild(1).GetComponent<Image>().enabled=false;
            }else{
                sound.setMute(true);
                this.transform.GetChild(0).GetChild(1).GetComponent<Image>().enabled=true;
            }
        }

    } 
}
