using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T m_instance = null;
    public static T Instance
    {
        get { return m_instance;}
        private set { m_instance = value; }
    }
    protected virtual void Awake()
    {
        if (Instance == null)
        {
            Instance = this as T;
            Debug.Log(this.name + "�Ѿ���������ͬsingletonʵ��");
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            Debug.LogWarning("GameManager�ĵ����Ѿ����٣�");
        }
    }
}
