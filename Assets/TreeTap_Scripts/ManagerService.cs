using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICurrencySystem
{
    void Increase_Count();
    void Decrease_Count();
    void Set_Count();
    void Get_Count();
}

public class ManagerService : MonoBehaviour
{
    public static ManagerService instance = null;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
    }
}