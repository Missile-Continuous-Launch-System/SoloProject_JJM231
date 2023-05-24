using System.Collections;
using System.Collections.Generic;   
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public string nextSceneName; // 다음 화면의 씬 이름을 설정하기 위한 변수
    
    public void OnStartButtonClick()
    {
        SceneManager.LoadScene(nextSceneName); // 다음 화면으로 씬을 로드합니다.
    }
}
