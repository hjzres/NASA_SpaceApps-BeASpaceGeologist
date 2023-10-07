using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool : MonoBehaviour
{
    public virtual void LeftClick(RaycastHit hit) {
        Debug.Warning("The tool might not have been assigned properly.");
    }
}
