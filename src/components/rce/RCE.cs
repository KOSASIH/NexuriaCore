using System;
using System.Collections.Generic;

namespace RCE
{
  public class RegulatoryComplianceEngine
  {
    private readonly List<RegulatoryFramework> _regulatoryFrameworks;
    private readonly List<Jurisdiction> _jurisdictions;

    public RegulatoryComplianceEngine(RCEConfig config)
    {
      _regulatoryFrameworks = config.RegulatoryFrameworks;
      _jurisdictions = config.Jurisdictions;
    }

    public void MonitorTransactions(Transaction transaction)
    {
      foreach (var framework in _regulatoryFrameworks)
      {
        foreach (var rule in framework.Rules)
        {
          if (!rule.IsCompliant(transaction))
          {
            throw new RegulatoryNonComplianceException(rule.Name);
          }
        }
      }
    }
  }
}
