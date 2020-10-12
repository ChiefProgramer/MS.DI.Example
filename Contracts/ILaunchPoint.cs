using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts {
    public interface ILaunchPoint {
        void Execute(string[] args);
        Task ExecuteAsync(string[] args);
    }
}
