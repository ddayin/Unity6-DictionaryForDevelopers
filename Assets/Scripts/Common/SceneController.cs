using UnityEngine.SceneManagement;
using WanzyeeStudio;

namespace Dictionary
{
    public enum SceneName
    {
        Login = 0,
        SignUp,
        Title,
        Category,
        WordList,
        Description,
        License,
        PuzzleGame = 10,
        MindMap = 11,
    }
    
    public class SceneController : BaseSingleton<SceneController>
    {
        public SceneName currentSceneName = SceneName.Login;

        public Category currentCategory = Category.Language;
        public Languages currentLanguage = Languages.Assembly;
        public English currentEnglish = English.TOEIC;
        public GameEngines currentGameEngine = GameEngines.Unity6;
        public Frontend currentFrontend = Frontend.HTML;
        public Backend currentBackend = Backend.NodeJS;


        protected override void Awake()
        {
            base.Awake();
        }
        
        public void LoadScene(SceneName _sceneName)
        {
            currentSceneName = _sceneName;            
            string number = ((int)_sceneName).ToString(); 
            string sceneName = number + "_" + _sceneName.ToString();            
            SceneManager.LoadScene(sceneName);
        }

        /*
        public void LoadCategory(Category _category)
        {
            currentCategory = _category;
            currentSceneName = SceneName.Category;
            string number = ((int)currentSceneName).ToString();
            string sceneName = number + "_" + currentSceneName.ToString();
            SceneManager.LoadScene(sceneName);
        }

        public void LoadLanguage(Languages _language)
        {
            currentLanguage = _language;
            currentSceneName = SceneName.WordList;
            string number = ((int)currentSceneName).ToString();
            string sceneName = number + "_" + currentSceneName.ToString();

            SceneManager.LoadScene(sceneName);
        }

        public void LoadEnglish(English _english)
        {
            currentEnglish = _english;
            currentSceneName = SceneName.WordList;
            string number = ((int)currentSceneName).ToString();
            string sceneName = number + "_" + currentSceneName.ToString();

            SceneManager.LoadScene(sceneName);
        }

        public void LoadGameEngines(GameEngines _gameEngine)
        {
            currentGameEngine = _gameEngine;
            currentSceneName = SceneName.WordList;
            string number = ((int)currentSceneName).ToString();
            string sceneName = number + "_" + currentSceneName.ToString();
            SceneManager.LoadScene(sceneName);
        }

        public void LoadFrontend(Frontend _frontend)
        {
            currentFrontend = _frontend;
            currentSceneName = SceneName.WordList;
            string number = ((int)currentSceneName).ToString();
            string sceneName = number + "_" + currentSceneName.ToString();
            SceneManager.LoadScene(sceneName);
        }

        public void LoadBackend(Backend _backend)
        {
            currentBackend = _backend;
            currentSceneName = SceneName.WordList;
            string number = ((int)currentSceneName).ToString();
            string sceneName = number + "_" + currentSceneName.ToString();
            SceneManager.LoadScene(sceneName);
        }
        */
    }
}
