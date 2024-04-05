using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float backgroundSpeed = 0.1f;
    float spriteSize;

    public SpriteRenderer backgroundSprite;

    Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        spriteSize = backgroundSprite.bounds.size.x * backgroundSprite.transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        float newPosition = Mathf.Repeat(Time.time * backgroundSpeed, spriteSize);
        transform.position = startPosition + Vector3.left * newPosition;
    }
}
