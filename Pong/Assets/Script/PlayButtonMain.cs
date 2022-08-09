using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonMain : MonoBehaviour
{

    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }
}
