using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class auction_scence_manager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            SceneManager.LoadScene(1);
        if (Input.GetKeyDown(KeyCode.Alpha2))
            SceneManager.LoadScene(2);
        if (Input.GetKeyDown(KeyCode.Alpha3))
            SceneManager.LoadScene(3);
        if (Input.GetKeyDown(KeyCode.Alpha4))
            SceneManager.LoadScene(4);
        if (Input.GetKeyDown(KeyCode.Alpha5))
            SceneManager.LoadScene(5);
        if (Input.GetKeyDown(KeyCode.Alpha6))
            SceneManager.LoadScene(6);
        if (Input.GetKeyDown(KeyCode.Alpha7))
            SceneManager.LoadScene(7);
        if (Input.GetKeyDown(KeyCode.Alpha8))
            SceneManager.LoadScene(8);
        if (Input.GetKeyDown(KeyCode.Alpha9))
            SceneManager.LoadScene(9);
    }
}
