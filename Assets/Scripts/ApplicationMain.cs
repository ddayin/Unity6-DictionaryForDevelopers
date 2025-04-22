using System;
using UnityEngine;

namespace AssembleWords
{
    public class ApplicationMain : MonoBehaviour
    {
        private void Awake()
        {
            // Limit framerate to cinematic 24fps.
            QualitySettings.vSyncCount = 0; // Set vSyncCount to 0 so that using .targetFrameRate is enabled.
            Application.targetFrameRate = 24;
        }
    }
}