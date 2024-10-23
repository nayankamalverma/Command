using Command.Main;
using UnityEngine;

namespace Command.Commands
{
    public class ThiedEyeCommand: UnitCommand
    {
        private bool willHitTarget;

        public ThiedEyeCommand(CommandData commandData)
        {
            this.commandData = commandData;
            willHitTarget = WillHitTarget();
        }

        public override bool WillHitTarget() => true;

        public override void Execute() => GameService.Instance.ActionService.GetActionByType(CommandType.ThirdEye).PerformAction(actorUnit, targetUnit, willHitTarget);
    }
}
