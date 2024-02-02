using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeBase : MonoBehaviour
{
    public bool isDead = false;
    protected float health = 100f;

    public float GetHealth()
    {
        return health;
    }
}
