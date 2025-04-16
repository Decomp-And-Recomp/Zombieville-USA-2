using UnityEngine;

public class MouseLock : MonoBehaviour
{
    public static bool locked
    { 
        get
        {
            return Cursor.lockState == CursorLockMode.Locked;
        }
        set
        {
            Cursor.lockState = value ? CursorLockMode.Locked : CursorLockMode.None;
        }
    }

    [RuntimeInitializeOnLoadMethod]
    static void OnGameStart()
    {
        DontDestroyOnLoad(new GameObject("Mouse Lock", typeof(MouseLock)));
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1)) locked = !locked;
    }
}
