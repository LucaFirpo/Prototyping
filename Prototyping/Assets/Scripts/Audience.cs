using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audience : MonoBehaviour
{
    public Thrower LeftTomato;
    public Thrower CenterTomato;
    public Thrower RightTomato;

    public void Update()
    {
        LeftTomato.Throw();
        CenterTomato.Throw();
        RightTomato.Throw();
    }
}
