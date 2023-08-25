using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class ClearPlayerPrefsOnExit : MonoBehaviour
{
#if UNITY_EDITOR
    [MenuItem("Edit/Clear PlayerPrefs On Exit")]
    private static void ClearPrefsOnExit()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("PlayerPrefs cleared.");
    }
#endif
}




