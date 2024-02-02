using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    //Se ve en el inspector gracias al [SerializeField]
    [SerializeField]
    protected string Name = "Enemy";
    [SerializeField]
    protected int Health = 100;
    [SerializeField]
    protected List<string> Loot;

    /*
     * GAMELOOP: LA CONFORMAN
     * 
     *  Init(); o Start();
     *  
     *  Update();
     *  
     *  Render();
     *  
     *  Destroy();
     */

    /// <summary>
    /// INIT: FUNCION que inicializa recursos o variables
    /// </summary>
    public virtual void Init()
    {
        Loot = new List<string>();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Item"></param>
    public virtual void AddLoot(string Item)
    {
        Loot.Add(Item);
    }

    /// <summary>
    /// Obtiene recursos
    /// </summary>
    /// <returns></returns>
    public virtual List<string> GetLoot()
    {
        return Loot;
    }

    /// <summary>
    /// Obtiene la vida
    /// </summary>
    /// <returns></returns>
    public virtual int GetHealth()
    { 
        return Health; 
    }
}
