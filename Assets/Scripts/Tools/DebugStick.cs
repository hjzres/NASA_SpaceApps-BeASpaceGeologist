using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugStick : Tool {
    public override void LeftClick(RaycastHit hit) {
        MonoBehaviour.Destroy(hit.transform.gameObject);
    }
}
