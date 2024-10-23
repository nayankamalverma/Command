using Command.Main;
using UnityEngine;

namespace Command.Commands
{
    public class CleanseCommand: UnitCommand
    {
        private const float hitChance = 0.2f;
        private bool willHitTarget;

        public CleanseCommand(CommandData commandData)
        {
            this.commandData = commandData;
            willHitTarget = WillHitTarget();
        }

        public override bool WillHitTarget() => Random.Range(0f, 1f) < hitChance;

        public override void Execute() => GameService.Instance.ActionService.GetActionByType(CommandType.Cleanse).PerformAction(actorUnit, targetUnit, willHitTarget);
    }
}