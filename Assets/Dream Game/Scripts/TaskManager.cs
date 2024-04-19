using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{

    public bool task1 = false;
    public bool task2 = false;

    public int points = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (points >= 2)
        {
            Application.Quit();
        }
    }

   public void completeTask1(int n)
    {
       

        points += n;

        round1();
    }

    public void completeTask2(int n)
    {
        points += n;

        round1();
    }

    public void round1()
    {
        if(points == 2)
        {
            Application.Quit();
        }
    }
}
// use enum maybe

