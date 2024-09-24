using System;
using System.Collections.Generic;

namespace PCH
{
  public class PartnershipHub
  {
    private readonly List<Partner> _partners;
    private readonly List<CollaborationType> _collaborationTypes;

    public PartnershipHub(PCHConfig config)
    {
      _partners = config.Partners;
      _collaborationTypes = config.CollaborationTypes;
    }

    public void CreateCollaboration(Partner partner, CollaborationType collaborationType)
    {
      // Create a new collaboration instance
      var collaboration = new Collaboration(partner, collaborationType);
      // Add the collaboration to the partner's list of collaborations
      partner.Collaborations.Add(collaboration);
    }
  }
}
