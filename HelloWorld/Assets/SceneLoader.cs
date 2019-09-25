using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour {

    public void LoadNextScene()
    {
        Application.LoadLevel("scene 2");
    }

    public void LoadPreviousScene()
    {
        Application.LoadLevel("scene 1");
    }
}
