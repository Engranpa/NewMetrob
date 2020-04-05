using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float Horizontalmove;
    private float Verticalmove;
    public CharacterController player;

    public float playerSpeed;

    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Horizontalmove = Input.GetAxis("Horizontal");
        Verticalmove = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        player.Move(new Vector3(Horizontalmove, 0, Verticalmove) * playerSpeed);
    }
}
