using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public Quaternion resetSpin;
    public Quaternion spinSpeed;
    public Quaternion rotationChecker;
    float xRotate;
    public float rotSpeed;
    public float timer = 40; // 40 seconds full rotation
    public float daytimeTimer;
    public bool dayTime = true;
    public bool nightTime = false;

    private void Start()
    {
        resetSpin = Quaternion.Euler(90, 0, 0);
        spinSpeed = Quaternion.Euler(1, 0, 0);
    }

    private void Update ()
    {
        rotationChecker = this.gameObject.transform.rotation;
        xRotate += spinSpeed.x * (Time.deltaTime *rotSpeed);
        this.gameObject.transform.localRotation = Quaternion.Euler(xRotate, transform.localRotation.y, transform.localRotation.z);


        timer -= Time.deltaTime;
        if(timer < 0 && dayTime)
        {
            timer = 40;
            dayTime = false;
            nightTime = true;

        }
        if(timer < 0 && nightTime)
        {
            timer = 40;
            dayTime = true;
            nightTime = false;
        }

  
                        

    }
    public bool GetDay()
    {
        //if(rotationChecker.x >  && rotationChecker.x > 0.7)
        //{
        //    return true;
       // }
        return false;
    }
}
