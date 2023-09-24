using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    public void clickme()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
