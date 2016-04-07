using System;
using System.Collections;
using System.Collections.Generic;


public class FSM<T>
{
    List<T> States;  

    List<string> TransitionsList = new List<string>(); //list of all possible state transitions for a certain object


    public FSM() //Contructor for the FSM
    {
        States = new List<T>(); //creates a new list of states for each instance of the FSM
        Console.WriteLine("State at creation  " + cState);
    }

    public void AddState(T state)
    {
        
        States.Add(state);
    }
    public void AddTransition(T From, T To)
    {
        
        string name = From.ToString() + ">" + To.ToString();

        if (!TransitionsList.Contains(name))
        {
            
            TransitionsList.Add(name);
        }
    }


    private bool checkTransition(T from, T to)
    {
        //checks the transition an object is trying to make to see if it is valid by checking it against
        //items in the list of valid transitions
        string t = to.ToString();
        string f = from.ToString();
        string valid = f + ">" + t;
        if (TransitionsList.Contains(valid))
            return true;
        return false;
    }

    public bool Transition(T from, T to)
    {
       
  
        if (checkTransition(from, to))
        {
            
            cState = to;
            Console.WriteLine("New State " + cState.ToString());
            return true;
        }
        else
        {
            
            return false;
        }
    }

    private T cState; //current state


    //implement the current state.
    public T state 
    {
        get
        {
            return cState;
        }
    }

}