using UnityEngine;

public abstract class CRTPSingleton<T> : MonoBehaviour where T : CRTPSingleton<T>
{
    public static T instance { get; private set; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = (T)this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }
}
