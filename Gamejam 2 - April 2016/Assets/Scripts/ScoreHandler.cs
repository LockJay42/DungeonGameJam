using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour {

    public Text playerOneScore;
    public Text playerTwoScore;
    public Text playerThreeScore;
    public Text dungeonMasterScore;

    public PlayerScript playerOne;
    public PlayerScript playerTwo;
    public PlayerScript playerThree;
    public DungeonMaster dungeonMaster;

    // Use this for initialization
    void Start()
    {
        playerOneScore.text = "0";
        playerTwoScore.text = "0";
        playerThreeScore.text = "0";
        dungeonMasterScore.text = "0";
    }
	
	// Update is called once per frame
	void Update()
    {
        playerOneScore.text = playerOne.score.ToString();
        playerTwoScore.text = playerTwo.score.ToString();
        playerThreeScore.text = playerThree.score.ToString();
        dungeonMasterScore.text = dungeonMaster.score.ToString();

    }
}
