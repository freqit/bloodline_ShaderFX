using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodLineFX : MonoBehaviour
{
    public Material bloodLine;
    public bool startLine = false;
    public bool loop = false;

    private Vector2 offset;

    private float scrollSpeed = 0.3f;
    private Vector2 direction;

    void Start()
    {
        bloodLine.SetVector("_Offset", new Vector2(1f, 0f));
        direction = bloodLine.GetVector("_Offset");
    }

    void FixedUpdate()
    {
        if (loop)
        {
            if (direction.x <= 0)
            {
                direction.x = 1f;
            }
        }

        if(startLine)
        {
            direction.x = Mathf.Clamp(direction.x - Time.deltaTime * scrollSpeed, 0, 1);
            offset = new Vector2(direction.x, 0f);
            bloodLine.SetVector("_Offset", offset);
        }
    }
}
