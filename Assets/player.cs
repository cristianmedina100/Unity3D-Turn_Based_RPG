using System.Collections;
using System.Collections.Generic;
using Terresquall;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class player : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] VirtualJoystick joystick;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        // BUG: This sends you up when you hit forward :(
        Vector2 dir = joystick.GetAxisRaw();
        Vector3 fixedder =new Vector3(dir.x, 0, dir.y);
        controller.Move(fixedder*Time.deltaTime * speed);
        // test change
    }
}
