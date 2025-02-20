using System.Collections;
using System.Collections.Generic;
using UnityEngine;


class PlayerInput2 : MonoBehaviour, IPlayerInput
{
    public float XAxis { get; set; }
    public float YAxis { get; set; }
    public bool Shoot { get; set; }
    void Update()
    {
        XAxis = Input.GetAxisRaw("Horizontal 2");
        YAxis = Input.GetAxisRaw("Vertical 2");
        Shoot = Input.GetButtonDown("Fire1");
    }

}