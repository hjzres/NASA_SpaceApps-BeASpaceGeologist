using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool : MonoBehaviour {
    public virtual void LeftClick(Interact interact) {

    }

    public virtual void LeftClickHeld(Interact interact) {
        
    }

    public virtual void LeftClickUp(Interact interact) {

    }

    public virtual void RightClick(Interact interact) {
        RaycastHit hit;
        if(interact.Raycast(out hit)) {
            string hitTag = hit.transform.gameObject.tag;
            if(hitTag == "Player" || hitTag == "Robot" && interact.gameObject.tag != hitTag){
                Interact hitInteract = hit.transform.gameObject.GetComponentInParent<Interact>();
                
                interact.cam.gameObject.SetActive(false);
                hitInteract.cam.gameObject.SetActive(true);

                if(hitTag == "Player") {
                    interact.gameObject.GetComponent<RobotMovement>().enabled = false;
                    hitInteract.gameObject.GetComponent<PlayerMovement>().enabled = true;
                } else if(hitTag == "Robot") {
                    interact.gameObject.GetComponent<PlayerMovement>().enabled = false;
                    hitInteract.gameObject.GetComponent<RobotMovement>().enabled = true;
                }

                hitInteract.enabled = true;
                interact.enabled = false;
            }
        }
    }
}
