using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene(1);
    }
    public void BackLevel()
    {
        SceneManager.LoadScene(0);
    }
}
