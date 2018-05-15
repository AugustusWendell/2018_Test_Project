using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SS_Agent_Controller : MonoBehaviour {

    //Lists are dynamically sized generic containers. AgentList holds all Agents in a scene
    private List<GameObject> AgentList = new List<GameObject>();
    int AgentListSize;

	// Use this for initialization
	void Start () {

        //Generic Debug
        print("SS_Agent_Controller was Started!");
        FindAgents();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    // Method to find all Agents
    void FindAgents ()
    {
        //Move through list of objects, add identifiers to each agent into a list
       
        //Generic Debug
        print("SS_Agent_Controller(FindAgents) was Started!");
        // AgentList.Add();
        // AgentListSize = AgentLize.Count;
        Debug.Log(AgentListSize);

    }

    //Method to deliver a list of all Agents to another object
    void ReturnAgents()
    {

        //Returns all Agents to the object asking
    }
}
