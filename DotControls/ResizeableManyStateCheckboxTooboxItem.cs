using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.Design;
using Syndaryl.Windows.Forms;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.Serialization;

namespace Syndaryl.Windows.Forms
{
    [Serializable]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name = "FullTrust")]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name = "FullTrust")]
    class ResizeableManyStateCheckboxToolboxItem : ToolboxItem
    {
        // The add components dialog in VS looks for a public 
        // ctor that takes a type. 
        public ResizeableManyStateCheckboxToolboxItem(Type toolType)
			: base(toolType)
		{
		}

		// And you must provide this special constructor for serialization. 
		// If you add additional data to MyToolboxItem that you 
		// want to serialize, you may override Deserialize and 
		// Serialize methods to add that data.  
        ResizeableManyStateCheckboxToolboxItem(SerializationInfo info, StreamingContext context)
		{
			Deserialize(info, context);
		}

        // This implementation sets the new control's text and  
        // AutoSize properties. 
        protected override IComponent[] CreateComponentsCore(
            IDesignerHost host)
        {

            IComponent[] comps = base.CreateComponentsCore(host);

            // The returned IComponent array contains a single  
            // component, which is an instance of ResizeableManyStateCheckbox.
            //((ResizeableManyStateCheckbox)comps[0]).SetupDotsTable();

            return comps;
        }
    }
}
