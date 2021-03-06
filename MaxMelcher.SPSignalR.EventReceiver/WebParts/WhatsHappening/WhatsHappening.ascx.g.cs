﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MaxMelcher.SPSignalR.EventReceiver.WebParts.WhatsHappening {
    using System.Web.UI.WebControls.Expressions;
    using System.Web.UI.HtmlControls;
    using System.Collections;
    using System.Text;
    using System.Web.UI;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using Microsoft.SharePoint.WebPartPages;
    using System.Web.SessionState;
    using System.Configuration;
    using Microsoft.SharePoint;
    using System.Web;
    using System.Web.DynamicData;
    using System.Web.Caching;
    using System.Web.Profile;
    using System.ComponentModel.DataAnnotations;
    using System.Web.UI.WebControls;
    using System.Web.Security;
    using System;
    using Microsoft.SharePoint.Utilities;
    using System.Text.RegularExpressions;
    using System.Collections.Specialized;
    using System.Web.UI.WebControls.WebParts;
    using Microsoft.SharePoint.WebControls;
    
    
    public partial class WhatsHappening {
        
        public static implicit operator global::System.Web.UI.TemplateControl(WhatsHappening target) 
        {
            return target == null ? null : target.TemplateControl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void @__BuildControlTree(global::MaxMelcher.SPSignalR.EventReceiver.WebParts.WhatsHappening.WhatsHappening @__ctrl) {
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl(@"


<script src=""/_layouts/15/MaxMelcher.SPSignalR.EventReceiverExample/jquery-1.6.4.min.js""></script>
<script src=""/_layouts/15/MaxMelcher.SPSignalR.EventReceiverExample/jquery.signalR-1.1.2.min.js""></script>
<script src=""/signalr/hubs"" type=""text/javascript""></script>

<h2>What's happening?</h2>

<div id=""container"">
</div>

<script type=""text/javascript"">
    $.connection.hub.logging = true;

    var myHub = $.connection.docLibHub;



    myHub.client.Notify = function (title, url, type) {
        var eventtype;
        if (type == 0) {
            eventtype = ""added"";
        }
        else if (type == 1) {
            eventtype = ""updated"";
        } else
            eventtype = ""deleted"";

        $('#container').append('<li><a href=""' + url + '"">' + title + '</a>: ' + eventtype + '</li>');
    };

    $.connection.hub.error(function () {
        alert(""An error occured"");
    });

    $.connection.hub.start()
                    .done(function () {

                    })
                    .fail(function () {
                        alert(""Could not Connect!"");
                    });
</script>"));
        }
        
        private void InitializeControl() {
            this.@__BuildControlTree(this);
            this.Load += new global::System.EventHandler(this.Page_Load);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected virtual object Eval(string expression) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected virtual string Eval(string expression, string format) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression, format);
        }
    }
}
