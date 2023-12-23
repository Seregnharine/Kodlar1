using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor1 : MonoBehaviour
{
    [SerializeField] private Texture2D cursor;
    private Vector2 cursorspot;
    void Start()
    {
        cursorspot = new Vector2(cursor.width / 4, cursor.height / 4);
            Cursor.SetCursor(cursor, cursorspot, CursorMode.Auto);
    }

   
}
