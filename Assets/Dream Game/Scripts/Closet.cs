using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Closet : MonoBehaviour
{

    public GameObject lockedTransform;

    public GameObject closet;

    float timeLimit = 10.0f;

    bool finishedTask = false;

    public TaskManager taskManager;




    // Start is called before the first frame update
    void Start()
    {
        //SceneManager.LoadScene("jumpscareDad");
    }

    // Update is called once per frame
    void Update()
    {
        timeLimit -= Time.deltaTime;

        if (closet.transform.position.x == lockedTransform.transform.position.x) //if the window is closed all the way
        {
            finishedTask = true;
            enabled = false; // ends update func
            taskManager.completeTask2(1);
            
        }

        if (timeLimit <= 0.0f && finishedTask == false) // if the timer is finished and the task is incomplete
        {
            timerEnded();

            enabled = false; // ends update func
        }
    }






    void timerEnded()
    {
        SceneManager.LoadScene("jumpscareDad");
        //Application.Quit();
    }

}
