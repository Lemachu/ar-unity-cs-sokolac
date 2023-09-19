using UnityEngine;
using System.Collections;

public class SetSceneOrientation : MonoBehaviour {

    void Awake () {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
}