using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.ViewModels
{
    public class LoginResultVM
    {
        public bool IsSuccess {  get; set; }
        public string Message {  get; set; }
        public Int64 LoggedInId {  get; set; }
        public string LoggedInName { get; set; }
    }
}
