using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_paint : MonoBehaviour
{
    public GameObject[] objects; // картины
    string current_side_paint; // текущая сторона
    int current_room; // текущая комната

    void Awake()
    {
        current_room = db_room.room;
        current_side_paint = db_room.side_paint;

        if (current_room != 0)
        {
            Destroy(GameObject.Find(objects[current_room-1].name));

            if (current_side_paint == "left")
            {
                Instantiate(objects[current_room - 1], new Vector3(-2.7f, 3.5f, 7.8f), Quaternion.identity);
                db_room.side_paint = "right";
            }
            else if (current_side_paint == "right")
            {
                Instantiate(objects[current_room - 1], new Vector3(2.7f, 3.5f, 7.8f), Quaternion.identity);
                db_room.side_paint = "left";
            }

        }
    }
}