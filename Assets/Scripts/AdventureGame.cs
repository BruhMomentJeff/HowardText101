using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text txtComponent;
    [SerializeField] State startingState;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        txtComponent.text = state.GetStateStory();
        
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        
        
        var nextStates = state.GetNextStates();
        for (int intIndex = 0; intIndex < nextStates.Length; intIndex++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + intIndex))
            {
                state = nextStates[intIndex];
            }
        }
        txtComponent.text = state.GetStateStory();
    }
}
