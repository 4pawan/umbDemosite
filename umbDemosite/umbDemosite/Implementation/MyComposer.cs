using System.Linq;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Events;
using Umbraco.Core.Models;
using Umbraco.Core.Security;
using Umbraco.Core.Services;
using Umbraco.Core.Services.Implement;

namespace umbDemosite.Implementation
{
    public class MyComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            // Append our component to the collection of Components
            // It will be the last one to be run
            composition.Components().Append<MyComponent>();
        }
    }

    public class MyComponent : IComponent
    {
        // initialize: runs once when Umbraco starts
        public void Initialize()
        {
            ContentService.Saving += ContentService_Saving;
            MemberService.Saved += MemberService_Saved;
            //MediaService
          
        }

        // terminate: runs once when Umbraco stops
        public void Terminate()
        {

        }

        private void ContentService_Saving(IContentService sender, ContentSavingEventArgs e)
        {
            //Check if the content item type has a specific alias
            foreach (var content in e.SavedEntities.Where(c => c.ContentType.Alias.InvariantEquals("Tour")))
            {
                //Do something if the content is using the MyContentType doctype
                if (content.Id <= 0) //new record
                {
                    //e.Cancel = true;
                }
                else //existing record
                {
                    if (content.IsDirty())
                    {
                        //e.CancelOperation(new EventMessage("Foo permissions", "You cannot edit foo records", EventMessageType.Error));
                    }
                }

                if (content.ContentType.Alias == "aliasBar")
                {
                   // EmailService(content.Id);
                }
            }
        }
        private void MemberService_Saved(IMemberService sender, SaveEventArgs<IMember> e)
        {
            foreach (IMember member in e.SavedEntities)
            {
                //Check user is approved and the approve status has only just been changed (isdirty)
                if (member.IsApproved && member.HasProperty("umbracoMemberApproved") && member.Properties["umbracoMemberApproved"].IsDirty())
                {
                 
                }
            }
        }


    }
}