using System;
using PolyAndCode.UI;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

namespace AssembleWords
{
    public class WordCell : MonoBehaviour, ICell
    {
        public TextMeshProUGUI m_IdText;
        public TextMeshProUGUI m_WordText;
        public TextMeshProUGUI m_TextDescription;
        
        private Button m_Button;
        
        // private CSharpData m_WordModel;
        private int m_CellIndex;

        private void Awake()
        {
            m_Button = GetComponent<Button>();
            m_Button.onClick.AddListener(OnClickCell);
        }

        private void OnClickCell()
        {
            // Debug.Log(m_WordModel.Word);
            // AllTypeOfDictionary.instance.m_CurrentType = TypeOfDictionary.CSharp;
            // AllTypeOfDictionary.instance.SetCurrentId(m_WordModel.Id);
            // AllTypeOfDictionary.instance.SetPreviousScene(SceneName.MainCSharp);
            // SceneManager.LoadScene(SceneName.Description.ToString());
        }
    }    
}