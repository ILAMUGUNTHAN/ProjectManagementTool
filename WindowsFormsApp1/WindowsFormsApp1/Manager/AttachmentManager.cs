using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Manager
{
    static class AttachmentManager
    {
        public static List<Attachment> GetAttachment(int taskID)
        {
            List<Attachment> result = new List<Attachment>();
            foreach (var Iter in AttachmentCollection)
            {
                if(Iter.TaskID == taskID)
                {
                    result.Add(Iter);
                }
            }

            return result;
        }

        public static void AssignAttachment()
        {
            AttachmentCollection = new List<Attachment>();
        }

        public static List<Attachment> AttachmentCollection;
    }
}
