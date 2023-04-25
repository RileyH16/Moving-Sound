using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{

    public Vector3 positionChange;
    public Animator anim;
    public AudioSource roar;
    bool hasPlayed;
    bool hasFinished;

    // Start is called before the first frame update
    void Start()
    {
        hasPlayed = false;
        hasFinished = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(transform.position.x<= -5 && hasPlayed == false)
        {
            anim.SetInteger("State", 1);
            GetComponent<AudioSource>().Play();
            hasPlayed = true;
            Invoke("Finish", 5.4f);
        }

        else if (transform.position.x >= -5|| hasFinished == true)
        {
            transform.position += positionChange * Time.deltaTime;
            anim.SetInteger("State", 0);
        }
    }
    void Finish()
    {
        hasFinished = true;
    }
}
