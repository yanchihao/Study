using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study.IService;

namespace Study.Service
{
    public class StudyAutoFacService: IStudyAutoFacService
    {
        public string GetText(string txtMsg)
        {
            return txtMsg;
        }
    }
}
