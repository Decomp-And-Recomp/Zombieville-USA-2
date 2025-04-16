#if UNITY_STANDALONE || UINITY_EDITOR
using UnityEngine;

public class TouchScreenKeyboard : MonoBehaviour
{
    static TouchScreenKeyboard instance;

    public static bool hideInput;
    public static bool visible;

    public static Rect area
    {
        get { return Rect.zero; }
    }

    string _text;

    public string text
    {
        get { return _text; }
        set
        {
            //string val = value;

            //if (!multiline) val.Replace("\n", "");

            //_text = val;
            _text = value;
        }
    }

    string placeholderText;

    TouchScreenKeyboardType type;
    bool autocorrection;
    bool multiline;
    bool secure;
    bool allert;

    public bool done;

    public bool active;
    public bool wasCanceled;

    static GUIStyle temp;

    public static TouchScreenKeyboard Open(string text = "", TouchScreenKeyboardType type = TouchScreenKeyboardType.Default, bool autocorrection = true, bool multiline = true, bool secure = false, bool allert = false, string placeholderText = "")
    {
        // cant manualy add typeof(TouchScreenKeyboard) in `new` field because i would need to use GetComponent
        if (instance == null)
            instance = new GameObject("TouchScreenKeyboard (Emulator)").AddComponent<TouchScreenKeyboard>();

        instance.text = text;
        instance.multiline = multiline;
        instance.secure = secure;
        instance.allert = allert;
        instance.placeholderText = placeholderText;

        instance.active = true;
        instance.wasCanceled = false;
        instance.done = false;

        return instance;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.RightShift))
        {
            done = true;
            active = false;
            return;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            done = true;
            active = false;
            wasCanceled = true;

            return;
        }

        text += Input.inputString;
    }

    void OnGUI()
    {
        if (!active || hideInput) return;

        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");

        temp = new GUIStyle()
        {
            alignment = TextAnchor.MiddleCenter,
            normal = {textColor = Color.white},
            fontSize = 46
        };


        GUI.Label(new Rect(0, 0, Screen.height, Screen.width), text, temp);
    }
}
#endif