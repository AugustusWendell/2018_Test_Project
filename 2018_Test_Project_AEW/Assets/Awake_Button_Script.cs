using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Awake_Button_Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Awake Button")
                {
                    print("Awake Button is clicked by mouse");
                    //call a method in the SS_Agent_Controller

                }
            }

        }
    }


}
