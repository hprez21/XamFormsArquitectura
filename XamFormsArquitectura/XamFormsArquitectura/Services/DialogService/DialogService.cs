using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Acr.UserDialogs;

namespace XamFormsArquitectura.Services.DialogService
{
    public class DialogService : IDialogService
    {
        public Task ShowAlertAsync(string message, string title, string buttonLabel)
        {
            return UserDialogs.Instance.AlertAsync(message, title, buttonLabel);
        }

        public void StartLoading(string message)
        {
            UserDialogs.Instance.ShowLoading(message);
        }

        public void StopLoading()
        {
            UserDialogs.Instance.HideLoading();
        }
    }

}
