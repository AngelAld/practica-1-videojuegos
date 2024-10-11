using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehavior : MonoBehaviour
{
    public int leftSwitches = 3;
    public GameObject winMessage;

    void Start()
    {
        winMessage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SwitchPressed()
    {
        leftSwitches--;
        if (leftSwitches == 0)
        {
            Debug.Log("Door is open");
            Destroy(gameObject);
            winMessage.SetActive(true);
        }
    }
}
