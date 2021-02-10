using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamFormsArquitectura.ViewModels.Base;

namespace XamFormsArquitectura.Services.NavigationService
{
    public interface INavigationService
    {
        ViewModelBase PreviousPageViewModel { get; }

        Task InitializeAsync();

        Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase;

        Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase;

        Task RemoveLastFromBackStackAsync();

        Task RemoveBackStackAsync();
    }

}
