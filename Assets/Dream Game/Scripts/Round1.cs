using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round1 : MonoBehaviour
{

     GameObject lockedTransformWindow;

     GameObject lockedTransformCloset;

     GameObject window;

     GameObject closet;

    float timeLimit = 10.0f;

    public TaskManager taskManager;

    private bool task1 = false;
    private bool task2 = false;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeLimit -= Time.deltaTime;

        if (window.transform.position.x == lockedTransformWindow.transform.position.x)
        {
            task1 = true;
            //if window is closed all the way

        }

        if (closet.transform.position.x == lockedTransformCloset.transform.position.x)
        {
            task2 = true;
            //if closet closed all the way
        }

        if (timeLimit <= 0.0f && task1 == false || task2 == false)                
        {
            timerEnded();
            // if one of the tasks isnt finished and the time limit is finished, go to timer ended

        }

        if(task1 == true && task2 == true) // if player completes both tasks
        {
            completedTasks();
        }
        

    }

    void completedTasks()
    {
        Application.Quit();
        // hide or go to sleep
    }


    void timerEnded()
    {
        //add jumpscare or ending screen
       
    }

}