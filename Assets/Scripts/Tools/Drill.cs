using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drill : Tool {
    public override void LeftClick(RaycastHit hit) {
        if(hit.transform.gameObject.CompareTag("mineable")) {
            MonoBehaviour.Destroy(hit.transform.gameObject);
        }
    }
}
