using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class room_manager_scence_key : MonoBehaviour
{

    IEnumerator Start()
    {
        db_room.room = SceneManager.GetActiveScene().buildIndex; // ���������� �������  � db_room
        yield return new WaitForSeconds(db_room.time); // �������� � �������, ����� ������ � db__room
        SceneManager.LoadScene(0); // ������� �� �������
    }
}
