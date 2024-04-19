using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDisable : MonoBehaviour
{
    //public GameObject door;
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Collided");
        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {

            this.gameObject.SetActive(false);

        }
    }
    
}
