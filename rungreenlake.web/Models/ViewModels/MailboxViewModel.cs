/*
 *+++MailboxViewModel+++
 * Allows a user to see their current messages and conversations.
 * 
*/

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using rungreenlake.web.Areas.Identity.Data;

namespace rungreenlake.Models.ViewModels
{
    public class MailboxViewModel
    {
        
        //Reply Data
        public int ReceiverID { get; set; }
        public int MsgID { get; set; }
        public Profile ReceiverProfile { get; set; }
        public RunGreenLakeUser ReceiverUser { get; set; }
        public Message MessageReplyingTo { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string Header { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(1000)]
        public string Body { get; set; }

        [Range(1, 10000, ErrorMessage = "Recipient is required.")]
        public SelectList ReceiverList { get; set; }

        public IEnumerable<Thread> Threads { get; set; }
        public IEnumerable<Conversation> Conversations { get; set; }
        public IEnumerable<Message> Messages { get; set; }
        public IEnumerable<RunGreenLakeUser> Profiles { get; set; }

    }
}
