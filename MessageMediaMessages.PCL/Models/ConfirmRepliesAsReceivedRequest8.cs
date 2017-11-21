/*
 * MessageMediaMessages.PCL
 *
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using APIMATIC.SDK.Common;


namespace MessageMedia.Messages.Models
{
    public class ConfirmRepliesAsReceivedRequest8 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<Guid> replyIds;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("reply_ids")]
        public List<Guid> ReplyIds 
        { 
            get 
            {
                return this.replyIds; 
            } 
            set 
            {
                this.replyIds = value;
                onPropertyChanged("ReplyIds");
            }
        }
    }
} 