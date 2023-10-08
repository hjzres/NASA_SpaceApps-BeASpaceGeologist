using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< Updated upstream
public class Tool : MonoBehaviour
{
    public virtual void LeftClick(RaycastHit hit) {
        Debug.LogWarning("The tool might not have been assigned properly.");
    }
=======
public class Tool : MonoBehaviour {
    public virtual void LeftClick(Interact interact) { }

    public virtual void LeftClickHeld(Interact interact) { }

    public virtual void LeftClickUp(Interact interact) { }
>>>>>>> Stashed changes
}
