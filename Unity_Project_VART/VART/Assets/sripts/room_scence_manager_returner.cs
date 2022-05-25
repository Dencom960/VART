using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class room_scence_manager_returner : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForSeconds(3);
        
        SceneManager.LoadScene(0);
    }
}