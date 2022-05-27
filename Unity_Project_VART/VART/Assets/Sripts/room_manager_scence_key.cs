using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class room_manager_scence_key : MonoBehaviour
{

    IEnumerator Start()
    {
        db_room.room = SceneManager.GetActiveScene().buildIndex; // сохранение комнаты  в db_room
        yield return new WaitForSeconds(db_room.time); // задержка в комнате, можно менять в db__room
        SceneManager.LoadScene(0); // возврат на аукцион
    }
}
