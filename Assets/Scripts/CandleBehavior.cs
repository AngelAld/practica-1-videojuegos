using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CandleBehavior : MonoBehaviour
{
    public GameObject candleLight;
    public GameObject door;

    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.gameObject);
        if (other.CompareTag("Player") && Input.GetKeyDown("f"))
        {   
            Debug.Log("Vela apagada");
            Destroy(candleLight);
            door.GetComponent<DoorBehavior>().SwitchPressed();       
        }
    }
}