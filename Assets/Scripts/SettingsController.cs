using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Example showing how toggle buttons' state can be stored in a bool array.
/// </summary>
public class SettingsController : MonoBehaviour
{
    #region Private member fields

    public static SettingsController Instance;

    // Internal copy of the toggle button state
    bool[] settings;

    #endregion

    #region Public member fields

    // Public field array of toggle buttons
    [Tooltip("Toggle buttons to be stored in the internal bool array")]
    public Toggle[] toggles;

    #endregion

    #region Unity messages

    /// <summary>
    /// Start this instance
    /// </summary>
    void Awake() {
        if (Instance != null) {
            Destroy(this.gameObject);
            return;
        }
        Instance = this;
        GameObject.DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        // Create a Boolean array the same size as the toggle button array
        settings = new bool[toggles.Length];

        // Loop through toggles.Length times...
        for (int i = 0; i < toggles.Length; i++)
        {
            // Set the 'settings' element 'i' to default to 'true'
            settings[i] = true;

            // Make a copy of 'i' for the benefit of the anonymous method below
            // We can't use 'i' in the anonymous method because it will eventually
            // contain the value toggles.Length which is no good, we want the exact
            // index value. By making a local copy of 'i' and storing it in 'index',
            // the value can be maintained on each AddListener() call. Try it-- take out
            // 'index' and replace with 'i'
            int index = i;

            // Add a listener to the onValueChanged event
            Toggle t = toggles[i];
            t.onValueChanged.AddListener(

                // The format of a basic anonymous method is () => { }
                // Where () contains the parameter list and { } contains the body of the method

                // The listener takes in a single parameter, but because 'index' is in the
                // current scope...
                (bool check) =>
                {
                    // ... it can be used as a parameter to the CheckBox() method
                    CheckBox(index, check);
                }
                
                );
        }
    }

    #endregion

    #region Private helper methods

    /// <summary>
    /// Set/reset the 'settings' element 'index' with the given Boolean value.
    /// </summary>
    /// <param name="index">Element index</param>
    /// <param name="check">Boolean value</param>
    void CheckBox(int index, bool check)
    {
        settings[index] = check;
    }

    #endregion
}
