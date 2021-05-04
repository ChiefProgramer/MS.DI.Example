using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contracts.Forms { 
    public interface ILaunchPoint {
        Form Execute(string[] args);
        Task<Form> ExecuteAsync(string[] args);
    }
}
