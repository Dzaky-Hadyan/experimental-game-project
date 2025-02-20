using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IPlayerInput
{
    public float XAxis { get; set; }
    public float YAxis { get; set; }
    public bool Shoot { get; set; }
}
class PlayerInput : MonoBehaviour, IPlayerInput
{
    public float XAxis { get; set; }
    public float YAxis { get; set; }
    public bool Shoot { get; set; }
    void Update()
    {
        XAxis = Input.GetAxisRaw("Horizontal 1");
        YAxis = Input.GetAxisRaw("Vertical 1");
        Shoot = Input.GetButtonDown("Fire1");
    }

}