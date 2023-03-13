using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField] InputAction IncreaseScore;
    [SerializeField] InputAction DecreaseScore;
    [SerializeField] InputAction ResetScore;
    [SerializeField] InputAction SaveScore;
    [SerializeField] InputAction LoadScore;
    [SerializeField] InputAction TrySaveHighScore;

    GameStates currentGameStates;
    // Start is called before the first frame update
    void Start()
    {
        currentGameStates = GameObject.FindGameObjectWithTag("GameStates").GetComponent<GameStates>();
    }

    private void OnEnable()
    {
        IncreaseScore.Enable();
        DecreaseScore.Enable();
        ResetScore.Enable();
        SaveScore.Enable();
        LoadScore.Enable();
        TrySaveHighScore.Enable();
    }

    private void OnDisable()
    {
        IncreaseScore.Disable();
        DecreaseScore.Disable();
        ResetScore.Disable();
        SaveScore.Disable();
        LoadScore.Disable();
        TrySaveHighScore.Disable();

    }

    // Update is called once per frame
    void Update()
    {
        if (IncreaseScore.WasPressedThisFrame())
        {
            IncreaseCurrentScore();
        }
        if (DecreaseScore.WasPressedThisFrame())
        {
            DecreaseCurrentScore();
        }
        if (ResetScore.WasPressedThisFrame())
        {
            ResetCurrentScore();
        }
        if (SaveScore.WasPressedThisFrame())
        {
            SaveCurrentScore();
        }
        if (LoadScore.WasPressedThisFrame())
        {
            LoadCurrentScore();
        }
    }

    void IncreaseCurrentScore()
    {
        currentGameStates.score += 1;
    }
    void DecreaseCurrentScore()
    {
        currentGameStates.score -= 1;
    }
    void ResetCurrentScore()
    {
        currentGameStates.score = 0;
    }
    void SaveCurrentScore()
    {
        FindObjectOfType<GameStateManager>().SaveToDisk();
    }
    void LoadCurrentScore()
    {
        FindObjectOfType<GameStateManager>().LoadFromDisk();
    }
}
