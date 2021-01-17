using UnityEngine;
using UnityEngine.SceneManagement; // 씬 관리자 관련 코드
using UnityEngine.UI; // UI 관련 코드

// 필요한 UI에 즉시 접근하고 변경할 수 있도록 허용하는 UI 매니저
public class UIManager : MonoBehaviour {

    public GameObject[] Buttons;
    
    // 싱글톤 접근용 프로퍼티
    public static UIManager instance
    {
        get
        {
            if (m_instance == null)
            {
                m_instance = FindObjectOfType<UIManager>();
            }

            return m_instance;
        }
    }

    private static UIManager m_instance; // 싱글톤이 할당될 변수


    private AudioSource audioSource;
    public Text ammoText; // 탄약 표시용 텍스트
    public Text RammoText; // 탄약 표시용 텍스트텍스트
    public Text scoreText; // 점수 표시용 텍스트
    public Text waveText; // 적 웨이브 표시용 텍스트
    public GameObject gameoverUI; // 게임 오버시 활성화할 UI 

    public Text _guiTime;

    private float _timeCnt = 156.46f;


    private int score = 0; // 현재 게임 점수

    private void Update()
    {
        _timeCnt -= Time.deltaTime;

        if(_timeCnt <=0)
        {
            _timeCnt = 0;
            SetActiveGameoverUI(true);
        }
    }

    void OnGUI()
    {
        string timeStr;
        timeStr = "" + _timeCnt.ToString("00 . 00");
        timeStr = timeStr.Replace(".", ":");
        _guiTime.text = timeStr;
    }

    // 탄약 텍스트 갱신
    public void H_UpdateAmmoText(int magAmmo, int remainAmmo) {
        ammoText.text = magAmmo + "/" + remainAmmo;
    }

    public void R_UpdateAmmoText(int magAmmo, int remainAmmo)
    {
        RammoText.text = magAmmo + "/" + remainAmmo;
    }

    // 점수 텍스트 갱신
    public void UpdateScoreText(int newScore) {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        score += newScore;
        scoreText.text = "Score : " + score;
    }

    // 게임 오버 UI 활성화
    public void SetActiveGameoverUI(bool active) {
        gameoverUI.SetActive(active);
    }

    // 게임 재시작
    public void GameRestart() {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    

    public void SetActivePistolButton()
    {
        Buttons[0].SetActive(true);
        Buttons[1].SetActive(false);
    }
    public void SetActiveRifleButton()
    {
        Buttons[1].SetActive(true);
        Buttons[0].SetActive(false);
    }

}