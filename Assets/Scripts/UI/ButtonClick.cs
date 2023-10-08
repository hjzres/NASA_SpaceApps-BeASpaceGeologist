using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    public void switchScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void loadPart(string part)
    {
        if (part.Equals("settings"))
        {

        }
    }
}
