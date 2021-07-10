using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnButtonClick : MonoBehaviour
{
    public bool upgrade;
    public int cost;
    public Manager.upgradeType uptype;
    public Manager.improvementsType imptype;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickOKEarnings(){
        this.transform.parent.gameObject.SetActive(false);
    }

    public void OnClickNewBall(){
        if(cost<=Manager.Points){
            Manager.Points=0;
            Manager.updatePointCounter();
            Manager.nextBall();
        }
    }

    public void OnClickPurchase(){
        //print(Manager.Points);
        //print(cost);
        if(cost<=Manager.Points){
            Manager.Points-=cost;
            Manager.updatePointCounter();
            if(upgrade){
                Manager.addUpgrade(uptype);
                //print("bought");
            }else{
                Manager.addImprovements(imptype);
            }
            Destroy(this.gameObject,0.1f);
        }
    }

    public void OnToggle(){
        bool on=this.GetComponent<Toggle>().isOn;
        if(on){
            PlayerPaletScript.autoOn=true;
        }else{
            PlayerPaletScript.autoOn=false;
        }
    }
}
