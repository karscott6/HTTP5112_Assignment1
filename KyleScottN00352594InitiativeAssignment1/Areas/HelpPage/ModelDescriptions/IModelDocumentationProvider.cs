using System;
using System.Reflection;

namespace InitiativeAssignment1KyleScottN00352594.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}