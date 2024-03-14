using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Manager
{
    static class SourceCodeManager
    {
        public static List<SourceCode> GetSourceCode(int taskID)
        {
            List<SourceCode> resultSourceCode = new List<SourceCode>();
            foreach(var Iter in SourceCodeCollection)
            {
                if(Iter.TaskID == taskID)
                {
                    resultSourceCode.Add(Iter);
                }
            }

            //Sorting Source Code
            {
                SourceCode temp;
                DateTime curr = DateTime.MaxValue;
                int currIdx = 0;
                for (int row = 0; row < resultSourceCode.Count; row++)
                {
                    curr = DateTime.MaxValue;
                    currIdx = 0;
                    for (int col = row; col < resultSourceCode.Count; col++)
                    {
                        if (curr > resultSourceCode[col].SubmittedDate)
                        {
                            curr = resultSourceCode[col].SubmittedDate;
                            currIdx = col;
                        }
                    }

                    temp = resultSourceCode[row];
                    resultSourceCode[row] = resultSourceCode[currIdx];
                    resultSourceCode[currIdx] = temp;
                }
            }

            return resultSourceCode;
        }

        public static void AssignSourceCode()
        {
            SourceCodeCollection = new List<SourceCode>();
            SourceCodeCollection.Add(new SourceCode()
            {
                TaskID = 1,
                SubmittedDate = new DateTime(2024, 03, 11),
                SourceCodeID = 1,
                CommitName = "Created",
                SourceCodeLocation = ""
            });
        }

        public static List<SourceCode> SourceCodeCollection;
    }
}
