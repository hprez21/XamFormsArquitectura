using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XamFormsArquitectura.Services.DialogService
{
    public interface IDialogService
    {
        Task ShowAlertAsync(string message, string title, string buttonLabel);
        void StartLoading(string message);
        void StopLoading();
    }

}
