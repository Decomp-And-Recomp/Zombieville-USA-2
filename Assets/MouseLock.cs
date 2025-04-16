using UnityEngine;

public class MouseLock : MonoBehaviour
{
    void Awake()
    {
        // Prevent this object from being destroyed on scene load
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        // Check if F1 key is pressed
        if (Input.GetKeyDown(KeyCode.F1))
        {
            // Toggle cursor lock state
            if (Cursor.lockState == CursorLockMode.None)
            {
                // Lock the cursor to the center of the screen
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false; // Make the cursor invisible
            }
            else
            {
                // Unlock the cursor and make it visible
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }
}
