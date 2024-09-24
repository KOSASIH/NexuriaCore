using System;
using System.Collections.Generic;

namespace IRE
{
  public class IncentivizationEngine
  {
    private readonly List<RewardType> _rewardTypes;
    private readonly List<IncentiveProgram> _incentivePrograms;

    public IncentivizationEngine(IREConfig config)
    {
      _rewardTypes = config.RewardTypes;
      _incentivePrograms = config.IncentivePrograms;
    }

    public void ProcessIncentive(User user, IncentiveProgram program)
    {
      // Check if the user meets the rules of the incentive program
      if (program.Rules.All(rule => rule.IsMet(user)))
      {
        // Award the user with the corresponding reward
        var reward = program.RewardType.GetReward();
        user.Rewards.Add(reward);
      }
    }
  }
}
