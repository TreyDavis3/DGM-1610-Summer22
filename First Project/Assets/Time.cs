using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time : MonoBehaviour
 // Capture frames as a screenshot sequence. Images are
    // stored as PNG files in a folder - these can be combined into
    // a movie using image utility software (eg, QuickTime Pro).
    // The folder to contain our screenshots.
    // If the folder exists we will append numbers to create an empty folder.
    string folder = "ScreenshotFolder";
    int frameRate = 25;
        
    void Start () {
        // Set the playback frame rate (real time will not relate to game time after this).
        Time.captureFramerate = frameRate;
        
        // Create the folder
        System.IO.Directory.CreateDirectory(folder);
    }
    
    void Update () {
        // Append filename to folder name (format is '0005 shot.png"')
        string name = string.Format("{0}/{1:D04} shot.png", folder, Time.frameCount );
        
        // Capture the screenshot to the specified file.
        Application.CaptureScreenshot(name);
    }
}