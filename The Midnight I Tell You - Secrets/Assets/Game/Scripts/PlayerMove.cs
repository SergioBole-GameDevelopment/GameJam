using System;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    SpriteRenderer Sprite;
    [SerializeField] Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        move();

    }

    public void move()
    {

        #region Movement Code
        float x = Input.GetAxis("Horizontal");
        transform.Translate(x * Time.deltaTime, 0, 0);
        #endregion
        #region Invert Sprite
        if (x > 0f)
        {
            Sprite.flipX = false;
            anim.SetFloat("Walk", 0.01f);
        }
        else if (x < -0f)
        {
            Sprite.flipX = true;
            anim.SetFloat("Walk", 0.01f);
        }
        #endregion
        #region Animations settings


        #endregion
    }


}
