using System;
using UnityEngine;

public class TurnBasedStrategy : MonoBehaviour
{
    private enum PlayerAction
    {
        NoEnemy,
        NoPathToEnemy,
        MovingTowardEnemy,
        AttackingEnemy
    }

    private enum State
    {
        LookingForEnemy,
        MovingToEnemy,
        AttackingEnemy
    }

    private enum TutorialStage
    {
        Stage_1,
        Stage_2,
        Stage_3,
        Stage_4,
    }
    
    private State state;
    
    private void Start()
    {
        PlayerAction playerAction = PlayerAction.NoPathToEnemy;
        // Debug.Log((int)playerAction);
        Debug.Log((PlayerAction)2);
        
        TutorialStage tutorialStage = TutorialStage.Stage_1;
        tutorialStage++;
        // Debug.Log(tutorialStage);
        string tutorialStageString = tutorialStage.ToString();
        Debug.Log(Enum.Parse<TutorialStage>(tutorialStageString));
        
        Debug.Log("-----");
        foreach (TutorialStage tutorialStage1 in Enum.GetValues(typeof(TutorialStage)))
        {
            Debug.Log(tutorialStage1);
        }
    }

    private void HandleState()
    {
        switch (state)
        {
            case State.MovingToEnemy: 
                break;
            case State.LookingForEnemy: 
                break;
            case State.AttackingEnemy: 
                break;
        }
    }
    
    private PlayerAction GetNextPlayerAction()
    {
        // PlayerAction playerAction = PlayerAction.MovingTowardEnemy;
        
        if (!PlayerHasEnemy())
        {
            return PlayerAction.NoEnemy;
        }
        if (!HasPathToEnemy())
        {
            return PlayerAction.NoPathToEnemy;
        }

        if (!PlayerWithinAttackDistance())
        {
            return PlayerAction.MovingTowardEnemy;
        }
        else
        {
            return PlayerAction.AttackingEnemy;
        }
    }
    private bool PlayerHasEnemy()
    {
        return true;
    }
    private bool HasPathToEnemy()
    {
        return true;
    }
    private bool PlayerWithinAttackDistance()
    {
        return true;
    }
}
