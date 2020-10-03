using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
   public void LoadGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
