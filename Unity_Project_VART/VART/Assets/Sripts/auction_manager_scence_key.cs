using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class auction_manager_scence_key : MonoBehaviour
{
// обрабатывает нажатие по клавиатуре
    void OnGUI()
    {
        // перемещение по клавиатуре f1, f2, f3 и т.д.
        if (Event.current.Equals(Event.KeyboardEvent(KeyCode.F1.ToString()))) { SceneManager.LoadScene(1); } 
        if (Event.current.Equals(Event.KeyboardEvent(KeyCode.F2.ToString()))) { SceneManager.LoadScene(2); }
        if (Event.current.Equals(Event.KeyboardEvent(KeyCode.F3.ToString()))) { SceneManager.LoadScene(3); }
        if (Event.current.Equals(Event.KeyboardEvent(KeyCode.F4.ToString()))) { SceneManager.LoadScene(4); }
        if (Event.current.Equals(Event.KeyboardEvent(KeyCode.F5.ToString()))) { SceneManager.LoadScene(5); }
        if (Event.current.Equals(Event.KeyboardEvent(KeyCode.F6.ToString()))) { SceneManager.LoadScene(6); } 
        if (Event.current.Equals(Event.KeyboardEvent(KeyCode.F7.ToString()))) { SceneManager.LoadScene(7); }
        if (Event.current.Equals(Event.KeyboardEvent(KeyCode.F8.ToString()))) { SceneManager.LoadScene(8); }
        if (Event.current.Equals(Event.KeyboardEvent(KeyCode.F9.ToString()))) { SceneManager.LoadScene(9); }
    }
}
