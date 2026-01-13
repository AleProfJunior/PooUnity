
#if UNITY_EDITOR
using UnityEditor;

public static class ConfiguradorInicialEditor
{
    [MenuItem("Tools/ativar configuração inicial")]
    static void ConfigureInicialEditor()
    {
        Config();
    }

    static void Config()
    {
        EditorSettings.enterPlayModeOptionsEnabled = true;
        EditorSettings.enterPlayModeOptions =
            EnterPlayModeOptions.DisableDomainReload |
            EnterPlayModeOptions.DisableSceneReload;

        SerializedObject playerSettings = new SerializedObject(UnityEngine.Resources.FindObjectsOfTypeAll<PlayerSettings>()[0]);
        
        SerializedProperty inputProp = playerSettings.FindProperty("activeInputHandler");
        if (inputProp != null)
        {
            inputProp.intValue = 2; // 0=Old,1=New,2=Both
            playerSettings.ApplyModifiedProperties();
        }
        

    }
    
  

    
}

#endif