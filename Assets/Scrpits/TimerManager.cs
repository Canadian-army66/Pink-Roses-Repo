using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading;
using System;

public class TimerManager : MonoBehaviour
{
    private int Time;
    public TextMeshProUGUI Clock;
    void Start()
    {
     
    }
    void Update()
    {
        
    }
    void addSeconds()
    {
        Time++ ;
    }

    /*
    class CountdownTimer
    {
        private static int timeRemaining = 30;
        private static bool running = true;
        private static readonly object lockObj = new object();

        static void Main()
        {
            Thread timerThread = new Thread(Countdown);
            timerThread.Start();

            
            Thread.Sleep(5000);
            AddSeconds(5);
        }

        static void Countdown()
        {
            while (running)
            {
                lock (lockObj)
                {
                    if (timeRemaining <= 0)
                    {
                        Console.WriteLine("Countdown finished!");
                        running = false;
                        break;
                    }

                    Console.WriteLine($"Time Remaining: {timeRemaining} seconds");
                    timeRemaining--;
                }
                Thread.Sleep(1000);
            }
        }

        static void AddSeconds(int seconds)
        {
            lock (lockObj)
            {
                timeRemaining += seconds;
                Console.WriteLine($"Added {seconds} seconds! New time: {timeRemaining} seconds");
            }
        }
    }
    */
}
