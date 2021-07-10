using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnerTesting : MonoBehaviour
{
    int numBalls=0;
    public GameObject ballPrefab;
    public bool ON;
    public int totballs;
    public Rigidbody2D[] ballsRigid;
    // Start is called before the first frame update
    void Start()
    {
        ballsRigid=new Rigidbody2D[totballs];
        for(int i=0;i<totballs;i++){
            GameObject ball=Instantiate(ballPrefab,this.transform.position,this.transform.rotation);
            ballsRigid[i]=ball.GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(ON){
            Vector2 force= new Vector2(Random.value,Random.value);
            ballsRigid[numBalls].AddForce(force,ForceMode2D.Impulse);
            ballsRigid[numBalls].gameObject.SetActive(true);
            ballsRigid[numBalls].transform.position=Vector3.zero;
            print(++numBalls);
        }
    }
}
