using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{


    public void doRestart(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }

}
