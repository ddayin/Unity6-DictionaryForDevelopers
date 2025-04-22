using UnityEngine;

namespace AssembleWords
{
    public enum Category
    {
        Language = 0,
        English,
        GameEngines,
        Frontend,
        Backend,
    }

    public enum Languages
    {
        Assembly = 0,
        C,
        Cplusplus,
        Csharp,
        JavaScript,
        Python
    }

    public enum English
    {
        TOEIC = 0,
        TOEFL
    }

    public enum GameEngines
    {
        Unity6 = 0,
        UnrealEngine5
    }

    public enum Frontend
    {
        HTML = 0,
        CSS,
        React
    }

    public enum Backend
    {
        NodeJS = 0,
        PHP,
        MySQL,
        PostgreSQL
    }
}