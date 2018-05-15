using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour {

    public bool IsAwake;
    public int Age = 22;
    public string Name = "Suzy";
    public string State = "Agitated";

    public bool IsAwake1
    {
        get
        {
            return IsAwake;
        }

        set
        {
            IsAwake = value;
        }
    }

    // Use this for initialization
    void Start () {

        // Generic Debug
        print("An Agent was Started!");

        }
	
	// Update is called once per frame
	void Update () {
		
	}

    // SetName

    // GetName

    // SetState

    // GetState

    // SetVector

    // GetVector

    int GetAge()
    {
        return Age;
    }


    void SetAsleep ()
    {

       // Object.material = Agent_Asleep_Material;
    }

    void SetAwake ()
    {

        //Object.material = Agent_Awake_Material;
    }
}
