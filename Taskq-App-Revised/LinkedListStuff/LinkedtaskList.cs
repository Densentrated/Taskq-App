using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;



namespace LinkedTaskList;


public class TaskLink
{
    // defines the data part of the linked list (a tuple )
    // this tuple is in the form of (task, time(24hr clock), duration(in min))
    // and defines the pointer (next)
    public (string, int, int) data;
    public TaskLink? next;

    // constructor
    public TaskLink((string, int, int) i)
    {
        data = i;
        next = null;
    }


    // adds an taskLink to the tail of the list
    public void AddTaskLinkToTail((string, int, int) data)
    {
        if (next == null)
        {
            next = new TaskLink(data);
        }
        else
        {
            next.AddTaskLinkToTail(data);
        }
    }

    public void AddTaskLinkByTime((string, int, int) data)
    {
        if (next == null)
        {
            next = new TaskLink(data);
        }
        else if (data.Item2 < next.data.Item2)
        {
            TaskLink temp = new(data);
            temp.next = this.next;
            this.next = temp;
        }
        else
        {
            next.AddTaskLinkByTime(data);
        }
    }

    // method that prints the current task
    public void Print()
    {
        Console.Write("[" + data + "]->");
        if (next != null)
        {
            next.Print();
        }
    }
}

public class TaskLinkList
{
    public TaskLink? head;

    // Constructor for the objective list
    public TaskLinkList()
    {
        head = null;
    }

    // adds an objective to the head of the list
    public void AddTaskLinkToHead((string, int, int) data)
    {
        if (head == null)
        {
            head = new TaskLink(data);
        }
        else
        {
            TaskLink temp = new TaskLink(data);
            temp.next = head;
            head = temp;
        }
    }

    // removes the objective at the head of the list
    public void RemoveHead()
    {
        if (head != null)
        {
            head = head.next;
        }
    }

    // adds objective to tail of list
    public void AddTaskLinkToTail((string, int, int) data)
    {
        if (head == null)
        {
            head = new TaskLink(data);
        }
        else
        {
            head.AddTaskLinkToTail(data);
        }
    }

    // adds objective to the list using the time
    public void AddTaskLinkByTime((string, int, int) data)
    {
        if (head == null)
        {
            head = new TaskLink(data);
        }
        else if (data.Item2 < head.data.Item2)
        {
            AddTaskLinkToHead(data);
        }
        else
        {
            head.AddTaskLinkByTime(data);
        }
    }

    // Prints the Current Objective List
    public void Print()
    {
        head?.Print();
    }
}

