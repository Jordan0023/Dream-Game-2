using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    private AudioSource audioBird;

    public float startDelay;
    public float soundInterval;

    public float min;
    public float max;

   

    // Start is called before the first frame update
    void Start()
    {
        audioBird = GetComponent<AudioSource>();
        InvokeRepeating("birdSounds", startDelay, soundInterval);
    }

    // Update is called once per frame
    void Update()
    {
        //  Invoke("birdSounds", soundInterval);
       // StartCoroutine(birdEnumerator());
    }

 
    void birdSounds()
    {
        audioBird.Play();
       //soundInterval = Random.Range(min, max);
       
        
        print(soundInterval);
    }

    IEnumerator birdEnumerator()
    {
        audioBird.Play();
        print(soundInterval);
        yield return new WaitForSeconds(soundInterval);
        print(soundInterval);
    }

}
