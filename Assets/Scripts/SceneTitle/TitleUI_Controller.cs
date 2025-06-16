using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Dictionary
{
    public class TitleUI_Controller : MonoBehaviour
    {
        public Button m_ButtonGeneral;
        public Button m_ButtonCSharp;
        public Button m_ButtonPuzzle;
        public Button m_ButtonSetting;

        private void Awake()
        {
            m_ButtonGeneral.onClick.AddListener(() => OnClickButton("General"));
            m_ButtonCSharp.onClick.AddListener(() => OnClickButton("C#"));
            m_ButtonPuzzle.onClick.AddListener(() => OnClickButton("Puzzle"));
            m_ButtonSetting.onClick.AddListener(() => OnClickButton("Setting"));
        }
        
        private void OnClickButton(string _buttonName)
        {
            Debug.Log(_buttonName);
            
            switch (_buttonName)
            {
                case "General":
                    
                    break;
                case "C++":
                    Debug.Log("C++");
                    break;
                case "C#":
                    
                    break;
                case "Unity":
                    Debug.Log("Unity");
                    break;
                case "Unreal":
                    Debug.Log("Unreal");
                    break;
                case "Network":
                    Debug.Log("Network");
                    break;
                case "Puzzle":
                    Debug.Log("Puzzle");
                    break;
                case "Setting":
                    Debug.Log("Setting");
                    break;
                default:
                    Debug.LogError(_buttonName);
                    break;
            }
        }
    }
}