using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMWinApp.UserControls;
using CRMWinApp.Models;

namespace CRMWinApp
{
    public interface IUserPermissionDisable
    {
        void Disable(List<Permission> permissions);
    }
}
