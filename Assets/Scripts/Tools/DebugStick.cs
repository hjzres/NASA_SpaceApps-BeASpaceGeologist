using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugStick : Tool {
    public override void LeftClick(Interact interact) {
        RaycastHit hit;
        if(interact.Raycast(out hit)) {
            MonoBehaviour.Destroy(hit.transform.gameObject);
        }
    }
}
