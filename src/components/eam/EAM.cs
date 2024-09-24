using System;
using System.Collections.Generic;

namespace EAM
{
  public class EducationEcosystem
  {
    private readonly List<LearningPath> _learningPaths;
    private readonly List<UserRole> _userRoles;

    public EducationEcosystem(EAMConfig config)
    {
      _learningPaths = config.LearningPaths;
      _userRoles = config.UserRoles;
    }

    public void EnrollUser(User user, UserRole role)
    {
      // Enroll the user in the learning paths associated with their role
      foreach (var learningPath in role.LearningPaths)
      {
        user.LearningPaths.Add(learningPath);
      }
    }

    public void CompleteModule(User user, Module module)
    {
      // Mark the module as completed for the user
      user.CompletedModules.Add(module);
    }
  }
}
