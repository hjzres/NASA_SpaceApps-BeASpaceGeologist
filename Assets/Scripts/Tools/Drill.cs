using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugStick : Tool {
    public override void LeftClick(RaycastHit hit) {
        if(hit.gameObject.CompareTag("mineable")) {
            MonoBehaviour.Destroy(hit.transform.gameObject);
        }
    }
}
