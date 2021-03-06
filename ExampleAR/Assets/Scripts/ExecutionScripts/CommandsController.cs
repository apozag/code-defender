﻿using System.Collections.Generic;
using UnityEngine;

public enum Command
{
    TURN_RIGHT,
    TURN_LEFT,
    STEP,
    TALK,
}

public class CommandsController : MonoBehaviour
{

    Queue<Command> commands;
    Queue<string> messages;

    public PlayerMovement player;

    GoalChecker gc;


    bool isExecuting = false;

    // Start is called before the first frame update
    void Start()
    {
        commands = new Queue<Command>();
               
        isExecuting = false;
        messages = new Queue<string>();
        gc = GetComponent<GoalChecker>();
    }

    private void Update()
    {
        if (isExecuting)
            tryExecute();
    }

    public void tryExecute()
    {

        if (player.ready())
        {
            if (commands.Count > 0)
            {
                Command c = commands.Dequeue();
                switch (c)
                {
                    case Command.TURN_LEFT:
                        player.turn(Turn.LEFT);
                        break;
                    case Command.TURN_RIGHT:
                        player.turn(Turn.RIGHT);
                        break;
                    case Command.STEP:
                        player.step(1);
                        break;
                    case Command.TALK:
                        player.say(messages.Dequeue());
                        break;
                }
            }
            else
            {

                string topic = PlayerPrefs.GetString("TOPIC");
                string level = PlayerPrefs.GetString("LEVEL");

                if (!topic.Equals("99") && !level.Equals("99"))
                {
                    if (gc.isGoalComplete()) 
                        FindObjectOfType<UIController>().win();
                    else 
                        FindObjectOfType<UIController>().loose();
                }
                stop();

            }
        }

    }

    public void addCommand(Command c)
    {
        commands.Enqueue(c);
    }
    public void addMessage(string msg)
    {
        messages.Enqueue(msg);
    }

    public bool isRunning()
    {
        return !player.ready();
    }
    public void stop()
    {
        commands.Clear();
        messages.Clear();
        isExecuting = false;
        player.reset();
        gc.resetElements();
    }
    public void start()
    {
        isExecuting = true;
    }

}
