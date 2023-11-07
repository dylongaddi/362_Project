using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Sprite[] sprites;
    public float size = 1.0f;
    public float minSize = 0.5f;
    public float maxSize = 1.5f;
    private SpriteRenderer _spriteRenderer;
    private Rigidbody _rigidbody;
    // Start is called before the first frame update
    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        _spriteRenderer.sprite = sprites[Random.Range(0, sprites.Length)];

        this.transform.eulerAngles = new Vector3(0f, 0f, Random.value *360.0f);
        this.transform.localScale = Vector3.one * this.size; //vector3.one == vector3(1, 1, 1)\

        _rigidbody.mass = this.size;

    }

    // Update is called once per frame

}
