using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpState : PlayerState
{
    public PlayerJumpState(Player _player, PLayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
        SoundManager.instance.PlaySFX(1);

    }

    public override void Update()
    {
        base.Update();

        if(rb.velocity.y < 0)
            stateMachine.ChangeState(player.airState);
    }

    public override void Exit()
    {
        base.Exit();
        SoundManager.instance.StopSFX(1);
    }


}
